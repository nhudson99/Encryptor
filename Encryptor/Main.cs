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
        private string FolderPath;

        private byte[] EncryptAES()
        {
            byte[] encrypted = new byte[1000];

            return encrypted;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            cLbFolder.Items.Clear();

            // Display files inside checked list box from selected directory
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select Root Directory" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    //    wBrowser.Url = new Uri(fdb.SelectedPath);

                    FolderPath = fdb.SelectedPath;

                    string[] files = Directory.GetFiles(fdb.SelectedPath);

                    //Add Files to checked list box
                    foreach (string f in files)
                    {
                        cLbFolder.Items.Add(f);
                    }

                    //MessageBox.Show(fdb.SelectedPath);

                    if (!Directory.Exists(fdb.SelectedPath + "\\Stats"))
                    {
                        Directory.CreateDirectory(fdb.SelectedPath + "\\Stats");
                        File.Create(fdb.SelectedPath + "\\Stats\\Stats.txt");
                    }

                }

            }
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            // count of checked items
            int itemCount = cLbFolder.CheckedItems.Count;
            int i = 0;

            //array to hold items 
            string[] folderItems = new string[itemCount];

            //array of Loaded Files
            //LoadedFiles[] loaded = new LoadedFiles[itemCount];

            foreach (string s in cLbFolder.CheckedItems)
            {
                folderItems[i] = s;
                i++;
            }
            try
            {
                for (i = 0; i < itemCount; i++)
                {
                    loaded.Add(new LoadedFiles());
                    loaded[i].filePath = folderItems[i];
                    loaded[i].fileName = Path.GetFileName(folderItems[i]);
                    foreach (string s in LbLoadedFiles.Items)
                        if (loaded[i].fileName == s)
                            throw new Exception("One of Selected Items already loaded");
                    LbLoadedFiles.Items.Add(loaded[i].fileName);
                    FileInfo fileInfo = new FileInfo(loaded[i].filePath);
                    loaded[i].bytes = new byte[fileInfo.Length];
                    loaded[i].encBytes = new byte[fileInfo.Length];
                    loaded[i].decBytes = new byte[fileInfo.Length];
                    loaded[i].bytes = File.ReadAllBytes(loaded[i].filePath);
                    loaded[i].pWord = txtPassword.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ReloadFolderItems()
        {
            cLbFolder.Items.Clear();

            string[] files = Directory.GetFiles(FolderPath);

            //Add Files to checked list box
            foreach (string f in files)
            {
                cLbFolder.Items.Add(f);
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
            /*PrintPreviewDialog dialog = new PrintPreviewDialog();

            foreach (var file in loaded)
            {
                dialog.Document = new PrintPreviewDialog();
                dialog.Document.DocumentName = file.filePath;
                dialog.ShowDialog();
            }*/
            try
            {

                int index = 0;

                if (LbLoadedFiles.CheckedItems.Count > 1)
                {
                    throw new Exception("Cannot preview more than 1 file at a time");
                }

                for (int i = 0; i < loaded.Count(); i++)
                {
                    if (loaded[i].fileName == LbLoadedFiles.CheckedItems[0].ToString())
                        index = i;
                }

                if (Path.GetExtension(loaded[index].filePath) == ".jpg" || Path.GetExtension(loaded[index].filePath) == ".png")
                {
                    PreviewImage preview = new PreviewImage(loaded[index]);

                    preview.Show();
                }
                else if (Path.GetExtension(loaded[index].filePath) == ".txt")
                {
                    Preview preview = new Preview(loaded[index]);

                    preview.Show();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int index = -1;
            try
            {
                if (LbLoadedFiles.CheckedItems.Count != 1)
                    throw new Exception("Only one item can be selected at a time");

                foreach (string s in LbLoadedFiles.CheckedItems)
                {
                    for (int i = 0; i < loaded.Count(); i++)
                    {
                        if (loaded[i].fileName == s)
                            index = i;
                    }

                    loaded[index].ProgressStart(0);
                    ReloadFolderItems();
                    //MessageBox.Show(loaded[index].bytes.Length.ToString());
                    //loaded[index].GenerateKey();
                    //MessageBox.Show(BitConverter.ToString(loaded[index].key));
                    /*
                    Progress p = new Progress();
                    p.Show();
                    loaded[index].EncryptBlock();
                    loaded[index].EncryptAES();
                    */
                    //loaded[index].WriteFiles(1);


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //int index = -1;
            try
            {
                foreach (string s in LbLoadedFiles.CheckedItems)
                {
                    int index = -1;
                    for (int i = 0; i < loaded.Count(); i++)
                    {
                        if (loaded[i].fileName == s)
                            index = i;
                    }

                    loaded[index].ProgressStart(1);
                    ReloadFolderItems();
                    /*
                    Progress p = new Progress();
                    p.Show();
                    if (loaded[index].fileName.Contains("AES"))
                    {
                        loaded[index].DecryptAES();
                    }
                    else
                    {
                        //MessageBox.Show(loaded[index].bytes.Length.ToString());
                        //loaded[index].GetKey();
                        //InsertKey ik = new InsertKey();
                        //ik.ShowDialog();
                        //MessageBox.Show("Waited");

                        //loaded[index].key = ik.key;
                        //MessageBox.Show(BitConverter.ToString(loaded[index].key));

                        //MessageBox.Show(BitConverter.ToString(loaded[index].key));
                        loaded[index].DecryptBlock();
                        //loaded[index].WriteFiles(0);
                    }*/
                    //loaded[index].DecryptAES();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Progress P = new Progress();

            P.ShowDialog();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            try
            {
                if (FolderPath == null)
                    throw new Exception("Must have root foldeer selected. Press \"Source Folder\" and try again.");
                Stats S = new Stats();
                S.folder = FolderPath;
                S.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
