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
    public partial class InsertKey : Form
    {
        public string fullKey;
        public bool cancel = false;
        public byte[] key;
        
        public InsertKey()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fullKey = txtFirst2.Text + txtSecond2.Text + txtThird2.Text + txtLast2.Text;
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void InsertKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Closing");
            key = StringToByteArray(fullKey);
            
        }
    }
}
