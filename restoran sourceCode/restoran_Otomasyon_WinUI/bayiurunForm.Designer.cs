namespace restoran_Otomasyon_WinUI
{
   partial class bayiurunForm
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
         this.checkedListBox_satistakiUrunler = new System.Windows.Forms.CheckedListBox();
         this.comboBox_bayi = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // checkedListBox_satistakiUrunler
         // 
         this.checkedListBox_satistakiUrunler.CheckOnClick = true;
         this.checkedListBox_satistakiUrunler.FormattingEnabled = true;
         this.checkedListBox_satistakiUrunler.Location = new System.Drawing.Point(22, 59);
         this.checkedListBox_satistakiUrunler.Name = "checkedListBox_satistakiUrunler";
         this.checkedListBox_satistakiUrunler.Size = new System.Drawing.Size(228, 229);
         this.checkedListBox_satistakiUrunler.TabIndex = 8;
         // 
         // comboBox_bayi
         // 
         this.comboBox_bayi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox_bayi.FormattingEnabled = true;
         this.comboBox_bayi.Location = new System.Drawing.Point(22, 9);
         this.comboBox_bayi.Name = "comboBox_bayi";
         this.comboBox_bayi.Size = new System.Drawing.Size(228, 21);
         this.comboBox_bayi.TabIndex = 9;
         this.comboBox_bayi.SelectedIndexChanged += new System.EventHandler(this.comboBox_bayi_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(22, 43);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(126, 13);
         this.label2.TabIndex = 10;
         this.label2.Text = "Bayinin Satıştaki Ürünleri:";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(22, 294);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(228, 23);
         this.button1.TabIndex = 11;
         this.button1.Text = "Kaydet";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // bayiurunForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(268, 329);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.comboBox_bayi);
         this.Controls.Add(this.checkedListBox_satistakiUrunler);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "bayiurunForm";
         this.Text = "Bayi Ürünleri";
         this.Load += new System.EventHandler(this.bayiurunForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.CheckedListBox checkedListBox_satistakiUrunler;
      private System.Windows.Forms.ComboBox comboBox_bayi;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button1;
   }
}