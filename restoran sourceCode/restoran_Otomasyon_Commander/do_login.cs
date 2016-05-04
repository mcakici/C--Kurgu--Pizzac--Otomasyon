using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using restoran_Otomasyon_Soldier;

namespace restoran_Otomasyon_Commander
{
   public class do_login
   {
      public static void Insert(login l)
      {
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("insert into logins(l_username,l_password,l_firstname,l_lastname,l_phone,l_address,l_type,l_status)Values(@username,@password,@firstname,@lastname,@phone,@address,@type,@status) Select @@Identity", cnn);
         cmd.Parameters.AddWithValue("@username", l.Username);
         cmd.Parameters.AddWithValue("@password", tools.MD5Sifrele(l.Password));
         cmd.Parameters.AddWithValue("@firstname", l.Firstname);
         cmd.Parameters.AddWithValue("@lastname", l.Lastname);
         cmd.Parameters.AddWithValue("@phone", l.Phone);
         cmd.Parameters.AddWithValue("@address", l.Address);
         cmd.Parameters.AddWithValue("@type", l.Type);
         cmd.Parameters.AddWithValue("@status", l.Status);

         cnn.Open();
         l.Id = cmd.ExecuteScalar().ToString();
         cnn.Close();
      }
      public static void Update(login l)
      {
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("update logins set  l_username=@username,l_firstname=@firstname,l_lastname=@lastname,l_phone=@phone,l_address=@address,l_type=@type,l_status=@status where l_id=@id", cnn);
         cmd.Parameters.AddWithValue("@id", Convert.ToInt32(l.Id));
         cmd.Parameters.AddWithValue("@username", l.Username);
         cmd.Parameters.AddWithValue("@firstname", l.Firstname);
         cmd.Parameters.AddWithValue("@lastname", l.Lastname);
         cmd.Parameters.AddWithValue("@phone", l.Phone);
         cmd.Parameters.AddWithValue("@address", l.Address);
         cmd.Parameters.AddWithValue("@type", l.Type);
         cmd.Parameters.AddWithValue("@status", l.Status);
         cnn.Open();
         cmd.ExecuteNonQuery();
         cnn.Close();
      }



      //######################################################
      public static List<login> SelectById(login l)
      {
         List<login> lList = new List<login>();
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("select * from logins where l_id=@id", cnn);
         cmd.Parameters.AddWithValue("@id", l.Id);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            login ll = new login();
            ll.Id = dr["l_id"].ToString();
            ll.Firstname = dr["l_firstname"].ToString();
            ll.Lastname = dr["l_lastname"].ToString();
            ll.Address = dr["l_address"].ToString();
            ll.Phone = dr["l_phone"].ToString();
            ll.Username = dr["l_username"].ToString();
            ll.Password = dr["l_password"].ToString();
            ll.Type = (int)dr["l_type"];
            ll.Status = (bool)dr["l_status"];
            lList.Add(ll);
         }
         cnn.Close();
         return lList;
      }
      //######################################################
      //######################################################
      public static int SelectByUsername(string username, string password, int type)
      {
         int userid = 0;
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("select * from logins where l_username=@username AND l_password=@password AND l_type=@type", cnn);
         cmd.Parameters.AddWithValue("@username", username);
         cmd.Parameters.AddWithValue("@password", tools.MD5Sifrele(password));
         cmd.Parameters.AddWithValue("@type", type);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         login ll = new login();
         while (dr.Read())
         {
            ll.Id = dr["l_id"].ToString();
            userid = Convert.ToInt32(dr["l_id"]);
         }
         cnn.Close();
         return userid;
      }
      //######################################################
      public static List<login> SelectAll(int bayi = 0,  int logintype = 0, int onlyBayi = 0)
      {
         List<login> lList = new List<login>();
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         string sorgu = "";
         if (bayi == 1)
         {
            if (onlyBayi > 0 && logintype == 2)
            {
               sorgu = "select * from logins where l_status = 1 and l_type=2 and l_id=" + onlyBayi + " order by l_type ASC";
            }
            else
            {
               sorgu = "select * from logins where l_status = 1 and l_type=2 order by l_type ASC";
            }
         }
         else if (bayi == 0)
         {
            sorgu = "select * from logins order by l_type ASC";
         }
         SqlCommand cmd = new SqlCommand(sorgu, cnn);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            login ll = new login();
            ll.Id = dr["l_id"].ToString();
            ll.Firstname = dr["l_firstname"].ToString();
            ll.Lastname = dr["l_lastname"].ToString();
            ll.Address = dr["l_address"].ToString();
            ll.Phone = dr["l_phone"].ToString();
            ll.Username = dr["l_username"].ToString();
            ll.Password = dr["l_password"].ToString();
            ll.Type = (int)dr["l_type"];
            ll.Status = (bool)dr["l_status"];
            lList.Add(ll);
         }
         cnn.Close();
         return lList;
      }



      
      //######################################################
   }
}
