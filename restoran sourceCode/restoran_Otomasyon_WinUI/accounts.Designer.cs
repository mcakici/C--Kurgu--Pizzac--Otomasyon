namespace restoran_Otomasyon_WinUI
{
    partial class accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           this.button_bayiekle = new System.Windows.Forms.Button();
           this.label1 = new System.Windows.Forms.Label();
           this.textBox_kullaniciadi = new System.Windows.Forms.TextBox();
           this.label2 = new System.Windows.Forms.Label();
           this.textBox_password = new System.Windows.Forms.TextBox();
           this.label3 = new System.Windows.Forms.Label();
           this.textBox_adres = new System.Windows.Forms.TextBox();
           this.label4 = new System.Windows.Forms.Label();
           this.textBox_tel = new System.Windows.Forms.TextBox();
           this.label_isimsoyad = new System.Windows.Forms.Label();
           this.textBox_isim = new System.Windows.Forms.TextBox();
           this.groupBox1 = new System.Windows.Forms.GroupBox();
           this.radioButton_aktif = new System.Windows.Forms.RadioButton();
           this.radioButton_pasif = new System.Windows.Forms.RadioButton();
           this.label7 = new System.Windows.Forms.Label();
           this.label6 = new System.Windows.Forms.Label();
           this.listBox_mevcuthesaplar = new System.Windows.Forms.ListBox();
           this.label5 = new System.Windows.Forms.Label();
           this.textBox_soyad = new System.Windows.Forms.TextBox();
           this.label8 = new System.Windows.Forms.Label();
           this.groupBox2 = new System.Windows.Forms.GroupBox();
           this.radioButton_admin = new System.Windows.Forms.RadioButton();
           this.radioButton_bayi = new System.Windows.Forms.RadioButton();
           this.radioButton_musteri = new System.Windows.Forms.RadioButton();
           this.textBox_userid = new System.Windows.Forms.TextBox();
           this.groupBox1.SuspendLayout();
           this.groupBox2.SuspendLayout();
           this.SuspendLayout();
           // 
           // button_bayiekle
           // 
           this.button_bayiekle.Location = new System.Drawing.Point(15, 204);
           this.button_bayiekle.Name = "button_bayiekle";
           this.button_bayiekle.Size = new System.Drawing.Size(419, 28);
           this.button_bayiekle.TabIndex = 12;
           this.button_bayiekle.Text = "Hesap Ekle/Düzenle";
           this.button_bayiekle.UseVisualStyleBackColor = true;
           this.button_bayiekle.Click += new System.EventHandler(this.button_bayiekle_Click);
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(12, 26);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(67, 13);
           this.label1.TabIndex = 1;
           this.label1.Text = "Kullanıcı Adı:";
           // 
           // textBox_kullaniciadi
           // 
           this.textBox_kullaniciadi.Location = new System.Drawing.Point(15, 42);
           this.textBox_kullaniciadi.Name = "textBox_kullaniciadi";
           this.textBox_kullaniciadi.Size = new System.Drawing.Size(185, 20);
           this.textBox_kullaniciadi.TabIndex = 5;
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(12, 68);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(31, 13);
           this.label2.TabIndex = 1;
           this.label2.Text = "Şifre:";
           // 
           // textBox_password
           // 
           this.textBox_password.Location = new System.Drawing.Point(15, 84);
           this.textBox_password.Name = "textBox_password";
           this.textBox_password.Size = new System.Drawing.Size(185, 20);
           this.textBox_password.TabIndex = 6;
           this.textBox_password.UseSystemPasswordChar = true;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(12, 101);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(37, 13);
           this.label3.TabIndex = 1;
           this.label3.Text = "Adres:";
           // 
           // textBox_adres
           // 
           this.textBox_adres.Location = new System.Drawing.Point(15, 116);
           this.textBox_adres.Multiline = true;
           this.textBox_adres.Name = "textBox_adres";
           this.textBox_adres.Size = new System.Drawing.Size(185, 30);
           this.textBox_adres.TabIndex = 3;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Location = new System.Drawing.Point(12, 156);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(46, 13);
           this.label4.TabIndex = 1;
           this.label4.Text = "Telefon:";
           // 
           // textBox_tel
           // 
           this.textBox_tel.Location = new System.Drawing.Point(15, 172);
           this.textBox_tel.Name = "textBox_tel";
           this.textBox_tel.Size = new System.Drawing.Size(185, 20);
           this.textBox_tel.TabIndex = 4;
           // 
           // label_isimsoyad
           // 
           this.label_isimsoyad.AutoSize = true;
           this.label_isimsoyad.Location = new System.Drawing.Point(12, 15);
           this.label_isimsoyad.Name = "label_isimsoyad";
           this.label_isimsoyad.Size = new System.Drawing.Size(28, 13);
           this.label_isimsoyad.TabIndex = 1;
           this.label_isimsoyad.Text = "İsim:";
           // 
           // textBox_isim
           // 
           this.textBox_isim.Location = new System.Drawing.Point(15, 31);
           this.textBox_isim.Name = "textBox_isim";
           this.textBox_isim.Size = new System.Drawing.Size(185, 20);
           this.textBox_isim.TabIndex = 1;
           // 
           // groupBox1
           // 
           this.groupBox1.Controls.Add(this.groupBox2);
           this.groupBox1.Controls.Add(this.radioButton_aktif);
           this.groupBox1.Controls.Add(this.radioButton_pasif);
           this.groupBox1.Controls.Add(this.textBox_password);
           this.groupBox1.Controls.Add(this.label1);
           this.groupBox1.Controls.Add(this.textBox_kullaniciadi);
           this.groupBox1.Controls.Add(this.label7);
           this.groupBox1.Controls.Add(this.label6);
           this.groupBox1.Controls.Add(this.label2);
           this.groupBox1.Location = new System.Drawing.Point(218, 11);
           this.groupBox1.Name = "groupBox1";
           this.groupBox1.Size = new System.Drawing.Size(216, 181);
           this.groupBox1.TabIndex = 4;
           this.groupBox1.TabStop = false;
           this.groupBox1.Text = "Sisteme Giriş Bilgileri";
           // 
           // radioButton_aktif
           // 
           this.radioButton_aktif.AutoSize = true;
           this.radioButton_aktif.Checked = true;
           this.radioButton_aktif.Location = new System.Drawing.Point(63, 157);
           this.radioButton_aktif.Name = "radioButton_aktif";
           this.radioButton_aktif.Size = new System.Drawing.Size(46, 17);
           this.radioButton_aktif.TabIndex = 10;
           this.radioButton_aktif.TabStop = true;
           this.radioButton_aktif.Text = "Aktif";
           this.radioButton_aktif.UseVisualStyleBackColor = true;
           this.radioButton_aktif.CheckedChanged += new System.EventHandler(this.aktifpasif_checkedchanged);
           // 
           // radioButton_pasif
           // 
           this.radioButton_pasif.AutoSize = true;
           this.radioButton_pasif.Location = new System.Drawing.Point(115, 157);
           this.radioButton_pasif.Name = "radioButton_pasif";
           this.radioButton_pasif.Size = new System.Drawing.Size(48, 17);
           this.radioButton_pasif.TabIndex = 11;
           this.radioButton_pasif.Text = "Pasif";
           this.radioButton_pasif.UseVisualStyleBackColor = true;
           this.radioButton_pasif.CheckedChanged += new System.EventHandler(this.aktifpasif_checkedchanged);
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(12, 159);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(41, 13);
           this.label7.TabIndex = 0;
           this.label7.Text = "Durum:";
           // 
           // label6
           // 
           this.label6.AutoSize = true;
           this.label6.Location = new System.Drawing.Point(12, 111);
           this.label6.Name = "label6";
           this.label6.Size = new System.Drawing.Size(69, 13);
           this.label6.TabIndex = 1;
           this.label6.Text = "Kullanıcı Tipi:";
           // 
           // listBox_mevcuthesaplar
           // 
           this.listBox_mevcuthesaplar.FormattingEnabled = true;
           this.listBox_mevcuthesaplar.Location = new System.Drawing.Point(450, 27);
           this.listBox_mevcuthesaplar.Name = "listBox_mevcuthesaplar";
           this.listBox_mevcuthesaplar.Size = new System.Drawing.Size(165, 199);
           this.listBox_mevcuthesaplar.TabIndex = 0;
           this.listBox_mevcuthesaplar.SelectedIndexChanged += new System.EventHandler(this.listBox_mevcuthesaplar_SelectedIndexChanged);
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Location = new System.Drawing.Point(12, 56);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(40, 13);
           this.label5.TabIndex = 1;
           this.label5.Text = "Soyad:";
           // 
           // textBox_soyad
           // 
           this.textBox_soyad.Location = new System.Drawing.Point(15, 72);
           this.textBox_soyad.Name = "textBox_soyad";
           this.textBox_soyad.Size = new System.Drawing.Size(185, 20);
           this.textBox_soyad.TabIndex = 2;
           // 
           // label8
           // 
           this.label8.AutoSize = true;
           this.label8.Location = new System.Drawing.Point(449, 9);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(91, 13);
           this.label8.TabIndex = 0;
           this.label8.Text = "Mevcut Hesaplar:";
           // 
           // groupBox2
           // 
           this.groupBox2.Controls.Add(this.radioButton_musteri);
           this.groupBox2.Controls.Add(this.radioButton_bayi);
           this.groupBox2.Controls.Add(this.radioButton_admin);
           this.groupBox2.Location = new System.Drawing.Point(6, 105);
           this.groupBox2.Name = "groupBox2";
           this.groupBox2.Size = new System.Drawing.Size(194, 46);
           this.groupBox2.TabIndex = 0;
           this.groupBox2.TabStop = false;
           this.groupBox2.Text = "Kullanıcı Tipi";
           // 
           // radioButton_admin
           // 
           this.radioButton_admin.AutoSize = true;
           this.radioButton_admin.Location = new System.Drawing.Point(9, 19);
           this.radioButton_admin.Name = "radioButton_admin";
           this.radioButton_admin.Size = new System.Drawing.Size(54, 17);
           this.radioButton_admin.TabIndex = 7;
           this.radioButton_admin.Text = "Admin";
           this.radioButton_admin.UseVisualStyleBackColor = true;
           this.radioButton_admin.CheckedChanged += new System.EventHandler(this.kullanicitipi_checkedchanged);
           // 
           // radioButton_bayi
           // 
           this.radioButton_bayi.AutoSize = true;
           this.radioButton_bayi.Checked = true;
           this.radioButton_bayi.Location = new System.Drawing.Point(72, 19);
           this.radioButton_bayi.Name = "radioButton_bayi";
           this.radioButton_bayi.Size = new System.Drawing.Size(45, 17);
           this.radioButton_bayi.TabIndex = 8;
           this.radioButton_bayi.Text = "Bayi";
           this.radioButton_bayi.UseVisualStyleBackColor = true;
           this.radioButton_bayi.CheckedChanged += new System.EventHandler(this.kullanicitipi_checkedchanged);
           // 
           // radioButton_musteri
           // 
           this.radioButton_musteri.AutoSize = true;
           this.radioButton_musteri.Location = new System.Drawing.Point(129, 19);
           this.radioButton_musteri.Name = "radioButton_musteri";
           this.radioButton_musteri.Size = new System.Drawing.Size(59, 17);
           this.radioButton_musteri.TabIndex = 9;
           this.radioButton_musteri.Text = "Müşteri";
           this.radioButton_musteri.UseVisualStyleBackColor = true;
           this.radioButton_musteri.CheckedChanged += new System.EventHandler(this.kullanicitipi_checkedchanged);
           // 
           // textBox_userid
           // 
           this.textBox_userid.Enabled = false;
           this.textBox_userid.Location = new System.Drawing.Point(117, 5);
           this.textBox_userid.Name = "textBox_userid";
           this.textBox_userid.Size = new System.Drawing.Size(62, 20);
           this.textBox_userid.TabIndex = 0;
           // 
           // accounts
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(627, 243);
           this.Controls.Add(this.textBox_userid);
           this.Controls.Add(this.listBox_mevcuthesaplar);
           this.Controls.Add(this.groupBox1);
           this.Controls.Add(this.textBox_tel);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.textBox_soyad);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.textBox_isim);
           this.Controls.Add(this.label_isimsoyad);
           this.Controls.Add(this.textBox_adres);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.button_bayiekle);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
           this.Name = "accounts";
           this.Text = "Hesaplar";
           this.Load += new System.EventHandler(this.yenibayi_Load);
           this.groupBox1.ResumeLayout(false);
           this.groupBox1.PerformLayout();
           this.groupBox2.ResumeLayout(false);
           this.groupBox2.PerformLayout();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_bayiekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label_isimsoyad;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_mevcuthesaplar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.RadioButton radioButton_aktif;
        private System.Windows.Forms.RadioButton radioButton_pasif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_musteri;
        private System.Windows.Forms.RadioButton radioButton_bayi;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.TextBox textBox_userid;
    }
}