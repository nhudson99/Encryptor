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
        public byte[] bSalt;

        public void normalizeFiles()
        {
            if(Path.GetExtension(filePath) == ".txt")
            {
                fileExt = ".txt";
            }
            //MessageBox.Show(filePath);
            //fileExt = Path.GetExtension(filePath);
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
            normalizeFiles();
            int i = 0;
            byte[] buffer = new byte[32];

            GenerateKey();
            //MessageBox.Show(key.Length.ToString());
            FileStream file = new FileStream(filePath + fileName + "Encrypted" + fileExt, FileMode.Create);
            file.Write(bSalt, 0, bSalt.Length);
            file.Close();
            
            try
            {
                while (i < bytes.Length)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        if (i != bytes.Length)
                        {
                            buffer[j] = bytes[i];
                          //  var b = buffer[j] << 1;
                            encBytes[i] = (byte)(buffer[j] + key[j]);
                            i++;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FileStream file2 = new FileStream(filePath + fileName + "Encrypted" + fileExt, FileMode.Append);
            //file2.Position = file.Length;
            file2.Write(encBytes, 0, encBytes.Length);
            file2.Close();
        }

        public void EncryptAES()
        {

            normalizeFiles();

            byte[] salt = GenerateRandomSalt();
            MessageBox.Show(BitConverter.ToString(salt));

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

        public void DecryptAES()
        {

            normalizeFiles();

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes("Password");
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(filePath + fileName + fileExt, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(filePath + fileName + "Decrypted" + fileExt, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }

        public void DecryptBlock()
        {
            normalizeFiles();

            int i = 0;
            byte[] buffer = new byte[32];
            byte[] salt = new byte[32];
            byte[] passBytes = System.Text.Encoding.UTF8.GetBytes("Password");
            //MessageBox.Show(filePath + fileName + fileExt);
            FileStream file = new FileStream(filePath + fileName + fileExt, FileMode.Open);
            file.Read(salt, 0, salt.Length);
            MessageBox.Show(BitConverter.ToString(salt));

            var key2 = new Rfc2898DeriveBytes(passBytes, salt, 50000);
            key = key2.GetBytes(32);

            while (i < bytes.Length)
            {
                for (int j = 0; j < 32; j++)
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
            fileName = fileName.Replace("Encrypted", "");
            File.WriteAllBytes(filePath + fileName + "Decrypted" + fileExt, decBytes);
        }
        public void GenerateKey()
        {
            key = new byte[32];
            /*Random rand = new Random();
            for(int i = 0; i < 4; i++)
            {
                
                
                int bit = rand.Next(0,255);

                key[i] = Convert.ToByte(bit);
            }*/

            byte[] salt = GenerateRandomSalt();
            byte[] passBytes = System.Text.Encoding.UTF8.GetBytes("Password");

            var key2 = new Rfc2898DeriveBytes(passBytes, salt, 50000);
            key = key2.GetBytes(32);
            bSalt = salt;
        }
        /*public bool GetKey()
        {
            InsertKey ik = new InsertKey();
            ik.Show();
            
         
        }*/
        public void WriteFiles(int n)
        {
            normalizeFiles();
            //MessageBox.Show(fileExt);

            if (n == 1)
            {
                FileStream file = new FileStream(filePath + fileName + "Encrypted" + fileExt, FileMode.Open);
                file.Write(encBytes, 0, encBytes.Length);
                file.Close();
            }
            else if (n == 0)
            {
                fileName = fileName.Replace("Encrypted", "");
                File.WriteAllBytes(filePath + fileName + "Decrypted" + fileExt, decBytes);
            }
        }
    }
}
