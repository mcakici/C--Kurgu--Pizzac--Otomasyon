namespace restoran_Otomasyon_WinUI
{
    partial class Form1
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
           System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
           this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
           this.panel_admin = new System.Windows.Forms.Panel();
           this.pictureBox1 = new System.Windows.Forms.PictureBox();
           this.menuStrip1 = new System.Windows.Forms.MenuStrip();
           this.label_date = new System.Windows.Forms.Label();
           this.label_oturumtipi = new System.Windows.Forms.Label();
           this.panel_admin.SuspendLayout();
           ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
           this.SuspendLayout();
           // 
           // panel_admin
           // 
           this.panel_admin.Controls.Add(this.pictureBox1);
           this.panel_admin.Controls.Add(this.menuStrip1);
           this.panel_admin.Controls.Add(this.label_date);
           this.panel_admin.Controls.Add(this.label_oturumtipi);
           this.panel_admin.Dock = System.Windows.Forms.DockStyle.Top;
           this.panel_admin.Location = new System.Drawing.Point(0, 0);
           this.panel_admin.Name = "panel_admin";
           this.panel_admin.Size = new System.Drawing.Size(760, 61);
           this.panel_admin.TabIndex = 3;
           // 
           // pictureBox1
           // 
           this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
           this.pictureBox1.Location = new System.Drawing.Point(0, 0);
           this.pictureBox1.Name = "pictureBox1";
           this.pictureBox1.Size = new System.Drawing.Size(379, 32);
           this.pictureBox1.TabIndex = 4;
           this.pictureBox1.TabStop = false;
           // 
           // menuStrip1
           // 
           this.menuStrip1.AutoSize = false;
           this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
           this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
           this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
           this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
           this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
           this.menuStrip1.Location = new System.Drawing.Point(0, 32);
           this.menuStrip1.Name = "menuStrip1";
           this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
           this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
           this.menuStrip1.Size = new System.Drawing.Size(760, 29);
           this.menuStrip1.TabIndex = 2;
           this.menuStrip1.Text = "menuStrip1";
           // 
           // label_date
           // 
           this.label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
           this.label_date.Location = new System.Drawing.Point(583, 4);
           this.label_date.Name = "label_date";
           this.label_date.Size = new System.Drawing.Size(165, 12);
           this.label_date.TabIndex = 3;
           this.label_date.Text = "Oturum Tipi";
           this.label_date.TextAlign = System.Drawing.ContentAlignment.TopRight;
           // 
           // label_oturumtipi
           // 
           this.label_oturumtipi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.label_oturumtipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
           this.label_oturumtipi.Location = new System.Drawing.Point(585, 16);
           this.label_oturumtipi.Name = "label_oturumtipi";
           this.label_oturumtipi.Size = new System.Drawing.Size(163, 16);
           this.label_oturumtipi.TabIndex = 3;
           this.label_oturumtipi.Text = "Oturum Tipi";
           this.label_oturumtipi.TextAlign = System.Drawing.ContentAlignment.TopRight;
           // 
           // Form1
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(760, 480);
           this.Controls.Add(this.panel_admin);
           this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
           this.IsMdiContainer = true;
           this.Name = "Form1";
           this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
           this.Text = "Cafe&Restoran Otomasyon v1.0";
           this.Load += new System.EventHandler(this.Form1_Load);
           this.panel_admin.ResumeLayout(false);
           ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.Label label_oturumtipi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_date;
    }
}

