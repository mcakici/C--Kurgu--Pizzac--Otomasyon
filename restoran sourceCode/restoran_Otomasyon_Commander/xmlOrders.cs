using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using restoran_Otomasyon_Soldier;
using System.Data.SqlClient;
using System.Xml;
using System.IO;

namespace restoran_Otomasyon_Commander
{
   public class xmlOrders
   {
      public static void SiparisYaz(orders o)
      {
         XmlDocument xDoc;
         XmlElement xRoot;
         xDoc = new XmlDocument();
         if (File.Exists(@"data\orders_dealerid_" + o.BayiId + ".xml"))
         {
            xDoc.Load(@"data\orders_dealerid_" + o.BayiId + ".xml");
            xRoot = xDoc.DocumentElement;
         }
         else
         {
            xRoot = xDoc.CreateElement("Bayi");
            xDoc.AppendChild(xRoot);
            xDoc.Save(@"data\orders_dealerid_" + o.BayiId + ".xml");
         }






         XmlElement xSiparis = xDoc.CreateElement("Siparis");

         // Id attribute ü oluşturuluyor
         XmlAttribute xId = xDoc.CreateAttribute("Id");
         xId.Value = Guid.NewGuid().ToString();
         xSiparis.Attributes.Append(xId);

         XmlElement xAd = xDoc.CreateElement("Name");
         xAd.InnerText = o.Name;
         xSiparis.AppendChild(xAd);

         XmlElement xBayi = xDoc.CreateElement("Bayi");
         xBayi.InnerText = o.BayiId.ToString();
         xSiparis.AppendChild(xBayi);

         XmlElement xBoyut = xDoc.CreateElement("Boyut");
         xBoyut.InnerText = o.Boyut;
         xSiparis.AppendChild(xBoyut);

         XmlElement xAdet = xDoc.CreateElement("Adet");
         xAdet.InnerText = o.Count.ToString();
         xSiparis.AppendChild(xAdet);

         XmlElement xHamurTipi = xDoc.CreateElement("HamurTipi");
         xHamurTipi.InnerText = o.HamurTipi;
         xSiparis.AppendChild(xHamurTipi);

         XmlElement xIcecek = xDoc.CreateElement("Icecek");
         xIcecek.InnerText = o.Icecek;
         xSiparis.AppendChild(xIcecek);

         XmlElement xZaman = xDoc.CreateElement("Zaman");
         xZaman.InnerText = o.Zaman.ToString();
         xSiparis.AppendChild(xZaman);

         XmlElement xTutar = xDoc.CreateElement("Tutar");
         xTutar.InnerText = o.Fiyat.ToString();
         xSiparis.AppendChild(xTutar);





         // save 
         xRoot.AppendChild(xSiparis);
         xDoc.Save(@"data\orders_dealerid_" + o.BayiId + ".xml");










         /*

         XmlTextWriter w = new XmlTextWriter(@"data\orders_dealerid_"+o.BayiId+".xml", Encoding.UTF8);
         w.Formatting = Formatting.Indented;

         //Orders Start
         w.WriteStartElement("Bayi");
         //Siparis Start
         w.WriteStartElement("Siparis");
         //Siparis Özellikleri
         w.WriteAttributeString("Id", Guid.NewGuid().ToString());
         w.WriteElementString("Name", o.Name);
         w.WriteElementString("Bayi", o.BayiId.ToString());
         w.WriteElementString("Boyut", o.Boyut);
         w.WriteElementString("Adet", o.Count.ToString());
         w.WriteElementString("HamurTipi", o.HamurTipi);
         w.WriteElementString("Icecek", o.Icecek);
         w.WriteElementString("Zaman", o.Zaman.ToString());
         //Siparis End
         w.WriteEndElement();
         // Orders End
         w.WriteEndElement();

         w.Close();
         */
      }



      public static List<orders> ReadXML(login l)
      {
         List<orders> oList = new List<orders>();


         XmlDocument xDoc;
         XmlElement xRoot;
         xDoc = new XmlDocument();
         if (File.Exists(@"data\orders_dealerid_" + l.Id + ".xml"))
         {
            xDoc.Load(@"data\orders_dealerid_" + l.Id + ".xml");
            xRoot = xDoc.DocumentElement;
         }
         else
         {
            xRoot = xDoc.CreateElement("Bayi");
            xDoc.AppendChild(xRoot);
            xDoc.Save(@"data\orders_dealerid_" + l.Id + ".xml");
         }

         if (xRoot.HasChildNodes)
         {
            XmlNodeList Siparis = xRoot.SelectNodes("Siparis");

            foreach (XmlNode item in Siparis)
            {
               orders op = new orders();
               op.Id = item.Attributes[0].Value;
               op.Name = item.ChildNodes[0].InnerText;
               op.BayiId = Convert.ToInt32(item.ChildNodes[1].InnerText);
               op.Boyut = item.ChildNodes[2].InnerText;
               op.Count = Convert.ToInt32(item.ChildNodes[3].InnerText);
               op.HamurTipi = item.ChildNodes[4].InnerText;
               op.Icecek = item.ChildNodes[5].InnerText;
               op.Zaman = Convert.ToDateTime(item.ChildNodes[6].InnerText);
               op.Fiyat = Convert.ToDecimal(item.ChildNodes[7].InnerText);


               oList.Add(op);
            }
         }
         return oList;

      }








      public static void DeleteXMLNode(orders o)
      {
         XmlDocument xDoc;
         XmlElement xRoot;
         xDoc = new XmlDocument();
         if (File.Exists(@"data\orders_dealerid_" + o.BayiId + ".xml"))
         {
            xDoc.Load(@"data\orders_dealerid_" + o.BayiId + ".xml");
            xRoot = xDoc.DocumentElement;
         }
         else
         {
            xRoot = xDoc.CreateElement("Bayi");
            xDoc.AppendChild(xRoot);
            xDoc.Save(@"data\orders_dealerid_" + o.BayiId + ".xml");
         }

         if (xRoot.HasChildNodes)
         {
            XmlNode silinecek = xRoot.SelectSingleNode("Siparis[@Id='" + o.Id + "']");
            xRoot.RemoveChild(silinecek);
            xDoc.Save(@"data\orders_dealerid_" + o.BayiId + ".xml");
         }


      }













      public static void Insert(orders o, int loginid)
      {

         SqlConnection cnn = new SqlConnection(tools.ConnectionString);
         SqlCommand cmd = new SqlCommand("insert into sold(s_datetime,s_customerid,s_dealersid,s_count,s_fiyat,s_boyut,s_hamur,s_icecek,s_productname)Values(@date,@customerid,@did,@count,@fiyat,@boyut,@hamur,@icecek,@name) Select @@identity", cnn);
         cmd.Parameters.AddWithValue("@date", o.Zaman);
         cmd.Parameters.AddWithValue("@customerid", loginid);
         cmd.Parameters.AddWithValue("@did", o.BayiId);
         cmd.Parameters.AddWithValue("@count", o.Count);
         cmd.Parameters.AddWithValue("@fiyat", o.Fiyat);
         cmd.Parameters.AddWithValue("@boyut", o.Boyut);
         cmd.Parameters.AddWithValue("@hamur", o.HamurTipi);
         cmd.Parameters.AddWithValue("@icecek", o.Icecek);
         cmd.Parameters.AddWithValue("@name", o.Name);
         cnn.Open();
         cmd.ExecuteNonQuery();
         cnn.Close();
      }
      //#######################################
   }
}
