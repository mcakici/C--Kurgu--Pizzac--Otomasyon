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
   public partial class bayiurunForm : Form
   {
      public bayiurunForm()
      {
         InitializeComponent();
      }

      private void bayiurunForm_Load(object sender, EventArgs e)
      {
         comboBox_bayi.Items.AddRange(do_login.SelectAll(1, Form1.logintype, Form1.loginid).ToArray());
         comboBox_bayi.SelectedIndex = 0;

      }

      private void listBox_mevcuturunler_SelectedIndexChanged(object sender, EventArgs e)
      {
         
      }

      private void comboBox_bayi_SelectedIndexChanged(object sender, EventArgs e)
      {

         bayiurunleriaktifpasif();



      }

      private void bayiurunleriaktifpasif()
      {
         checkedListBox_satistakiUrunler.Items.Clear();

         checkedListBox_satistakiUrunler.Items.AddRange(do_products.SelectAll().ToArray());



         var liste = do_products.SelectAll().ToArray();
         var secilenliste = do_products.BayiProductsSelectById(comboBox_bayi.SelectedItem as login);


         for (int p = 0; p < checkedListBox_satistakiUrunler.Items.Count; p++)
         {
            foreach (var item in secilenliste)
            {
               string deger = checkedListBox_satistakiUrunler.Items[p].ToString();
               if (deger == item.ToString())
                  checkedListBox_satistakiUrunler.SetItemCheckState(p, CheckState.Checked);
            }

         }
      }

      private void button1_Click(object sender, EventArgs e)
      {



         products[] allitems = checkedListBox_satistakiUrunler.Items.OfType<products>().ToArray();
         for (int i = 0; i < allitems.Length; i++)
         {
            products urun = allitems[i];
            urun.status = false;
            if (checkedListBox_satistakiUrunler.CheckedItems.Contains(urun))
                  urun.status = true;
            do_products.BayiProductsUpdate(urun, comboBox_bayi.SelectedItem as login);
         }
         

      }
   }
}
