using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Progress : Form
    {
        public bool dec = false;
        public bool aes = false;
        public Progress()
        {
            InitializeComponent();
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            /* Test */
            bool tester = true;

            if (dec)
            {
                if (aes)
                {
                    pBarBlock.Hide();
                }
                else
                {
                    pBarAES.Hide();
                    
                }
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBarAES_Click(object sender, EventArgs e)
        {
            if (pBarAES.Value != pBarAES.Maximum && pBarBlock.Value != pBarBlock.Maximum)
            {
                lblComplete.Text = "Complete";
                btnClose.Enabled = true;
            }
        }

        private void pBarBlock_Click(object sender, EventArgs e)
        {
            if (pBarAES.Value != pBarAES.Maximum && pBarBlock.Value != pBarBlock.Maximum)
            {
                lblComplete.Text = "Complete";
                btnClose.Enabled = true;
            }
        }

        private void Progress_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void CheckProgress()
        {
            if (dec)
            {
                if (aes)
                {
                    if (pBarAES.Value == pBarAES.Maximum)
                    {
                        lblComplete.Text = "Complete";
                        btnClose.Enabled = true;
                    }
                }
                else
                {

                    if (pBarBlock.Value == pBarBlock.Maximum)
                    {
                        lblComplete.Text = "Complete";
                        btnClose.Enabled = true;
                    }
                }
            }
            else
            {

                if (pBarAES.Value == pBarAES.Maximum && pBarBlock.Value == pBarBlock.Maximum)
                {
                    lblComplete.Text = "Complete";
                    btnClose.Enabled = true;
                }
            }
        }
    }
}
