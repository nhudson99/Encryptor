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
    public partial class Main : Form
    {
        //List of Loaded Files
        private List<LoadedFiles> loaded = new List<LoadedFiles>();

        public Main()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            cLbFolder.Items.Clear();

            // Display files inside checked list box from selected directory
            using(FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select Root Directory" })
            {
                if(fdb.ShowDialog() == DialogResult.OK)
                {
                    //    wBrowser.Url = new Uri(fdb.SelectedPath);

                    string[] files = Directory.GetFiles(fdb.SelectedPath);

                    //Add Files to checked list box
                    foreach (string f in files)
                    {
                        cLbFolder.Items.Add(f);
                    }

                }

            }
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            // count of checked items
            int itemCount = cLbFolder.CheckedItems.Count;
            int i=0;

            //array to hold items 
            string[] folderItems = new string[itemCount];

            //array of Loaded Files
            //LoadedFiles[] loaded = new LoadedFiles[itemCount];
            
            foreach(string s in cLbFolder.CheckedItems)
            {
                folderItems[i] = s;
                i++;
            }
            for(i = 0; i<itemCount;i++)
            {
                loaded.Add(new LoadedFiles());
                loaded[i].filePath = folderItems[i];
                loaded[i].fileName = Path.GetFileName(folderItems[i]);
                LbLoadedFiles.Items.Add(loaded[i].fileName);
            }

            
        }

        private void btnRemoveFiles_Click(object sender, EventArgs e)
        {
            foreach (var item in LbLoadedFiles.CheckedItems.OfType<string>().ToList())
            {
                LbLoadedFiles.Items.Remove(item);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();

            foreach (var file in loaded)
            {
                dialog.Document.DocumentName = file.filePath;
                dialog.ShowDialog();
            }
        }
    }
}
