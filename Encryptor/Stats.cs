using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Encryptor
{
    public partial class Stats : Form
    {
        public string folder;
        public double avgAESe = 0;
        public double avgBlocke = 0;
        public double avgAESd = 0;
        public double avgBlockd = 0;
        public int AESeCount = 0;
        public int AESdCount = 0;
        public int BlockeCount = 0;
        public int BlockdCount = 0;

        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(folder + "\\Stats\\Stats.txt");
            //MessageBox.Show(lines[0]);
            
            foreach(string s in lines)
            {
                if(s.Contains("AES"))
                {
                    if(s.Contains("Encryption"))
                    {
                        AESeCount++;
                        string num = Regex.Match(s, @"\d+").Value;
                        //MessageBox.Show(num);
                        avgAESe += int.Parse(num);
                    }
                    else
                    {
                        AESdCount++;
                        string num = Regex.Match(s, @"\d+").Value;
                        avgAESd += int.Parse(num);
                    }
                }
                else
                {
                    if (s.Contains("Encryption"))
                    {
                        BlockeCount++;
                        string num = Regex.Match(s, @"\d+").Value;
                        avgBlocke += int.Parse(num);
                    }
                    else
                    {
                        BlockdCount++;
                        string num = Regex.Match(s, @"\d+").Value;
                        avgBlockd += int.Parse(num);
                    }
                }
            }

            avgAESd = avgAESd / AESdCount;
            avgAESe = avgAESe / AESeCount;
            avgBlockd = avgBlockd / BlockdCount;
            avgBlocke = avgBlocke / BlockeCount;

            cStat.Series["AES"].Points.AddXY("Encryption", avgAESe);
            cStat.Series["Block"].Points.AddXY("Encryption", avgBlocke);
            cStat.Series["AES"].Points.AddXY("Decryption", avgAESd);
            cStat.Series["Block"].Points.AddXY("Decryption", avgBlockd);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(folder + "\\StatsReport.txt"))
            {
                File.Delete(folder + "\\StatsReport.txt");
            }
            File.Copy(folder + "\\Stats\\Stats.txt", folder + "\\StatsReport.txt");
            FileStream fs = new FileStream(folder + "\\StatsReport.txt", FileMode.Append);
            string Addition = "\n\n******************NEW STATS REPORT***********************************" +
                                "\nAVG AES   Encryption Time: " + avgAESe   + " ms Count: " + AESeCount   + 
                                "\nAVG Block Encryption Time: " + avgBlocke + " ms Count: " + BlockeCount +
                                "\nAVG AES   Decryption Time: " + avgAESd   + " ms Count: " + AESdCount   +
                                "\nAVG Block Decryption Time: " + avgBlockd + " ms Count: " + BlockdCount;
            byte[] addBytes = new UTF8Encoding(true).GetBytes(Addition);
            fs.Write(addBytes, 0, addBytes.Length);
            fs.Close();

            Process.Start(folder + "\\StatsReport.txt");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
