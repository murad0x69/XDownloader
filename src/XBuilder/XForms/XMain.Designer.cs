namespace XBuilder
{
    partial class XMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AboutOpenEvent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UrlFile_Box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatchETW_Chk = new System.Windows.Forms.CheckBox();
            this.MutexControl_Chk = new System.Windows.Forms.CheckBox();
            this.AntiAnyRun_Chk = new System.Windows.Forms.CheckBox();
            this.AntiAnalysis_Chk = new System.Windows.Forms.CheckBox();
            this.SelfDelete_Chk = new System.Windows.Forms.CheckBox();
            this.Autorun_Chk = new System.Windows.Forms.CheckBox();
            this.ProtectEnable_Chk = new System.Windows.Forms.CheckBox();
            this.LogotypeSoft = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Obfuscate_Chk = new System.Windows.Forms.CheckBox();
            this.BuildBtn = new System.Windows.Forms.Button();
            this.MutexLabel = new System.Windows.Forms.Label();
            this.MutexValue_Box = new System.Windows.Forms.TextBox();
            this.PathToDropFile = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.MutexGenBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogotypeSoft)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "XDownloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(85, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "The easy downloader on your .exe files!";
            // 
            // AboutOpenEvent
            // 
            this.AboutOpenEvent.AutoSize = true;
            this.AboutOpenEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutOpenEvent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutOpenEvent.ForeColor = System.Drawing.Color.Gray;
            this.AboutOpenEvent.Location = new System.Drawing.Point(315, 9);
            this.AboutOpenEvent.Name = "AboutOpenEvent";
            this.AboutOpenEvent.Size = new System.Drawing.Size(43, 17);
            this.AboutOpenEvent.TabIndex = 3;
            this.AboutOpenEvent.Text = "About";
            this.AboutOpenEvent.Click += new System.EventHandler(this.AboutOpenEvent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "URL:";
            // 
            // UrlFile_Box
            // 
            this.UrlFile_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UrlFile_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlFile_Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlFile_Box.ForeColor = System.Drawing.Color.Aquamarine;
            this.UrlFile_Box.Location = new System.Drawing.Point(19, 120);
            this.UrlFile_Box.Multiline = true;
            this.UrlFile_Box.Name = "UrlFile_Box";
            this.UrlFile_Box.Size = new System.Drawing.Size(339, 25);
            this.UrlFile_Box.TabIndex = 5;
            this.UrlFile_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatchETW_Chk);
            this.groupBox1.Controls.Add(this.MutexControl_Chk);
            this.groupBox1.Controls.Add(this.AntiAnyRun_Chk);
            this.groupBox1.Controls.Add(this.AntiAnalysis_Chk);
            this.groupBox1.Controls.Add(this.SelfDelete_Chk);
            this.groupBox1.Controls.Add(this.Autorun_Chk);
            this.groupBox1.Controls.Add(this.ProtectEnable_Chk);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // PatchETW_Chk
            // 
            this.PatchETW_Chk.AutoSize = true;
            this.PatchETW_Chk.BackColor = System.Drawing.Color.Transparent;
            this.PatchETW_Chk.Enabled = false;
            this.PatchETW_Chk.Location = new System.Drawing.Point(113, 61);
            this.PatchETW_Chk.Name = "PatchETW_Chk";
            this.PatchETW_Chk.Size = new System.Drawing.Size(77, 17);
            this.PatchETW_Chk.TabIndex = 6;
            this.PatchETW_Chk.Text = "PatchETW";
            this.PatchETW_Chk.UseVisualStyleBackColor = false;
            // 
            // MutexControl_Chk
            // 
            this.MutexControl_Chk.AutoSize = true;
            this.MutexControl_Chk.BackColor = System.Drawing.Color.Transparent;
            this.MutexControl_Chk.Enabled = false;
            this.MutexControl_Chk.Location = new System.Drawing.Point(218, 61);
            this.MutexControl_Chk.Name = "MutexControl_Chk";
            this.MutexControl_Chk.Size = new System.Drawing.Size(97, 17);
            this.MutexControl_Chk.TabIndex = 5;
            this.MutexControl_Chk.Text = "MutexControl";
            this.MutexControl_Chk.UseVisualStyleBackColor = false;
            this.MutexControl_Chk.CheckedChanged += new System.EventHandler(this.MutexControl_Chk_CheckedChanged);
            // 
            // AntiAnyRun_Chk
            // 
            this.AntiAnyRun_Chk.AutoSize = true;
            this.AntiAnyRun_Chk.BackColor = System.Drawing.Color.Transparent;
            this.AntiAnyRun_Chk.Enabled = false;
            this.AntiAnyRun_Chk.Location = new System.Drawing.Point(218, 38);
            this.AntiAnyRun_Chk.Name = "AntiAnyRun_Chk";
            this.AntiAnyRun_Chk.Size = new System.Drawing.Size(121, 17);
            this.AntiAnyRun_Chk.TabIndex = 4;
            this.AntiAnyRun_Chk.Text = "AntiAnyRun(WIN7)";
            this.AntiAnyRun_Chk.UseVisualStyleBackColor = false;
            // 
            // AntiAnalysis_Chk
            // 
            this.AntiAnalysis_Chk.AutoSize = true;
            this.AntiAnalysis_Chk.BackColor = System.Drawing.Color.Transparent;
            this.AntiAnalysis_Chk.Enabled = false;
            this.AntiAnalysis_Chk.Location = new System.Drawing.Point(113, 38);
            this.AntiAnalysis_Chk.Name = "AntiAnalysis_Chk";
            this.AntiAnalysis_Chk.Size = new System.Drawing.Size(88, 17);
            this.AntiAnalysis_Chk.TabIndex = 3;
            this.AntiAnalysis_Chk.Text = "AntiAnalysis\r\n";
            this.AntiAnalysis_Chk.UseVisualStyleBackColor = false;
            // 
            // SelfDelete_Chk
            // 
            this.SelfDelete_Chk.AutoSize = true;
            this.SelfDelete_Chk.BackColor = System.Drawing.Color.Transparent;
            this.SelfDelete_Chk.Enabled = false;
            this.SelfDelete_Chk.Location = new System.Drawing.Point(6, 61);
            this.SelfDelete_Chk.Name = "SelfDelete_Chk";
            this.SelfDelete_Chk.Size = new System.Drawing.Size(78, 17);
            this.SelfDelete_Chk.TabIndex = 2;
            this.SelfDelete_Chk.Text = "SelfDelete";
            this.SelfDelete_Chk.UseVisualStyleBackColor = false;
            // 
            // Autorun_Chk
            // 
            this.Autorun_Chk.AutoSize = true;
            this.Autorun_Chk.BackColor = System.Drawing.Color.Transparent;
            this.Autorun_Chk.Enabled = false;
            this.Autorun_Chk.Location = new System.Drawing.Point(6, 38);
            this.Autorun_Chk.Name = "Autorun_Chk";
            this.Autorun_Chk.Size = new System.Drawing.Size(69, 17);
            this.Autorun_Chk.TabIndex = 1;
            this.Autorun_Chk.Text = "Autorun";
            this.Autorun_Chk.UseVisualStyleBackColor = false;
            // 
            // ProtectEnable_Chk
            // 
            this.ProtectEnable_Chk.AutoSize = true;
            this.ProtectEnable_Chk.BackColor = System.Drawing.Color.Transparent;
            this.ProtectEnable_Chk.Location = new System.Drawing.Point(113, 15);
            this.ProtectEnable_Chk.Name = "ProtectEnable_Chk";
            this.ProtectEnable_Chk.Size = new System.Drawing.Size(101, 17);
            this.ProtectEnable_Chk.TabIndex = 0;
            this.ProtectEnable_Chk.Text = "Protect-Enable";
            this.ProtectEnable_Chk.UseVisualStyleBackColor = false;
            this.ProtectEnable_Chk.CheckedChanged += new System.EventHandler(this.ProtectEnable_Chk_CheckedChanged);
            // 
            // LogotypeSoft
            // 
            this.LogotypeSoft.Image = global::XBuilder.Properties.Resources.ALogo;
            this.LogotypeSoft.Location = new System.Drawing.Point(19, 23);
            this.LogotypeSoft.Name = "LogotypeSoft";
            this.LogotypeSoft.Size = new System.Drawing.Size(58, 56);
            this.LogotypeSoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogotypeSoft.TabIndex = 0;
            this.LogotypeSoft.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(16, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Obfuscation:";
            // 
            // Obfuscate_Chk
            // 
            this.Obfuscate_Chk.AutoSize = true;
            this.Obfuscate_Chk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Obfuscate_Chk.ForeColor = System.Drawing.Color.White;
            this.Obfuscate_Chk.Location = new System.Drawing.Point(19, 463);
            this.Obfuscate_Chk.Name = "Obfuscate_Chk";
            this.Obfuscate_Chk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Obfuscate_Chk.Size = new System.Drawing.Size(118, 17);
            this.Obfuscate_Chk.TabIndex = 6;
            this.Obfuscate_Chk.Text = "SimpleObfuscator";
            this.Obfuscate_Chk.UseVisualStyleBackColor = true;
            // 
            // BuildBtn
            // 
            this.BuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildBtn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildBtn.ForeColor = System.Drawing.Color.White;
            this.BuildBtn.Image = global::XBuilder.Properties.Resources.AWin;
            this.BuildBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuildBtn.Location = new System.Drawing.Point(154, 429);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(204, 51);
            this.BuildBtn.TabIndex = 12;
            this.BuildBtn.Text = "Build";
            this.BuildBtn.UseVisualStyleBackColor = true;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // MutexLabel
            // 
            this.MutexLabel.AutoSize = true;
            this.MutexLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutexLabel.ForeColor = System.Drawing.Color.Gray;
            this.MutexLabel.Location = new System.Drawing.Point(16, 164);
            this.MutexLabel.Name = "MutexLabel";
            this.MutexLabel.Size = new System.Drawing.Size(125, 17);
            this.MutexLabel.TabIndex = 13;
            this.MutexLabel.Text = "Mutex ( if enabled ):";
            // 
            // MutexValue_Box
            // 
            this.MutexValue_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MutexValue_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MutexValue_Box.Enabled = false;
            this.MutexValue_Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutexValue_Box.ForeColor = System.Drawing.Color.Aquamarine;
            this.MutexValue_Box.Location = new System.Drawing.Point(19, 184);
            this.MutexValue_Box.Multiline = true;
            this.MutexValue_Box.Name = "MutexValue_Box";
            this.MutexValue_Box.Size = new System.Drawing.Size(271, 25);
            this.MutexValue_Box.TabIndex = 14;
            this.MutexValue_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PathToDropFile
            // 
            this.PathToDropFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PathToDropFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathToDropFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathToDropFile.ForeColor = System.Drawing.Color.White;
            this.PathToDropFile.FormattingEnabled = true;
            this.PathToDropFile.Items.AddRange(new object[] {
            "%temp%",
            "%programdata%",
            "%appdata%",
            "%localappdata%",
            "%public%",
            "%userprofile%"});
            this.PathToDropFile.Location = new System.Drawing.Point(112, 390);
            this.PathToDropFile.Name = "PathToDropFile";
            this.PathToDropFile.Size = new System.Drawing.Size(150, 21);
            this.PathToDropFile.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(16, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Path-To-Drop:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(16, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Final downloaded file name ( ex: Malware.exe ):";
            // 
            // FileNameBox
            // 
            this.FileNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FileNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.FileNameBox.Location = new System.Drawing.Point(19, 243);
            this.FileNameBox.Multiline = true;
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(339, 25);
            this.FileNameBox.TabIndex = 17;
            this.FileNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MutexGenBtn
            // 
            this.MutexGenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MutexGenBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutexGenBtn.ForeColor = System.Drawing.Color.White;
            this.MutexGenBtn.Image = global::XBuilder.Properties.Resources.AEngine;
            this.MutexGenBtn.Location = new System.Drawing.Point(294, 184);
            this.MutexGenBtn.Name = "MutexGenBtn";
            this.MutexGenBtn.Size = new System.Drawing.Size(64, 25);
            this.MutexGenBtn.TabIndex = 18;
            this.MutexGenBtn.UseVisualStyleBackColor = true;
            this.MutexGenBtn.Click += new System.EventHandler(this.MutexGenBtn_Click);
            // 
            // XMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(370, 504);
            this.Controls.Add(this.MutexGenBtn);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PathToDropFile);
            this.Controls.Add(this.MutexValue_Box);
            this.Controls.Add(this.MutexLabel);
            this.Controls.Add(this.BuildBtn);
            this.Controls.Add(this.Obfuscate_Chk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UrlFile_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AboutOpenEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogotypeSoft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XDownLoader 1.5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogotypeSoft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogotypeSoft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AboutOpenEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrlFile_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Autorun_Chk;
        private System.Windows.Forms.CheckBox ProtectEnable_Chk;
        private System.Windows.Forms.CheckBox AntiAnyRun_Chk;
        private System.Windows.Forms.CheckBox AntiAnalysis_Chk;
        private System.Windows.Forms.CheckBox SelfDelete_Chk;
        private System.Windows.Forms.CheckBox MutexControl_Chk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Obfuscate_Chk;
        private System.Windows.Forms.Button BuildBtn;
        private System.Windows.Forms.Label MutexLabel;
        private System.Windows.Forms.TextBox MutexValue_Box;
        private System.Windows.Forms.ComboBox PathToDropFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.CheckBox PatchETW_Chk;
        private System.Windows.Forms.Button MutexGenBtn;
    }
}

