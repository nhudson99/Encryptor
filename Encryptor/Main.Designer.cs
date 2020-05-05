namespace Encryptor
{
    partial class Main
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
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnSource = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.LbLoadedFiles = new System.Windows.Forms.CheckedListBox();
            this.btnRemoveFiles = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cLbFolder = new System.Windows.Forms.CheckedListBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnStats = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(548, 10);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(177, 13);
            label7.TabIndex = 19;
            label7.Text = "Password for Encryption/Decryption";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(46, 11);
            this.btnSource.Margin = new System.Windows.Forms.Padding(2);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(135, 26);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Source Folder";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEncrypt.Location = new System.Drawing.Point(800, 237);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(292, 60);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDecrypt.Location = new System.Drawing.Point(800, 301);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(292, 60);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoadFiles.Location = new System.Drawing.Point(800, 83);
            this.btnLoadFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(134, 60);
            this.btnLoadFiles.TabIndex = 6;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // LbLoadedFiles
            // 
            this.LbLoadedFiles.CheckOnClick = true;
            this.LbLoadedFiles.FormattingEnabled = true;
            this.LbLoadedFiles.Location = new System.Drawing.Point(548, 83);
            this.LbLoadedFiles.Margin = new System.Windows.Forms.Padding(2);
            this.LbLoadedFiles.Name = "LbLoadedFiles";
            this.LbLoadedFiles.Size = new System.Drawing.Size(204, 259);
            this.LbLoadedFiles.TabIndex = 7;
            // 
            // btnRemoveFiles
            // 
            this.btnRemoveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemoveFiles.Location = new System.Drawing.Point(958, 83);
            this.btnRemoveFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFiles.Name = "btnRemoveFiles";
            this.btnRemoveFiles.Size = new System.Drawing.Size(134, 60);
            this.btnRemoveFiles.TabIndex = 8;
            this.btnRemoveFiles.Text = "Remove Files";
            this.btnRemoveFiles.UseVisualStyleBackColor = true;
            this.btnRemoveFiles.Click += new System.EventHandler(this.btnRemoveFiles_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPreview.Location = new System.Drawing.Point(800, 173);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(292, 60);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cLbFolder
            // 
            this.cLbFolder.CheckOnClick = true;
            this.cLbFolder.FormattingEnabled = true;
            this.cLbFolder.Location = new System.Drawing.Point(46, 81);
            this.cLbFolder.Name = "cLbFolder";
            this.cLbFolder.Size = new System.Drawing.Size(421, 259);
            this.cLbFolder.TabIndex = 10;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Folder of Files to Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Folder Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loaded Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Click To Load ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Click To Remove";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select from Loaded Files to Perform Operations";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(376, 23);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(139, 23);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Test!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(548, 27);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 20);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(548, 368);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(202, 29);
            this.btnStats.TabIndex = 20;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 376);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Encryption/Decryption Stats";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1118, 415);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cLbFolder);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnRemoveFiles);
            this.Controls.Add(this.LbLoadedFiles);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSource);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(50, 52, 50, 52);
            this.Text = "Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.CheckedListBox LbLoadedFiles;
        private System.Windows.Forms.Button btnRemoveFiles;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckedListBox cLbFolder;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label label8;
    }
}

