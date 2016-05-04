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
   public partial class bekleyensiparisForm : Form
   {
      public bekleyensiparisForm()
      {
         InitializeComponent();
      }

      private void bekleyensiparisForm_Load(object sender, EventArgs e)
      {
         comboBox_bayi.Items.AddRange(do_login.SelectAll(1, Form1.logintype, Form1.loginid).ToArray());
         comboBox_bayi.SelectedIndex = 0;
      }

      private void comboBox_bayi_SelectedIndexChanged(object sender, EventArgs e)
      {
         listBox1.Items.Clear();
         listBox1.Items.AddRange(xmlOrders.ReadXML(comboBox_bayi.SelectedItem as login).ToArray());
      }


      private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listBox1.SelectedIndex == -1) return;

         orders secilen = listBox1.SelectedItem as orders;
         label_icecek.Text = secilen.Icecek;
         label_hamur.Text = secilen.HamurTipi;
         label_boyut.Text = secilen.Boyut;
         label_adet.Text = secilen.Count.ToString();
         label_siparisadi.Text = secilen.Name;
         label_tarih.Text = secilen.Zaman.ToString();
         label_tutar.Text = secilen.Fiyat + " TL";

      }

      private void button_sil_Click(object sender, EventArgs e)
      {
         if (listBox1.SelectedIndex == -1) return;
         orders secilen = listBox1.SelectedItem as orders;
         xmlOrders.DeleteXMLNode(secilen);


         listBox1.Items.Clear();
         listBox1.Items.AddRange(xmlOrders.ReadXML(comboBox_bayi.SelectedItem as login).ToArray());
      }

      private void button_onayla_Click(object sender, EventArgs e)
      {
         if (listBox1.SelectedIndex == -1) return;
         
         orders secilen = listBox1.SelectedItem as orders;
         xmlOrders.Insert(secilen, Form1.loginid);
         xmlOrders.DeleteXMLNode(secilen);


         listBox1.Items.Clear();
         listBox1.Items.AddRange(xmlOrders.ReadXML(comboBox_bayi.SelectedItem as login).ToArray());
      }


   }
}
