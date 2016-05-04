namespace restoran_Otomasyon_WinUI
{
   partial class bekleyensiparisForm
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
         this.label2 = new System.Windows.Forms.Label();
         this.comboBox_bayi = new System.Windows.Forms.ComboBox();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.button_onayla = new System.Windows.Forms.Button();
         this.button_sil = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label12 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label_boyut = new System.Windows.Forms.Label();
         this.label_hamur = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label_icecek = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label_tarih = new System.Windows.Forms.Label();
         this.label_adet = new System.Windows.Forms.Label();
         this.label_siparisadi = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label_tutar = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 15);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(30, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "Bayi:";
         // 
         // comboBox_bayi
         // 
         this.comboBox_bayi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox_bayi.FormattingEnabled = true;
         this.comboBox_bayi.Location = new System.Drawing.Point(48, 12);
         this.comboBox_bayi.Name = "comboBox_bayi";
         this.comboBox_bayi.Size = new System.Drawing.Size(194, 21);
         this.comboBox_bayi.TabIndex = 7;
         this.comboBox_bayi.SelectedIndexChanged += new System.EventHandler(this.comboBox_bayi_SelectedIndexChanged);
         // 
         // listBox1
         // 
         this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.listBox1.FormattingEnabled = true;
         this.listBox1.ItemHeight = 15;
         this.listBox1.Location = new System.Drawing.Point(12, 43);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(175, 244);
         this.listBox1.TabIndex = 9;
         this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
         // 
         // button_onayla
         // 
         this.button_onayla.Location = new System.Drawing.Point(6, 202);
         this.button_onayla.Name = "button_onayla";
         this.button_onayla.Size = new System.Drawing.Size(115, 40);
         this.button_onayla.TabIndex = 10;
         this.button_onayla.Text = "Siparişi Onayla";
         this.button_onayla.UseVisualStyleBackColor = true;
         this.button_onayla.Click += new System.EventHandler(this.button_onayla_Click);
         // 
         // button_sil
         // 
         this.button_sil.Location = new System.Drawing.Point(128, 202);
         this.button_sil.Name = "button_sil";
         this.button_sil.Size = new System.Drawing.Size(112, 40);
         this.button_sil.TabIndex = 10;
         this.button_sil.Text = "Siparişi İptal Et";
         this.button_sil.UseVisualStyleBackColor = true;
         this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label8);
         this.groupBox1.Controls.Add(this.label12);
         this.groupBox1.Controls.Add(this.label6);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label_tutar);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label_boyut);
         this.groupBox1.Controls.Add(this.label_hamur);
         this.groupBox1.Controls.Add(this.label11);
         this.groupBox1.Controls.Add(this.label_icecek);
         this.groupBox1.Controls.Add(this.label10);
         this.groupBox1.Controls.Add(this.label_tarih);
         this.groupBox1.Controls.Add(this.label_adet);
         this.groupBox1.Controls.Add(this.label_siparisadi);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.button_onayla);
         this.groupBox1.Controls.Add(this.button_sil);
         this.groupBox1.Location = new System.Drawing.Point(193, 39);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(246, 248);
         this.groupBox1.TabIndex = 11;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Sipariş Ayrıntıları";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(21, 150);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(37, 13);
         this.label12.TabIndex = 11;
         this.label12.Text = "Boyut:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(21, 127);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(41, 13);
         this.label6.TabIndex = 11;
         this.label6.Text = "Hamur:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(21, 104);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(43, 13);
         this.label5.TabIndex = 11;
         this.label5.Text = "İçecek:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(21, 82);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(34, 13);
         this.label4.TabIndex = 11;
         this.label4.Text = "Tarih:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(21, 58);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(32, 13);
         this.label3.TabIndex = 11;
         this.label3.Text = "Adet:";
         // 
         // label_boyut
         // 
         this.label_boyut.AutoSize = true;
         this.label_boyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_boyut.Location = new System.Drawing.Point(68, 150);
         this.label_boyut.Name = "label_boyut";
         this.label_boyut.Size = new System.Drawing.Size(11, 16);
         this.label_boyut.TabIndex = 11;
         this.label_boyut.Text = ".";
         // 
         // label_hamur
         // 
         this.label_hamur.AutoSize = true;
         this.label_hamur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_hamur.Location = new System.Drawing.Point(68, 127);
         this.label_hamur.Name = "label_hamur";
         this.label_hamur.Size = new System.Drawing.Size(11, 16);
         this.label_hamur.TabIndex = 11;
         this.label_hamur.Text = ".";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label11.Location = new System.Drawing.Point(68, 127);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(11, 16);
         this.label11.TabIndex = 11;
         this.label11.Text = ".";
         // 
         // label_icecek
         // 
         this.label_icecek.AutoSize = true;
         this.label_icecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_icecek.Location = new System.Drawing.Point(68, 104);
         this.label_icecek.Name = "label_icecek";
         this.label_icecek.Size = new System.Drawing.Size(11, 16);
         this.label_icecek.TabIndex = 11;
         this.label_icecek.Text = ".";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label10.Location = new System.Drawing.Point(68, 104);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(11, 16);
         this.label10.TabIndex = 11;
         this.label10.Text = ".";
         // 
         // label_tarih
         // 
         this.label_tarih.AutoSize = true;
         this.label_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_tarih.Location = new System.Drawing.Point(68, 82);
         this.label_tarih.Name = "label_tarih";
         this.label_tarih.Size = new System.Drawing.Size(11, 16);
         this.label_tarih.TabIndex = 11;
         this.label_tarih.Text = ".";
         // 
         // label_adet
         // 
         this.label_adet.AutoSize = true;
         this.label_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_adet.Location = new System.Drawing.Point(68, 58);
         this.label_adet.Name = "label_adet";
         this.label_adet.Size = new System.Drawing.Size(11, 16);
         this.label_adet.TabIndex = 11;
         this.label_adet.Text = ".";
         // 
         // label_siparisadi
         // 
         this.label_siparisadi.AutoSize = true;
         this.label_siparisadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_siparisadi.Location = new System.Drawing.Point(68, 34);
         this.label_siparisadi.Name = "label_siparisadi";
         this.label_siparisadi.Size = new System.Drawing.Size(11, 16);
         this.label_siparisadi.TabIndex = 11;
         this.label_siparisadi.Text = ".";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(21, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(41, 13);
         this.label1.TabIndex = 11;
         this.label1.Text = "Sipariş:";
         // 
         // label_tutar
         // 
         this.label_tutar.AutoSize = true;
         this.label_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_tutar.Location = new System.Drawing.Point(68, 174);
         this.label_tutar.Name = "label_tutar";
         this.label_tutar.Size = new System.Drawing.Size(11, 16);
         this.label_tutar.TabIndex = 11;
         this.label_tutar.Text = ".";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(21, 174);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(35, 13);
         this.label8.TabIndex = 11;
         this.label8.Text = "Tutar:";
         // 
         // bekleyensiparisForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(452, 293);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.listBox1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.comboBox_bayi);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "bekleyensiparisForm";
         this.Text = "Bekleyen Siparişler";
         this.Load += new System.EventHandler(this.bekleyensiparisForm_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox comboBox_bayi;
      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.Button button_onayla;
      private System.Windows.Forms.Button button_sil;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label_tarih;
      private System.Windows.Forms.Label label_adet;
      private System.Windows.Forms.Label label_siparisadi;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label_boyut;
      private System.Windows.Forms.Label label_hamur;
      private System.Windows.Forms.Label label_icecek;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label_tutar;
   }
}