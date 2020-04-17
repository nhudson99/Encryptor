namespace Encryptor
{
    partial class Progress
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
            this.pBarAES = new System.Windows.Forms.ProgressBar();
            this.lblComplete = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pBarBlock = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pBarAES
            // 
            this.pBarAES.Location = new System.Drawing.Point(187, 130);
            this.pBarAES.Name = "pBarAES";
            this.pBarAES.Size = new System.Drawing.Size(457, 50);
            this.pBarAES.TabIndex = 0;
            this.pBarAES.Click += new System.EventHandler(this.pBarAES_Click);
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(333, 83);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(150, 25);
            this.lblComplete.TabIndex = 1;
            this.lblComplete.Text = "Still Working...";
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(338, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pBarBlock
            // 
            this.pBarBlock.Location = new System.Drawing.Point(187, 210);
            this.pBarBlock.Name = "pBarBlock";
            this.pBarBlock.Size = new System.Drawing.Size(457, 50);
            this.pBarBlock.TabIndex = 3;
            this.pBarBlock.Click += new System.EventHandler(this.pBarBlock_Click);
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBarBlock);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.pBarAES);
            this.Name = "Progress";
            this.Text = "Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Progress_FormClosing);
            this.Load += new System.EventHandler(this.Progress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBarAES;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar pBarBlock;
    }
}