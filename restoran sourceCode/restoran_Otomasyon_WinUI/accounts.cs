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
    public partial class accounts : Form
    {
        public accounts()
        {
            InitializeComponent();
        }
        bool status = true;
        int kullanicitipi = 2;
        private void button_bayiekle_Click(object sender, EventArgs e)
        {
           if (textBox_userid.Text != string.Empty)
           {
              if (textBox_isim.Text.Length <= 0 || textBox_soyad.Text.Length <= 0 || textBox_adres.Text.Length <= 0 || textBox_kullaniciadi.Text.Length <= 0 || textBox_tel.Text.Length <= 0) return;
              login guncelle = new login();
              guncelle.Id = textBox_userid.Text;
              guncelle.Firstname = textBox_isim.Text;
              guncelle.Lastname = textBox_soyad.Text;
              guncelle.Phone = textBox_tel.Text;
              guncelle.Address = textBox_adres.Text;
              guncelle.Status = status;
              guncelle.Username = textBox_kullaniciadi.Text;
              guncelle.Type = kullanicitipi;
              do_login.Update(guncelle);

              listBox_mevcuthesaplar.Items.Clear();
              listBox_mevcuthesaplar.Items.AddRange(do_login.SelectAll().ToArray());

           }
           else
           {

              if (textBox_isim.Text.Length <= 0 || textBox_soyad.Text.Length <= 0 || textBox_adres.Text.Length <= 0 || textBox_kullaniciadi.Text.Length <= 0 || textBox_tel.Text.Length <= 0 || textBox_password.Text.Length <= 0) return;
              login eklenecek = new login();
              eklenecek.Firstname = textBox_isim.Text;
              eklenecek.Lastname = textBox_soyad.Text;
              eklenecek.Phone = textBox_tel.Text;
              eklenecek.Address = textBox_adres.Text;
              eklenecek.Status = status;
              eklenecek.Username = textBox_kullaniciadi.Text;
              eklenecek.Password = textBox_password.Text;
              eklenecek.Type = kullanicitipi;
              do_login.Insert(eklenecek);

              listBox_mevcuthesaplar.Items.Clear();
              listBox_mevcuthesaplar.Items.AddRange(do_login.SelectAll().ToArray());

           }
        }

        private void yenibayi_Load(object sender, EventArgs e)
        {
           listBox_mevcuthesaplar.Items.AddRange(do_login.SelectAll().ToArray());
        }

        private void aktifpasif_checkedchanged(object sender, EventArgs e)
        {
           RadioButton radiobtn = sender as RadioButton;
           if (radiobtn != null)
           {
              switch (radiobtn.Name)
              {
                 case "radioButton_aktif": status = true; break;
                 case "radioButton_pasif": status = false; break;
              }
           }
        }

        private void kullanicitipi_checkedchanged(object sender, EventArgs e)
        {
           RadioButton radiobtn = sender as RadioButton;
           if (radiobtn != null)
           {
              switch (radiobtn.Name)
              {
                 case "radioButton_admin": kullanicitipi = 1; break;
                 case "radioButton_bayi": kullanicitipi = 2; break;
                 case "radioButton_musteri": kullanicitipi = 3; break;
              }
           }
        }

        private void listBox_mevcuthesaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (listBox_mevcuthesaplar.SelectedIndex == -1) return;

           login secilen = listBox_mevcuthesaplar.SelectedItem as login;
           textBox_isim.Text = secilen.Firstname.ToString();
           textBox_soyad.Text = secilen.Lastname.ToString();
           textBox_kullaniciadi.Text = secilen.Username.ToString();
           textBox_password.Text = secilen.Password.ToString();
           textBox_password.Enabled = false;
           textBox_tel.Text = secilen.Phone.ToString();
           textBox_adres.Text = secilen.Address.ToString();
           textBox_userid.Text = secilen.Id.ToString();
           kullanicitipi = secilen.Type;
           status = secilen.Status;

           radioButton_aktif.Checked = false;
           radioButton_pasif.Checked = false;
           radioButton_admin.Checked = false;
           radioButton_bayi.Checked = false;
           radioButton_musteri.Checked = false;

           switch (secilen.Status)
           {
              case true: radioButton_aktif.Checked = true; break;
              case false: radioButton_pasif.Checked = true; break;
           }

           switch (secilen.Type)
           {
              case 1: radioButton_admin.Checked = true; break;
              case 2: radioButton_bayi.Checked = true; break;
              case 3: radioButton_musteri.Checked = true; break;
           }





        }
    }
}
