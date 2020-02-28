using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Encryptor
{
    public class LoadedFiles
    {
        //List of Loaded Files
        //public List<LoadedFiles> loaded = new List<LoadedFiles>();

        public string fileName;
        public string filePath;
        public string fileExt;
        public byte[] bytes;
        public byte[] encBytes;
        public byte[] decBytes;
        public byte[] key;

        public void normalizeFiles()
        {
            fileExt = Path.GetExtension(filePath);
            string[] splitPath = filePath.Split('\\');
            filePath = "";
            
            for(int i=0; i < splitPath.Length -1 ; i++)
            {
                filePath = filePath + splitPath[i] + "\\";
            }
            string[] splis = fileName.Split('.');
            fileName = splis[0];
            //MessageBox.Show(filePath);
        }
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        public void EncryptBlock()
        {
            int i = 0;
            byte[] buffer = new byte[4];

            while (i < bytes.Length)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != bytes.Length)
                    {
                        buffer[j] = bytes[i];
                        var b = buffer[j] << 1;
                        encBytes[i] = (byte)(buffer[j] + key[j]);
                        i++;
                    }
                }
            }
        }

        public void EncryptAES()
        {

            normalizeFiles();

            byte[] salt = GenerateRandomSalt();

            FileStream fileCrypt = new FileStream(filePath + fileName + "AES" + fileExt, FileMode.Create);

            byte[] passBytes = System.Text.Encoding.UTF8.GetBytes("Password");

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            AES.Mode = CipherMode.CFB;

            // write salt to the begining of the output file, so in this case can be random every time
            fileCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fileCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(filePath + fileName + fileExt, FileMode.Open);

            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents(); // -> for responsive GUI, using Task will be better!
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fileCrypt.Close();
            }
        }

        public void DecryptBlock()
        {
            int i = 0;
            byte[] buffer = new byte[4];

            while (i < bytes.Length)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != bytes.Length)
                    {
                        buffer[j] = bytes[i];
                        var b = buffer[j] << 1;
                        decBytes[i] = (byte)(buffer[j] - key[j]);
                        i++;
                    }
                }
            }
        }
        public void GenerateKey()
        {
            key = new byte[4];
            Random rand = new Random();
            for(int i = 0; i < 4; i++)
            {
                
                
                int bit = rand.Next(0,255);

                key[i] = Convert.ToByte(bit);
            }
        }
        /*public bool GetKey()
        {
            InsertKey ik = new InsertKey();
            ik.Show();
            
         
        }*/
        public void WriteFiles(int n)
        {
            normalizeFiles();

            if (n == 1)
                File.WriteAllBytes(filePath + fileName + "Encrypted" + fileExt, encBytes);
            else if(n == 0)
                File.WriteAllBytes(filePath + fileName + "Decrypted" + fileExt, decBytes);
        }
    }
}
