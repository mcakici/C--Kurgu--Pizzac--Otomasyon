using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using restoran_Otomasyon_Soldier;
using restoran_Otomasyon_Commander;

namespace restoran_Otomasyon_WinUI
{
   public partial class siparisForm : Form
   {
      public siparisForm()
      {
         InitializeComponent();
      }

      decimal tutar = 0, birimtutar = 0;

      private void siparisForm_Load(object sender, EventArgs e)
      {

         comboBox_bayi.Items.AddRange(do_login.SelectAll(1).ToArray());
         comboBox_bayi.SelectedIndex = 0;

         if (listBox_satistakiurunler.Items.Count > 0)
         listBox_satistakiurunler.SelectedIndex = 0;

         comboBox_hamur.SelectedIndex = 0;
         comboBox_Icecek.SelectedIndex = 0;
      }

      private void comboBox_bayi_SelectedIndexChanged(object sender, EventArgs e)
      {
         listBox_satistakiurunler.Items.Clear();
         listBox_satistakiurunler.Items.AddRange(do_products.BayiProductsSelectById(comboBox_bayi.SelectedItem as login).ToArray());
         
      }

      private void listBox_satistakiurunler_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listBox_satistakiurunler.SelectedIndex == -1) return;
         tutar = 0;

         products secilen = listBox_satistakiurunler.SelectedItem as products;
         label_urunaciklamasi.Text = secilen.Desc;

         

         string yazMalzeme = string.Join(", ", do_materials.MultiSelect(secilen.Materials));

         label_malzemeleri.Text = yazMalzeme;

         tutar += Convert.ToDecimal(secilen.Price);
         birimtutar = Convert.ToDecimal(secilen.Price);
         pictureBox_urungorsel.Image = Image.FromFile("data/img/"+secilen.ImgPath);

         textBox_tutar.Text = tutar + " TL";
         
      }
      string boyut = "Küçük";
      private void button_siparisikaydet_Click(object sender, EventArgs e)
      {
         if (listBox_satistakiurunler.SelectedIndex == -1) return;
         
         
         login bayi = comboBox_bayi.SelectedItem as login;
         products secilen = listBox_satistakiurunler.SelectedItem as products;
         




         orders yazilacak = new orders();
         yazilacak.Id = secilen.Id;
         yazilacak.Icecek = comboBox_Icecek.SelectedItem.ToString();
         yazilacak.Fiyat = tutar;
         yazilacak.HamurTipi = comboBox_hamur.SelectedItem.ToString();
         yazilacak.Count = (int)numericUpDown_adet.Value;
         yazilacak.BayiId = Convert.ToInt32(bayi.Id);
         yazilacak.Boyut = boyut;
         yazilacak.Name = secilen.Name;
         yazilacak.Zaman = DateTime.Now;

         xmlOrders.SiparisYaz(yazilacak);

         MessageBox.Show("Siparişiniz İletilmiştir.", "CF");
      }

      private void boyut_checkedchanged(object sender, EventArgs e)
      {
         RadioButton radiobtn = sender as RadioButton;
         if (radiobtn != null)
         {
            switch (radiobtn.Name)
            {
               case "radioButton_buyuk": boyut = "Büyük"; break;
               case "radioButton_orta": boyut = "Orta"; break;
               case "radioButton_kucuk": boyut = "Küçük"; break;
            }
         }
      }

      private void numericUpDown_adet_ValueChanged(object sender, EventArgs e)
      {
         tutar = birimtutar * numericUpDown_adet.Value;
         textBox_tutar.Text = tutar+" TL";
      }
   }
}
