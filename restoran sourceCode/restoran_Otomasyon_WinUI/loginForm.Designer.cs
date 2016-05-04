namespace restoran_Otomasyon_WinUI
{
   partial class loginForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
         this.button_girisyap = new System.Windows.Forms.Button();
         this.textBox_username = new System.Windows.Forms.TextBox();
         this.textBox_sifre = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.radioButton_musteri = new System.Windows.Forms.RadioButton();
         this.radioButton_bayi = new System.Windows.Forms.RadioButton();
         this.radioButton_sahip = new System.Windows.Forms.RadioButton();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // button_girisyap
         // 
         this.button_girisyap.Location = new System.Drawing.Point(262, 24);
         this.button_girisyap.Name = "button_girisyap";
         this.button_girisyap.Size = new System.Drawing.Size(83, 84);
         this.button_girisyap.TabIndex = 0;
         this.button_girisyap.Text = "Giriş Yap";
         this.button_girisyap.UseVisualStyleBackColor = true;
         this.button_girisyap.Click += new System.EventHandler(this.button_girisyap_Click);
         // 
         // textBox_username
         // 
         this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.textBox_username.Location = new System.Drawing.Point(12, 39);
         this.textBox_username.Name = "textBox_username";
         this.textBox_username.Size = new System.Drawing.Size(237, 22);
         this.textBox_username.TabIndex = 1;
         // 
         // textBox_sifre
         // 
         this.textBox_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.textBox_sifre.Location = new System.Drawing.Point(12, 80);
         this.textBox_sifre.Name = "textBox_sifre";
         this.textBox_sifre.Size = new System.Drawing.Size(237, 22);
         this.textBox_sifre.TabIndex = 2;
         this.textBox_sifre.UseSystemPasswordChar = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(9, 23);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(67, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Kullanıcı Adı:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(9, 64);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(31, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Şifre:";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.groupBox2);
         this.groupBox1.Controls.Add(this.button_girisyap);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.textBox_sifre);
         this.groupBox1.Controls.Add(this.textBox_username);
         this.groupBox1.Location = new System.Drawing.Point(12, 53);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(351, 167);
         this.groupBox1.TabIndex = 4;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Giriş Yapınız:";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.radioButton_musteri);
         this.groupBox2.Controls.Add(this.radioButton_bayi);
         this.groupBox2.Controls.Add(this.radioButton_sahip);
         this.groupBox2.Location = new System.Drawing.Point(12, 114);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(333, 47);
         this.groupBox2.TabIndex = 6;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Giriş Tipi";
         // 
         // radioButton_musteri
         // 
         this.radioButton_musteri.AutoSize = true;
         this.radioButton_musteri.Location = new System.Drawing.Point(220, 19);
         this.radioButton_musteri.Name = "radioButton_musteri";
         this.radioButton_musteri.Size = new System.Drawing.Size(59, 17);
         this.radioButton_musteri.TabIndex = 5;
         this.radioButton_musteri.Text = "Müşteri";
         this.radioButton_musteri.UseVisualStyleBackColor = true;
         this.radioButton_musteri.CheckedChanged += new System.EventHandler(this.oturumtipi_checkedchanged);
         // 
         // radioButton_bayi
         // 
         this.radioButton_bayi.AutoSize = true;
         this.radioButton_bayi.Location = new System.Drawing.Point(115, 19);
         this.radioButton_bayi.Name = "radioButton_bayi";
         this.radioButton_bayi.Size = new System.Drawing.Size(45, 17);
         this.radioButton_bayi.TabIndex = 5;
         this.radioButton_bayi.Tag = "2";
         this.radioButton_bayi.Text = "Bayi";
         this.radioButton_bayi.UseVisualStyleBackColor = true;
         this.radioButton_bayi.CheckedChanged += new System.EventHandler(this.oturumtipi_checkedchanged);
         // 
         // radioButton_sahip
         // 
         this.radioButton_sahip.AutoSize = true;
         this.radioButton_sahip.Checked = true;
         this.radioButton_sahip.Location = new System.Drawing.Point(12, 19);
         this.radioButton_sahip.Name = "radioButton_sahip";
         this.radioButton_sahip.Size = new System.Drawing.Size(52, 17);
         this.radioButton_sahip.TabIndex = 5;
         this.radioButton_sahip.TabStop = true;
         this.radioButton_sahip.Text = "Sahip";
         this.radioButton_sahip.UseVisualStyleBackColor = true;
         this.radioButton_sahip.CheckedChanged += new System.EventHandler(this.oturumtipi_checkedchanged);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 7);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(351, 40);
         this.pictureBox1.TabIndex = 5;
         this.pictureBox1.TabStop = false;
         // 
         // loginForm
         // 
         this.AcceptButton = this.button_girisyap;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(376, 236);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "loginForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Otomosyon Sistemi Giriş Ekranı";
         this.Load += new System.EventHandler(this.login_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button_girisyap;
      private System.Windows.Forms.TextBox textBox_username;
      private System.Windows.Forms.TextBox textBox_sifre;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.RadioButton radioButton_musteri;
      private System.Windows.Forms.RadioButton radioButton_bayi;
      private System.Windows.Forms.RadioButton radioButton_sahip;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}