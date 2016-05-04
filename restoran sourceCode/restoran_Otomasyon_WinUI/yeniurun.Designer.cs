namespace restoran_Otomasyon_WinUI
{
    partial class yeniurun
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
           this.button_urunekle = new System.Windows.Forms.Button();
           this.textBox_urunadi = new System.Windows.Forms.TextBox();
           this.checkedListBox_malzemelist = new System.Windows.Forms.CheckedListBox();
           this.groupBox1 = new System.Windows.Forms.GroupBox();
           this.button_reset = new System.Windows.Forms.Button();
           this.groupBox2 = new System.Windows.Forms.GroupBox();
           this.textBox_yenimalzeme = new System.Windows.Forms.TextBox();
           this.label1 = new System.Windows.Forms.Label();
           this.button_malzemeekle = new System.Windows.Forms.Button();
           this.label5 = new System.Windows.Forms.Label();
           this.label6 = new System.Windows.Forms.Label();
           this.label7 = new System.Windows.Forms.Label();
           this.label4 = new System.Windows.Forms.Label();
           this.label3 = new System.Windows.Forms.Label();
           this.label2 = new System.Windows.Forms.Label();
           this.textBox_fiyat = new System.Windows.Forms.TextBox();
           this.textBox_resimyolu = new System.Windows.Forms.TextBox();
           this.textBox_urunaciklama = new System.Windows.Forms.TextBox();
           this.textBox_id = new System.Windows.Forms.TextBox();
           this.groupBox3 = new System.Windows.Forms.GroupBox();
           this.listBox_mevcuturunler = new System.Windows.Forms.ListBox();
           this.groupBox1.SuspendLayout();
           this.groupBox2.SuspendLayout();
           this.groupBox3.SuspendLayout();
           this.SuspendLayout();
           // 
           // button_urunekle
           // 
           this.button_urunekle.Location = new System.Drawing.Point(21, 253);
           this.button_urunekle.Name = "button_urunekle";
           this.button_urunekle.Size = new System.Drawing.Size(168, 35);
           this.button_urunekle.TabIndex = 0;
           this.button_urunekle.Text = "Ürünü Ekle";
           this.button_urunekle.UseVisualStyleBackColor = true;
           this.button_urunekle.Click += new System.EventHandler(this.button_urunekle_Click);
           // 
           // textBox_urunadi
           // 
           this.textBox_urunadi.Location = new System.Drawing.Point(21, 41);
           this.textBox_urunadi.Name = "textBox_urunadi";
           this.textBox_urunadi.Size = new System.Drawing.Size(168, 20);
           this.textBox_urunadi.TabIndex = 1;
           // 
           // checkedListBox_malzemelist
           // 
           this.checkedListBox_malzemelist.CheckOnClick = true;
           this.checkedListBox_malzemelist.FormattingEnabled = true;
           this.checkedListBox_malzemelist.Location = new System.Drawing.Point(225, 35);
           this.checkedListBox_malzemelist.Name = "checkedListBox_malzemelist";
           this.checkedListBox_malzemelist.Size = new System.Drawing.Size(189, 169);
           this.checkedListBox_malzemelist.TabIndex = 2;
           this.checkedListBox_malzemelist.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_malzemelist_SelectedIndexChanged);
           // 
           // groupBox1
           // 
           this.groupBox1.Controls.Add(this.button_reset);
           this.groupBox1.Controls.Add(this.groupBox2);
           this.groupBox1.Controls.Add(this.checkedListBox_malzemelist);
           this.groupBox1.Controls.Add(this.label5);
           this.groupBox1.Controls.Add(this.label6);
           this.groupBox1.Controls.Add(this.label7);
           this.groupBox1.Controls.Add(this.label4);
           this.groupBox1.Controls.Add(this.label3);
           this.groupBox1.Controls.Add(this.label2);
           this.groupBox1.Controls.Add(this.textBox_fiyat);
           this.groupBox1.Controls.Add(this.textBox_resimyolu);
           this.groupBox1.Controls.Add(this.textBox_urunaciklama);
           this.groupBox1.Controls.Add(this.textBox_id);
           this.groupBox1.Controls.Add(this.textBox_urunadi);
           this.groupBox1.Controls.Add(this.button_urunekle);
           this.groupBox1.Location = new System.Drawing.Point(12, 5);
           this.groupBox1.Name = "groupBox1";
           this.groupBox1.Size = new System.Drawing.Size(420, 297);
           this.groupBox1.TabIndex = 3;
           this.groupBox1.TabStop = false;
           this.groupBox1.Text = "Yeni Ürün Girişi";
           // 
           // button_reset
           // 
           this.button_reset.Location = new System.Drawing.Point(171, 12);
           this.button_reset.Name = "button_reset";
           this.button_reset.Size = new System.Drawing.Size(20, 21);
           this.button_reset.TabIndex = 0;
           this.button_reset.Text = "X";
           this.button_reset.UseVisualStyleBackColor = true;
           this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
           // 
           // groupBox2
           // 
           this.groupBox2.Controls.Add(this.textBox_yenimalzeme);
           this.groupBox2.Controls.Add(this.label1);
           this.groupBox2.Controls.Add(this.button_malzemeekle);
           this.groupBox2.Location = new System.Drawing.Point(225, 210);
           this.groupBox2.Name = "groupBox2";
           this.groupBox2.Size = new System.Drawing.Size(189, 78);
           this.groupBox2.TabIndex = 5;
           this.groupBox2.TabStop = false;
           this.groupBox2.Text = "Yeni Malzeme Girişi";
           // 
           // textBox_yenimalzeme
           // 
           this.textBox_yenimalzeme.Location = new System.Drawing.Point(9, 19);
           this.textBox_yenimalzeme.Name = "textBox_yenimalzeme";
           this.textBox_yenimalzeme.Size = new System.Drawing.Size(107, 20);
           this.textBox_yenimalzeme.TabIndex = 1;
           // 
           // label1
           // 
           this.label1.Location = new System.Drawing.Point(6, 44);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(177, 31);
           this.label1.TabIndex = 4;
           this.label1.Text = "*Eğer listede malzeme bulunmuyor ise malzemesini hızlıca ekleyiniz.";
           // 
           // button_malzemeekle
           // 
           this.button_malzemeekle.Location = new System.Drawing.Point(122, 15);
           this.button_malzemeekle.Name = "button_malzemeekle";
           this.button_malzemeekle.Size = new System.Drawing.Size(61, 26);
           this.button_malzemeekle.TabIndex = 0;
           this.button_malzemeekle.Text = "Ekle";
           this.button_malzemeekle.UseVisualStyleBackColor = true;
           this.button_malzemeekle.Click += new System.EventHandler(this.button_malzemeekle_Click);
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Location = new System.Drawing.Point(16, 229);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(62, 13);
           this.label5.TabIndex = 4;
           this.label5.Text = "./data/img/";
           // 
           // label6
           // 
           this.label6.AutoSize = true;
           this.label6.Location = new System.Drawing.Point(222, 16);
           this.label6.Name = "label6";
           this.label6.Size = new System.Drawing.Size(132, 13);
           this.label6.TabIndex = 4;
           this.label6.Text = "Varsa Malzemeleri Seçiniz:";
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(18, 160);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(57, 13);
           this.label7.TabIndex = 4;
           this.label7.Text = "Birim Fiyat:";
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Location = new System.Drawing.Point(18, 209);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(63, 13);
           this.label4.TabIndex = 4;
           this.label4.Text = "Resim Yolu:";
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(18, 73);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(86, 13);
           this.label3.TabIndex = 4;
           this.label3.Text = "Ürün Açıklaması:";
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(18, 25);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(51, 13);
           this.label2.TabIndex = 4;
           this.label2.Text = "Ürün Adı:";
           // 
           // textBox_fiyat
           // 
           this.textBox_fiyat.Location = new System.Drawing.Point(49, 176);
           this.textBox_fiyat.Name = "textBox_fiyat";
           this.textBox_fiyat.Size = new System.Drawing.Size(140, 20);
           this.textBox_fiyat.TabIndex = 1;
           // 
           // textBox_resimyolu
           // 
           this.textBox_resimyolu.Location = new System.Drawing.Point(78, 225);
           this.textBox_resimyolu.Name = "textBox_resimyolu";
           this.textBox_resimyolu.Size = new System.Drawing.Size(111, 20);
           this.textBox_resimyolu.TabIndex = 1;
           // 
           // textBox_urunaciklama
           // 
           this.textBox_urunaciklama.Location = new System.Drawing.Point(21, 89);
           this.textBox_urunaciklama.Multiline = true;
           this.textBox_urunaciklama.Name = "textBox_urunaciklama";
           this.textBox_urunaciklama.Size = new System.Drawing.Size(168, 62);
           this.textBox_urunaciklama.TabIndex = 1;
           // 
           // textBox_id
           // 
           this.textBox_id.Enabled = false;
           this.textBox_id.Location = new System.Drawing.Point(109, 13);
           this.textBox_id.Name = "textBox_id";
           this.textBox_id.Size = new System.Drawing.Size(61, 20);
           this.textBox_id.TabIndex = 1;
           // 
           // groupBox3
           // 
           this.groupBox3.Controls.Add(this.listBox_mevcuturunler);
           this.groupBox3.Location = new System.Drawing.Point(438, 5);
           this.groupBox3.Name = "groupBox3";
           this.groupBox3.Size = new System.Drawing.Size(214, 297);
           this.groupBox3.TabIndex = 4;
           this.groupBox3.TabStop = false;
           this.groupBox3.Text = "Mevcut Ürünler";
           // 
           // listBox_mevcuturunler
           // 
           this.listBox_mevcuturunler.FormattingEnabled = true;
           this.listBox_mevcuturunler.Location = new System.Drawing.Point(6, 25);
           this.listBox_mevcuturunler.Name = "listBox_mevcuturunler";
           this.listBox_mevcuturunler.Size = new System.Drawing.Size(202, 264);
           this.listBox_mevcuturunler.TabIndex = 6;
           this.listBox_mevcuturunler.SelectedIndexChanged += new System.EventHandler(this.listBox_mevcuturunler_SelectedIndexChanged);
           // 
           // yeniurun
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(664, 313);
           this.Controls.Add(this.groupBox3);
           this.Controls.Add(this.groupBox1);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
           this.MaximizeBox = false;
           this.Name = "yeniurun";
           this.Text = "Yeni Ürün Girişi";
           this.Load += new System.EventHandler(this.yeniurun_Load);
           this.groupBox1.ResumeLayout(false);
           this.groupBox1.PerformLayout();
           this.groupBox2.ResumeLayout(false);
           this.groupBox2.PerformLayout();
           this.groupBox3.ResumeLayout(false);
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_urunekle;
        private System.Windows.Forms.TextBox textBox_urunadi;
        private System.Windows.Forms.CheckedListBox checkedListBox_malzemelist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_resimyolu;
        private System.Windows.Forms.TextBox textBox_urunaciklama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_yenimalzeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_malzemeekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_fiyat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_mevcuturunler;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_reset;
    }
}