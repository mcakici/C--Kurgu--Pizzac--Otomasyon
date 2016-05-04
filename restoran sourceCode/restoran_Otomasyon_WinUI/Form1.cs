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
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      public static int loginstatus = 0, logintype = 0, loginid = 0;

      private void Form1_Load(object sender, EventArgs e)
      {
         label_date.Text = DateTime.Today.ToLongDateString();

         loginForm loginForm = new loginForm();
         loginForm.StartPosition = FormStartPosition.CenterScreen;
         loginForm.ShowDialog();

         switch (logintype)
         {
            case 1: panel_admin.Enabled = true; label_oturumtipi.Text = "Administrator"; break;
            case 2: panel_admin.Enabled = true; label_oturumtipi.Text = "Bayi"; break;
            case 3: panel_admin.Enabled = true; label_oturumtipi.Text = "Müşteri"; break;
            default: panel_admin.Enabled = false; label_oturumtipi.Text = "İşsiz"; break;
         }

         if (logintype == 1)
         {
            ToolStripMenuItem tsmi1 = new ToolStripMenuItem();
            tsmi1.Name = "_kapat";
            tsmi1.Text = "Kapat";
            tsmi1.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi1);

            ToolStripMenuItem tsmi2 = new ToolStripMenuItem();
            tsmi2.Name = "_bayi";
            tsmi2.Text = "Hesap Düzenle/Ekle";
            tsmi2.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi2);

            ToolStripMenuItem tsmi3 = new ToolStripMenuItem();
            tsmi3.Name = "_urun";
            tsmi3.Text = "Ürün Düzenle/Ekle";
            tsmi3.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi3);

            ToolStripMenuItem tsmi4 = new ToolStripMenuItem();
            tsmi4.Name = "_siparis";
            tsmi4.Text = "Ürün Siparişi";
            tsmi4.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi4);

            ToolStripMenuItem tsmi5 = new ToolStripMenuItem();
            tsmi5.Name = "_bayiurun";
            tsmi5.Text = "Bayi Ürünleri";
            tsmi5.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi5);

            ToolStripMenuItem tsmi6 = new ToolStripMenuItem();
            tsmi6.Name = "_bekleyensiparis";
            tsmi6.Text = "Bekleyen Siparişler";
            tsmi6.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi6);
         }
         else if (logintype == 2)
         {
            ToolStripMenuItem tsmi1 = new ToolStripMenuItem();
            tsmi1.Name = "_kapat";
            tsmi1.Text = "Kapat";
            tsmi1.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi1);


            ToolStripMenuItem tsmi4 = new ToolStripMenuItem();
            tsmi4.Name = "_siparis";
            tsmi4.Text = "Ürün Siparişi";
            tsmi4.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi4);

            ToolStripMenuItem tsmi5 = new ToolStripMenuItem();
            tsmi5.Name = "_bayiurun";
            tsmi5.Text = "Bayi Ürünleri";
            tsmi5.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi5);

            ToolStripMenuItem tsmi6 = new ToolStripMenuItem();
            tsmi6.Name = "_bekleyensiparis";
            tsmi6.Text = "Bekleyen Siparişler";
            tsmi6.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi6);
         }
         else if (logintype == 3)
         {
            ToolStripMenuItem tsmi1 = new ToolStripMenuItem();
            tsmi1.Name = "_kapat";
            tsmi1.Text = "Kapat";
            tsmi1.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi1);


            ToolStripMenuItem tsmi4 = new ToolStripMenuItem();
            tsmi4.Name = "_siparis";
            tsmi4.Text = "Ürün Siparişi";
            tsmi4.Click += new EventHandler(tsmi_Click);
            menuStrip1.Items.Add(tsmi4);

 
         }

         if (loginstatus == 0)
         {
            panel_admin.Enabled = false; Application.Exit();
         }

      }

      void tsmi_Click(object sender, EventArgs e)
      {
         ToolStripMenuItem tiklanan = (ToolStripMenuItem)sender;

         if (tiklanan.Name == "_bayi")
         {
            accounts frm = new accounts();
            frm.MdiParent = this;
            frm.Show();
         }
         else if (tiklanan.Name == "_urun")
         {
            yeniurun frm = new yeniurun();
            frm.MdiParent = this;
            frm.Show();
         }
         else if (tiklanan.Name == "_siparis")
         {
            siparisForm frm = new siparisForm();
            frm.MdiParent = this;
            frm.Show();
         }
         else if (tiklanan.Name == "_bayiurun")
         {
            bayiurunForm frm = new bayiurunForm();
            frm.MdiParent = this;
            frm.Show();
         }
         else if (tiklanan.Name == "_bekleyensiparis")
         {
            bekleyensiparisForm frm = new bekleyensiparisForm();
            frm.MdiParent = this;
            frm.Show();
         }
         else if (tiklanan.Name == "_kapat")
         {
            Application.Exit();
         }
      }





   }
}
