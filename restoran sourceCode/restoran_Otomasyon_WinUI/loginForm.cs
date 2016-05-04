using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using restoran_Otomasyon_Commander;
using restoran_Otomasyon_Soldier;

namespace restoran_Otomasyon_WinUI
{

    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            Form1.logintype = 1; // default admin;
        }

        private void button_girisyap_Click(object sender, EventArgs e)
        {
            if (textBox_username.TextLength <= 0 || textBox_sifre.TextLength <= 0) return;
            string md5sifresi = tools.MD5Sifrele(textBox_sifre.Text);

            if (do_login.SelectByUsername(textBox_username.Text, textBox_sifre.Text, Form1.logintype) > 0)
            {
               Form1.loginid = do_login.SelectByUsername(textBox_username.Text, textBox_sifre.Text, Form1.logintype);
               Form1.loginstatus = 1;
               this.Visible = false;
            }
            else
            {
               MessageBox.Show("Hatalı bir giriş denemesinde bulundunuz!\n\nBu uyarıyı sıkça görüyorsanız teknik destek ile iletişime geçiniz.", "Hatalı Giriş");
            }
            

            
        }

        private void oturumtipi_checkedchanged(object sender, EventArgs e)
        {
            RadioButton radiobtn = sender as RadioButton;
            if (radiobtn != null)
            {
                switch (radiobtn.Name)
                {
                    case "radioButton_sahip": Form1.logintype = 1; break;
                    case "radioButton_bayi": Form1.logintype = 2; break;
                    case "radioButton_musteri": Form1.logintype = 3; break;
                    case "radioButton_issiz": Form1.logintype = 4; break;
                }
            }
        }


    }
}
