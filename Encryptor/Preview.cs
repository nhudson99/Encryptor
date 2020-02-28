using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Preview : Form
    {
        public LoadedFiles file;

        public Preview(LoadedFiles file1)
        {
            InitializeComponent();

            file = file1;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            string fileText = File.ReadAllText(file.filePath);

            rTBpreview.Text = fileText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
