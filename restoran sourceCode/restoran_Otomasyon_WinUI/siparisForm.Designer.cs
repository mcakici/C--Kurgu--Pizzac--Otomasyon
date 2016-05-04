namespace restoran_Otomasyon_WinUI
{
   partial class siparisForm
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
         this.pictureBox_urungorsel = new System.Windows.Forms.PictureBox();
         this.button_siparisikaydet = new System.Windows.Forms.Button();
         this.numericUpDown_adet = new System.Windows.Forms.NumericUpDown();
         this.comboBox_bayi = new System.Windows.Forms.ComboBox();
         this.label_urunaciklamasi = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.radioButton_kucuk = new System.Windows.Forms.RadioButton();
         this.radioButton_orta = new System.Windows.Forms.RadioButton();
         this.radioButton_buyuk = new System.Windows.Forms.RadioButton();
         this.comboBox_Icecek = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.listBox_satistakiurunler = new System.Windows.Forms.ListBox();
         this.label4 = new System.Windows.Forms.Label();
         this.comboBox_hamur = new System.Windows.Forms.ComboBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox_tutar = new System.Windows.Forms.TextBox();
         this.label_malzemeleri = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox_urungorsel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_adet)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox_urungorsel
         // 
         this.pictureBox_urungorsel.BackColor = System.Drawing.SystemColors.ControlLight;
         this.pictureBox_urungorsel.Location = new System.Drawing.Point(264, 32);
         this.pictureBox_urungorsel.Name = "pictureBox_urungorsel";
         this.pictureBox_urungorsel.Size = new System.Drawing.Size(189, 171);
         this.pictureBox_urungorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox_urungorsel.TabIndex = 0;
         this.pictureBox_urungorsel.TabStop = false;
         // 
         // button_siparisikaydet
         // 
         this.button_siparisikaydet.Location = new System.Drawing.Point(261, 312);
         this.button_siparisikaydet.Name = "button_siparisikaydet";
         this.button_siparisikaydet.Size = new System.Drawing.Size(189, 32);
         this.button_siparisikaydet.TabIndex = 1;
         this.button_siparisikaydet.Text = "Sipariş Et";
         this.button_siparisikaydet.UseVisualStyleBackColor = true;
         this.button_siparisikaydet.Click += new System.EventHandler(this.button_siparisikaydet_Click);
         // 
         // numericUpDown_adet
         // 
         this.numericUpDown_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.numericUpDown_adet.Location = new System.Drawing.Point(51, 321);
         this.numericUpDown_adet.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.numericUpDown_adet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.numericUpDown_adet.Name = "numericUpDown_adet";
         this.numericUpDown_adet.Size = new System.Drawing.Size(54, 22);
         this.numericUpDown_adet.TabIndex = 2;
         this.numericUpDown_adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.numericUpDown_adet.ValueChanged += new System.EventHandler(this.numericUpDown_adet_ValueChanged);
         // 
         // comboBox_bayi
         // 
         this.comboBox_bayi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox_bayi.FormattingEnabled = true;
         this.comboBox_bayi.Location = new System.Drawing.Point(61, 9);
         this.comboBox_bayi.Name = "comboBox_bayi";
         this.comboBox_bayi.Size = new System.Drawing.Size(194, 21);
         this.comboBox_bayi.TabIndex = 3;
         this.comboBox_bayi.SelectedIndexChanged += new System.EventHandler(this.comboBox_bayi_SelectedIndexChanged);
         // 
         // label_urunaciklamasi
         // 
         this.label_urunaciklamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_urunaciklamasi.Location = new System.Drawing.Point(261, 211);
         this.label_urunaciklamasi.Name = "label_urunaciklamasi";
         this.label_urunaciklamasi.Size = new System.Drawing.Size(189, 52);
         this.label_urunaciklamasi.TabIndex = 4;
         this.label_urunaciklamasi.Text = "label1";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.radioButton_buyuk);
         this.groupBox1.Controls.Add(this.radioButton_orta);
         this.groupBox1.Controls.Add(this.radioButton_kucuk);
         this.groupBox1.Location = new System.Drawing.Point(13, 269);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(242, 45);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Boyut";
         // 
         // radioButton_kucuk
         // 
         this.radioButton_kucuk.AutoSize = true;
         this.radioButton_kucuk.Checked = true;
         this.radioButton_kucuk.Location = new System.Drawing.Point(15, 19);
         this.radioButton_kucuk.Name = "radioButton_kucuk";
         this.radioButton_kucuk.Size = new System.Drawing.Size(56, 17);
         this.radioButton_kucuk.TabIndex = 0;
         this.radioButton_kucuk.TabStop = true;
         this.radioButton_kucuk.Text = "Küçük";
         this.radioButton_kucuk.UseVisualStyleBackColor = true;
         this.radioButton_kucuk.CheckedChanged += new System.EventHandler(this.boyut_checkedchanged);
         // 
         // radioButton_orta
         // 
         this.radioButton_orta.AutoSize = true;
         this.radioButton_orta.Location = new System.Drawing.Point(92, 19);
         this.radioButton_orta.Name = "radioButton_orta";
         this.radioButton_orta.Size = new System.Drawing.Size(45, 17);
         this.radioButton_orta.TabIndex = 0;
         this.radioButton_orta.Text = "Orta";
         this.radioButton_orta.UseVisualStyleBackColor = true;
         this.radioButton_orta.CheckedChanged += new System.EventHandler(this.boyut_checkedchanged);
         // 
         // radioButton_buyuk
         // 
         this.radioButton_buyuk.AutoSize = true;
         this.radioButton_buyuk.Location = new System.Drawing.Point(165, 19);
         this.radioButton_buyuk.Name = "radioButton_buyuk";
         this.radioButton_buyuk.Size = new System.Drawing.Size(55, 17);
         this.radioButton_buyuk.TabIndex = 0;
         this.radioButton_buyuk.Text = "Büyük";
         this.radioButton_buyuk.UseVisualStyleBackColor = true;
         this.radioButton_buyuk.CheckedChanged += new System.EventHandler(this.boyut_checkedchanged);
         // 
         // comboBox_Icecek
         // 
         this.comboBox_Icecek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox_Icecek.FormattingEnabled = true;
         this.comboBox_Icecek.Items.AddRange(new object[] {
            "Coca-Cola 330ml",
            "Fanta 330ml",
            "Sprite 330ml",
            "Lipton Icetea Şeftali 330ml",
            "Su 0,5lt",
            "Beypazarı Soda"});
         this.comboBox_Icecek.Location = new System.Drawing.Point(61, 242);
         this.comboBox_Icecek.Name = "comboBox_Icecek";
         this.comboBox_Icecek.Size = new System.Drawing.Size(194, 21);
         this.comboBox_Icecek.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 12);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(30, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Bayi:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 245);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(43, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "İçecek:";
         // 
         // listBox_satistakiurunler
         // 
         this.listBox_satistakiurunler.FormattingEnabled = true;
         this.listBox_satistakiurunler.Location = new System.Drawing.Point(15, 56);
         this.listBox_satistakiurunler.Name = "listBox_satistakiurunler";
         this.listBox_satistakiurunler.Size = new System.Drawing.Size(240, 147);
         this.listBox_satistakiurunler.TabIndex = 7;
         this.listBox_satistakiurunler.SelectedIndexChanged += new System.EventHandler(this.listBox_satistakiurunler_SelectedIndexChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 40);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(67, 13);
         this.label4.TabIndex = 6;
         this.label4.Text = "Ürün Seçimi:";
         // 
         // comboBox_hamur
         // 
         this.comboBox_hamur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox_hamur.FormattingEnabled = true;
         this.comboBox_hamur.Items.AddRange(new object[] {
            "İnce Hamur",
            "Normal Hamur",
            "Kepekli Hamur",
            "Kaşarlı Susamlı Hamur"});
         this.comboBox_hamur.Location = new System.Drawing.Point(61, 215);
         this.comboBox_hamur.Name = "comboBox_hamur";
         this.comboBox_hamur.Size = new System.Drawing.Size(194, 21);
         this.comboBox_hamur.TabIndex = 3;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 218);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(41, 13);
         this.label5.TabIndex = 6;
         this.label5.Text = "Hamur:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(13, 325);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(32, 13);
         this.label6.TabIndex = 6;
         this.label6.Text = "Adet:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(261, 12);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(68, 13);
         this.label7.TabIndex = 6;
         this.label7.Text = "Ürün Görseli:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(115, 325);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Tutar:";
         // 
         // textBox_tutar
         // 
         this.textBox_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.textBox_tutar.Location = new System.Drawing.Point(156, 320);
         this.textBox_tutar.Name = "textBox_tutar";
         this.textBox_tutar.ReadOnly = true;
         this.textBox_tutar.Size = new System.Drawing.Size(93, 22);
         this.textBox_tutar.TabIndex = 8;
         this.textBox_tutar.Text = "0,00 TL";
         // 
         // label_malzemeleri
         // 
         this.label_malzemeleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_malzemeleri.Location = new System.Drawing.Point(261, 269);
         this.label_malzemeleri.Name = "label_malzemeleri";
         this.label_malzemeleri.Size = new System.Drawing.Size(189, 40);
         this.label_malzemeleri.TabIndex = 4;
         this.label_malzemeleri.Text = "label1";
         // 
         // siparisForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(463, 351);
         this.Controls.Add(this.textBox_tutar);
         this.Controls.Add(this.listBox_satistakiurunler);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label_malzemeleri);
         this.Controls.Add(this.label_urunaciklamasi);
         this.Controls.Add(this.comboBox_hamur);
         this.Controls.Add(this.comboBox_Icecek);
         this.Controls.Add(this.comboBox_bayi);
         this.Controls.Add(this.numericUpDown_adet);
         this.Controls.Add(this.button_siparisikaydet);
         this.Controls.Add(this.pictureBox_urungorsel);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "siparisForm";
         this.Text = "Ürün Siparişi";
         this.Load += new System.EventHandler(this.siparisForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox_urungorsel)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_adet)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox_urungorsel;
      private System.Windows.Forms.Button button_siparisikaydet;
      private System.Windows.Forms.NumericUpDown numericUpDown_adet;
      private System.Windows.Forms.ComboBox comboBox_bayi;
      private System.Windows.Forms.Label label_urunaciklamasi;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton radioButton_buyuk;
      private System.Windows.Forms.RadioButton radioButton_orta;
      private System.Windows.Forms.RadioButton radioButton_kucuk;
      private System.Windows.Forms.ComboBox comboBox_Icecek;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ListBox listBox_satistakiurunler;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox comboBox_hamur;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox_tutar;
      private System.Windows.Forms.Label label_malzemeleri;
   }
}