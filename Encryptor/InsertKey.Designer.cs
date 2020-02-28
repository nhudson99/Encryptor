namespace Encryptor
{
    partial class InsertKey
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
            this.txtFirst2 = new System.Windows.Forms.TextBox();
            this.txtSecond2 = new System.Windows.Forms.TextBox();
            this.txtThird2 = new System.Windows.Forms.TextBox();
            this.txtLast2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirst2
            // 
            this.txtFirst2.Location = new System.Drawing.Point(16, 94);
            this.txtFirst2.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirst2.Name = "txtFirst2";
            this.txtFirst2.Size = new System.Drawing.Size(47, 20);
            this.txtFirst2.TabIndex = 0;
            // 
            // txtSecond2
            // 
            this.txtSecond2.Location = new System.Drawing.Point(80, 94);
            this.txtSecond2.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecond2.Name = "txtSecond2";
            this.txtSecond2.Size = new System.Drawing.Size(47, 20);
            this.txtSecond2.TabIndex = 1;
            // 
            // txtThird2
            // 
            this.txtThird2.Location = new System.Drawing.Point(144, 94);
            this.txtThird2.Margin = new System.Windows.Forms.Padding(2);
            this.txtThird2.Name = "txtThird2";
            this.txtThird2.Size = new System.Drawing.Size(47, 20);
            this.txtThird2.TabIndex = 2;
            // 
            // txtLast2
            // 
            this.txtLast2.Location = new System.Drawing.Point(208, 94);
            this.txtLast2.Margin = new System.Windows.Forms.Padding(2);
            this.txtLast2.Name = "txtLast2";
            this.txtLast2.Size = new System.Drawing.Size(47, 20);
            this.txtLast2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "--";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 192);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 29);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 192);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Please insert the 4 bit key given upon encryption";
            // 
            // InsertKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLast2);
            this.Controls.Add(this.txtThird2);
            this.Controls.Add(this.txtSecond2);
            this.Controls.Add(this.txtFirst2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertKey";
            this.Text = "InsertKey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertKey_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst2;
        private System.Windows.Forms.TextBox txtSecond2;
        private System.Windows.Forms.TextBox txtThird2;
        private System.Windows.Forms.TextBox txtLast2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
    }
}