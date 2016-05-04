using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using restoran_Otomasyon_Soldier;

namespace restoran_Otomasyon_Commander
{
   public class do_materials
   {
      //######################################################
      public static List<materials> MultiSelect(string idler)
      {
         string[] yenidizi = idler.Split(',');

         List<materials> mList = new List<materials>();

         foreach (var item in yenidizi)
         {
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("select * from materials WHERE m_id=@id", cnn);
         cmd.Parameters.AddWithValue("@id", item);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            materials m = new materials();
            m.Id = dr["m_id"].ToString();
            m.Name = dr["m_name"].ToString();

            mList.Add(m);
         }
         cnn.Close();
         }
         return mList;
      }
      //######################################################
      public static List<materials> SelectAll()
      {
         List<materials> mList = new List<materials>();
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("select * from materials", cnn);
         cnn.Open();
         SqlDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            materials m = new materials();
            m.Id = dr["m_id"].ToString();
            m.Name = dr["m_name"].ToString();

            mList.Add(m);
         }
         cnn.Close();
         return mList;
      }
      //######################################################
      public static void Insert(materials m)
      {
         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("insert into materials(m_name)Values(@name) Select @@Identity", cnn);
         cmd.Parameters.AddWithValue("@name", m.Name);
         cnn.Open();
         m.Id = cmd.ExecuteScalar().ToString();
         cnn.Close();
      }
      //######################################################
   }
}
