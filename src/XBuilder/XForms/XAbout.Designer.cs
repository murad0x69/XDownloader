namespace XBuilder.XForms
{
    partial class XAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogotypeSoft = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.LinkLabel();
            this.GitLabel = new System.Windows.Forms.LinkLabel();
            this.ModuleLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogotypeSoft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XBuilder.Properties.Resources.HXLogo;
            this.pictureBox1.Location = new System.Drawing.Point(324, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "XDownloader";
            // 
            // LogotypeSoft
            // 
            this.LogotypeSoft.Image = global::XBuilder.Properties.Resources.ALogo;
            this.LogotypeSoft.Location = new System.Drawing.Point(12, 12);
            this.LogotypeSoft.Name = "LogotypeSoft";
            this.LogotypeSoft.Size = new System.Drawing.Size(58, 56);
            this.LogotypeSoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogotypeSoft.TabIndex = 2;
            this.LogotypeSoft.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(78, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "The easy downloader on your .exe files!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Credits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Aquamarine;
            this.label6.Location = new System.Drawing.Point(13, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 8;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.LinkColor = System.Drawing.Color.Aquamarine;
            this.AuthorLabel.Location = new System.Drawing.Point(14, 116);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(114, 13);
            this.AuthorLabel.TabIndex = 9;
            this.AuthorLabel.TabStop = true;
            this.AuthorLabel.Text = "● Author: K3rnel-Dev";
            this.AuthorLabel.VisitedLinkColor = System.Drawing.Color.Lime;
            this.AuthorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLabel_LinkClicked);
            // 
            // GitLabel
            // 
            this.GitLabel.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.GitLabel.AutoSize = true;
            this.GitLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLabel.LinkColor = System.Drawing.Color.Aquamarine;
            this.GitLabel.Location = new System.Drawing.Point(14, 138);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(214, 13);
            this.GitLabel.TabIndex = 10;
            this.GitLabel.TabStop = true;
            this.GitLabel.Text = "● Github: https://github.com/k3rnel-dev\r\n";
            this.GitLabel.VisitedLinkColor = System.Drawing.Color.Lime;
            this.GitLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitLabel_LinkClicked);
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModuleLabel.LinkColor = System.Drawing.Color.Aquamarine;
            this.ModuleLabel.Location = new System.Drawing.Point(14, 160);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(85, 13);
            this.ModuleLabel.TabIndex = 11;
            this.ModuleLabel.TabStop = true;
            this.ModuleLabel.Text = "● Dnlib (0xd4d)";
            this.ModuleLabel.VisitedLinkColor = System.Drawing.Color.Lime;
            this.ModuleLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ModuleLabel_LinkClicked);
            // 
            // XAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(471, 185);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.GitLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogotypeSoft);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XDownloader 1.5 | About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogotypeSoft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogotypeSoft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel AuthorLabel;
        private System.Windows.Forms.LinkLabel GitLabel;
        private System.Windows.Forms.LinkLabel ModuleLabel;
    }
}