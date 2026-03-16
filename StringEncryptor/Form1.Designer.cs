namespace StringEncryptor
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
            this.components = new System.ComponentModel.Container();
            this.gbxEncryption = new System.Windows.Forms.GroupBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbxEncrypted = new System.Windows.Forms.TextBox();
            this.gbxDecryption = new System.Windows.Forms.GroupBox();
            this.tbxDecrypted = new System.Windows.Forms.TextBox();
            this.trkEncryptionKey = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxOriginal = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbxOriginal = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMinutes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.gbxEncryption.SuspendLayout();
            this.gbxDecryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkEncryptionKey)).BeginInit();
            this.gbxOriginal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEncryption
            // 
            this.gbxEncryption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbxEncryption.Controls.Add(this.btnDecrypt);
            this.gbxEncryption.Controls.Add(this.tbxEncrypted);
            this.gbxEncryption.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEncryption.Location = new System.Drawing.Point(637, 134);
            this.gbxEncryption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEncryption.Name = "gbxEncryption";
            this.gbxEncryption.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEncryption.Size = new System.Drawing.Size(474, 389);
            this.gbxEncryption.TabIndex = 1;
            this.gbxEncryption.TabStop = false;
            this.gbxEncryption.Text = "Encrypted Text";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Tomato;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Location = new System.Drawing.Point(137, 328);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(164, 53);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt Text";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbxEncrypted
            // 
            this.tbxEncrypted.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxEncrypted.Location = new System.Drawing.Point(4, 40);
            this.tbxEncrypted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEncrypted.Multiline = true;
            this.tbxEncrypted.Name = "tbxEncrypted";
            this.tbxEncrypted.ReadOnly = true;
            this.tbxEncrypted.Size = new System.Drawing.Size(466, 260);
            this.tbxEncrypted.TabIndex = 1;
            this.tbxEncrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxDecryption
            // 
            this.gbxDecryption.BackColor = System.Drawing.Color.Silver;
            this.gbxDecryption.Controls.Add(this.tbxDecrypted);
            this.gbxDecryption.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDecryption.Location = new System.Drawing.Point(1151, 134);
            this.gbxDecryption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDecryption.Name = "gbxDecryption";
            this.gbxDecryption.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDecryption.Size = new System.Drawing.Size(448, 389);
            this.gbxDecryption.TabIndex = 2;
            this.gbxDecryption.TabStop = false;
            this.gbxDecryption.Text = "Decrypted Text";
            // 
            // tbxDecrypted
            // 
            this.tbxDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDecrypted.Location = new System.Drawing.Point(4, 40);
            this.tbxDecrypted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDecrypted.Multiline = true;
            this.tbxDecrypted.Name = "tbxDecrypted";
            this.tbxDecrypted.ReadOnly = true;
            this.tbxDecrypted.Size = new System.Drawing.Size(440, 345);
            this.tbxDecrypted.TabIndex = 2;
            this.tbxDecrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkEncryptionKey
            // 
            this.trkEncryptionKey.BackColor = System.Drawing.SystemColors.ControlText;
            this.trkEncryptionKey.LargeChange = 2;
            this.trkEncryptionKey.Location = new System.Drawing.Point(530, 116);
            this.trkEncryptionKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkEncryptionKey.Name = "trkEncryptionKey";
            this.trkEncryptionKey.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkEncryptionKey.Size = new System.Drawing.Size(56, 407);
            this.trkEncryptionKey.SmallChange = 2;
            this.trkEncryptionKey.TabIndex = 3;
            this.trkEncryptionKey.TickFrequency = 2;
            this.trkEncryptionKey.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(524, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 66);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encryption\r\nKey:";
            // 
            // gbxOriginal
            // 
            this.gbxOriginal.BackColor = System.Drawing.Color.DarkKhaki;
            this.gbxOriginal.Controls.Add(this.btnClear);
            this.gbxOriginal.Controls.Add(this.btnEncrypt);
            this.gbxOriginal.Controls.Add(this.tbxOriginal);
            this.gbxOriginal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOriginal.Location = new System.Drawing.Point(25, 55);
            this.gbxOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxOriginal.Name = "gbxOriginal";
            this.gbxOriginal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxOriginal.Size = new System.Drawing.Size(480, 432);
            this.gbxOriginal.TabIndex = 5;
            this.gbxOriginal.TabStop = false;
            this.gbxOriginal.Text = "Original Text";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(127, 350);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 57);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Text";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(127, 266);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(191, 54);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt Text";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbxOriginal
            // 
            this.tbxOriginal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOriginal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxOriginal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOriginal.Location = new System.Drawing.Point(4, 40);
            this.tbxOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxOriginal.Multiline = true;
            this.tbxOriginal.Name = "tbxOriginal";
            this.tbxOriginal.Size = new System.Drawing.Size(472, 218);
            this.tbxOriginal.TabIndex = 10;
            this.tbxOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxOriginal.Enter += new System.EventHandler(this.StartTyping);
            this.tbxOriginal.Leave += new System.EventHandler(this.FinishTyping);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.IndianRed;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkGreen;
            this.progressBar1.Location = new System.Drawing.Point(81, 565);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(628, 35);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(725, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "String Encrypter";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(18, 560);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(55, 40);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(745, 563);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(31, 36);
            this.lblMinutes.TabIndex = 9;
            this.lblMinutes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(773, 563);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(801, 563);
            this.lblSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(47, 36);
            this.lblSeconds.TabIndex = 11;
            this.lblSeconds.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1614, 610);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbxDecryption);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbxOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkEncryptionKey);
            this.Controls.Add(this.gbxEncryption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxEncryption.ResumeLayout(false);
            this.gbxEncryption.PerformLayout();
            this.gbxDecryption.ResumeLayout(false);
            this.gbxDecryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkEncryptionKey)).EndInit();
            this.gbxOriginal.ResumeLayout(false);
            this.gbxOriginal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEncryption;
        private System.Windows.Forms.GroupBox gbxDecryption;
        private System.Windows.Forms.TrackBar trkEncryptionKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxOriginal;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbxOriginal;
        private System.Windows.Forms.TextBox tbxEncrypted;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbxDecrypted;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSeconds;
    }
}

