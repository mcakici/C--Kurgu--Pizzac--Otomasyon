using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using restoran_Otomasyon_Soldier;


namespace restoran_Otomasyon_Commander
{
   public class do_products
   {
      public static void Update(products p, string mat)
      {
         string[] matdizi = mat.Split(',');
         string[] matid = new string[0];

         for (int i = 0; i < matdizi.Length; i++)
         {
            SqlConnection cnn2 = new SqlConnection(tools.ConnectionString);
            SqlCommand cmd2 = new SqlCommand("select * from materials where m_name='" + matdizi[i] + "'", cnn2);
            cnn2.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
               Array.Resize(ref matid, matid.Length + 1);
               matid[matid.Length - 1] = dr2["m_id"].ToString();
            }
            cnn2.Close();
         }

         string kaydetMalzeme = string.Join(",", matid);

         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("Update products Set p_name=@name, p_desc=@desc, p_price=@price, p_imgpath=@img, p_materials=@materials where p_id=@id", cnn);
         cmd.Parameters.AddWithValue("@name", p.Name);
         cmd.Parameters.AddWithValue("@desc", p.Desc);
         cmd.Parameters.AddWithValue("@img", p.ImgPath);
         cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(p.Price));
         cmd.Parameters.AddWithValue("@materials", kaydetMalzeme);
         cmd.Parameters.AddWithValue("@id", Convert.ToInt32(p.Id));
         cnn.Open();
         cmd.ExecuteNonQuery();
         cnn.Close();
      }
      //######################################################
      public static List<products> SelectById(products p)
      {
         List<products> pList = new List<products>();
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("select * from products where p_id=@id", cnn);
         cmd.Parameters.AddWithValue("@id", p.Id);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            products pl = new products();
            pl.Id = dr["p_id"].ToString();
            pl.Name = dr["p_name"].ToString();
            pl.Desc = dr["p_desc"].ToString();
            pl.ImgPath = dr["p_imgpath"].ToString();
            pl.Price = dr["p_price"].ToString();
            pl.Materials = dr["p_materials"].ToString();
            pList.Add(pl);
         }
         cnn.Close();
         return pList;
      }
      //######################################################
      public static List<products> SelectAll()
      {
         List<products> pList = new List<products>();
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("select * from products", cnn);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            products p = new products();
            p.Id = dr["p_id"].ToString();
            p.Name = dr["p_name"].ToString();
            p.Desc = dr["p_desc"].ToString();
            p.ImgPath = dr["p_imgpath"].ToString();
            p.Materials = dr["p_materials"].ToString();
            p.Price = dr["p_price"].ToString();

            pList.Add(p);
         }
         cnn.Close();
         return pList;
      }
      //######################################################
      //#######################################
      public static void Insert(products p, string mat)
      {
         string[] matdizi = mat.Split(',');
         string[] matid = new string[0];

         for (int i = 0; i < matdizi.Length; i++)
         {
            SqlConnection cnn2 = new SqlConnection(tools.ConnectionString);
            SqlCommand cmd2 = new SqlCommand("select * from materials where m_name='" + matdizi[i] + "'", cnn2);
            cnn2.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
               Array.Resize(ref matid, matid.Length + 1);
               matid[matid.Length-1] = dr2["m_id"].ToString();
            }
            cnn2.Close();
         }
         string kaydetMalzeme = " ";
         kaydetMalzeme = string.Join(",", matid);


         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("insert into Products(p_name,p_desc,p_imgpath,p_materials,p_price)Values(@name,@desc,@img,@materials,@price) Select @@identity", cnn);
         cmd.Parameters.AddWithValue("@name", p.Name);
         cmd.Parameters.AddWithValue("@desc", p.Desc);
         cmd.Parameters.AddWithValue("@img", p.ImgPath);
         cmd.Parameters.AddWithValue("@price", p.Price);
         cmd.Parameters.AddWithValue("@materials", kaydetMalzeme);
         cnn.Open();
         p.Id = cmd.ExecuteScalar().ToString();
         cnn.Close();
      }
      //#######################################

      //######################################################
      public static List<products> BayiProductsSelectById(login l)
      {

         List<products> pList = new List<products>();
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("select * from dealerProducts as dp inner join products as p on p.p_id=dp.p_id  where status=1 AND dp.d_id=@id", cnn);
         cmd.Parameters.AddWithValue("@id", l.Id);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            products pl = new products();
            pl.Id = dr["p_id"].ToString();
            pl.Name = dr["p_name"].ToString();
            pl.Desc = dr["p_desc"].ToString();
            pl.ImgPath = dr["p_imgpath"].ToString();
            pl.Price = dr["p_price"].ToString();
            pl.Materials = dr["p_materials"].ToString();
            //pl.status = (bool)dr["status"];
            pList.Add(pl);
         }
         cnn.Close();
         return pList;
      }
      //######################################################

      public static void BayiProductsUpdate(products p, login l)
      {

         try
         {
            SqlConnection cnn3 = new SqlConnection(tools.ConnectionString);
            SqlCommand cmd3 = new SqlCommand("insert into dealerProducts(p_id,d_id,status)values(@pid,@did,@status)", cnn3);
            cmd3.Parameters.AddWithValue("@pid", p.Id);
            cmd3.Parameters.AddWithValue("@did", l.Id);
            cmd3.Parameters.AddWithValue("@status", p.status);
            cnn3.Open();
            cmd3.ExecuteNonQuery();
            cnn3.Close();
         }
         catch
         {
            SqlConnection cnn = new SqlConnection(tools.ConnectionString);
            SqlCommand cmd = new SqlCommand("UPDATE dealerProducts SET status=@status WHERE d_id=@did AND p_id=@pid", cnn);
            cmd.Parameters.AddWithValue("@status", p.status);
            cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(p.Id));
            cmd.Parameters.AddWithValue("@did", Convert.ToInt32(l.Id));
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
         }
      }
      //######################################################




   }
}
