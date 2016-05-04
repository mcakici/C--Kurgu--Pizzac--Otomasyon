using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using restoran_Otomasyon_Commander;
using restoran_Otomasyon_Soldier;

namespace restoran_Otomasyon_WinUI
{
   public partial class yeniurun : Form
   {
      public yeniurun()
      {
         InitializeComponent();
      }

      private void yeniurun_Load(object sender, EventArgs e)
      {
         checkedListBox_malzemelist.Items.AddRange(do_materials.SelectAll().ToArray());

         listBox_mevcuturunler.Items.AddRange(do_products.SelectAll().ToArray());

      }

      private void button_malzemeekle_Click(object sender, EventArgs e)
      {
         if (textBox_yenimalzeme.TextLength < 1) return;

         materials eklenecek = new materials();
         eklenecek.Name = textBox_yenimalzeme.Text;

         do_materials.Insert(eklenecek);

         textBox_yenimalzeme.Text = string.Empty;
         checkedListBox_malzemelist.Items.Clear();
         checkedListBox_malzemelist.Items.AddRange(do_materials.SelectAll().ToArray());
      }

      private void checkedListBox_malzemelist_SelectedIndexChanged(object sender, EventArgs e)
      {
      }

      private void button_urunekle_Click(object sender, EventArgs e)
      {
         if (textBox_urunadi.Text.Length <= 0 || textBox_fiyat.Text.Length <= 0 || textBox_urunaciklama.Text.Length <= 0 || textBox_resimyolu.Text.Length <= 0) return;

         if (textBox_id.Text != string.Empty)
         {
            products guncellenecek = new products();
            guncellenecek.Id = textBox_id.Text;
            guncellenecek.Name = textBox_urunadi.Text;
            guncellenecek.Desc = textBox_urunaciklama.Text;
            guncellenecek.ImgPath = textBox_resimyolu.Text;
            guncellenecek.Price = textBox_fiyat.Text;

            // çhekedlistbox seçilen itemleri diziye al (kafayı yemek için ideal)
            object[] items = checkedListBox_malzemelist.CheckedItems.OfType<object>().ToArray();

            //php implode işlemi diziyi string ifadeye dönüştür.
            string secilenler = string.Join(",", items);

            do_products.Update(guncellenecek, secilenler);

            listBox_mevcuturunler.Items.Clear();
            listBox_mevcuturunler.Items.AddRange(do_products.SelectAll().ToArray());
         }
         else
         {
            products eklenecek = new products();
            eklenecek.Name = textBox_urunadi.Text;
            eklenecek.Desc = textBox_urunaciklama.Text;
            eklenecek.ImgPath = textBox_resimyolu.Text;
            eklenecek.Price = textBox_fiyat.Text;

            // çhekedlistbox seçilen itemleri diziye al (kafayı yemek için ideal)
            object[] items = checkedListBox_malzemelist.CheckedItems.OfType<object>().ToArray();

            //php implode işlemi diziyi string ifadeye dönüştür.
            string secilenler = string.Join(",", items);

            do_products.Insert(eklenecek, secilenler);

            listBox_mevcuturunler.Items.Clear();
            listBox_mevcuturunler.Items.AddRange(do_products.SelectAll().ToArray());
         }

      }

      private void listBox_mevcuturunler_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listBox_mevcuturunler.SelectedIndex == -1) return;

         products secilen = listBox_mevcuturunler.SelectedItem as products;
         textBox_urunadi.Text = secilen.Name;
         textBox_fiyat.Text = secilen.Price.ToString();
         textBox_resimyolu.Text = secilen.ImgPath.ToString();
         textBox_urunaciklama.Text = secilen.Desc.ToString();
         textBox_id.Text = secilen.Id.ToString();


         for (int i = 0; i < checkedListBox_malzemelist.Items.Count; i++)
         {
            checkedListBox_malzemelist.SetItemCheckState(i, CheckState.Unchecked);
         }

         var liste = do_materials.MultiSelect(secilen.Materials.ToString()).ToArray();


         for (int p = 0; p < checkedListBox_malzemelist.Items.Count; p++)
         {
            foreach (var item in liste)
            {
               string deger = checkedListBox_malzemelist.Items[p].ToString();
               if (deger == item.ToString())
                  checkedListBox_malzemelist.SetItemCheckState(p, CheckState.Checked);
            }

         }


      }

      private void button_reset_Click(object sender, EventArgs e)
      {
         textBox_fiyat.Text = textBox_id.Text = textBox_resimyolu.Text = textBox_urunaciklama.Text = textBox_urunadi.Text = textBox_yenimalzeme.Text = string.Empty;
         listBox_mevcuturunler.SelectedIndex = -1;
      }




   }
}
