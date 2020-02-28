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
    public partial class PreviewImage : Form
    {
        LoadedFiles file;

        public PreviewImage(LoadedFiles file1)
        {
            InitializeComponent();

            file = file1;
        }

        private void PreviewImage_Load(object sender, EventArgs e)
        {
            pBpreview.ImageLocation = file.filePath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
