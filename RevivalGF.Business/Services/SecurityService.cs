using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Business.Services
{
    public class SecurityService
    {
        private string defaulthPassword = "1";

        private byte[] Encrypt(byte[] data, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms,

            alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(data, 0, data.Length);
            cs.Close();

            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

        private byte[] Decrypt(byte[] encryptedData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(encryptedData, 0, encryptedData.Length);
            cs.Close();

            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }

        public string TextEncrypt(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(defaulthPassword, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] encryptedData = Encrypt(data,

            pdb.GetBytes(32), pdb.GetBytes(16));

            return Convert.ToBase64String(encryptedData);
        }

        public string TextDecrypt(string encryptedPassword)
        {
            encryptedPassword = encryptedPassword.Replace(" ", "+");

            int mod4 = encryptedPassword.Length % 4;
            if (mod4 > 0)
            {
                encryptedPassword += new string('=', 4 - mod4);
            }
            byte[] encryptedData = Convert.FromBase64String(encryptedPassword);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(defaulthPassword, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] password = Decrypt(encryptedData,pdb.GetBytes(32), pdb.GetBytes(16));

            return Encoding.UTF8.GetString(password);
        }

        public string PasswordWithSha256(string text)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            byte[] bytes = sha256Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }        
    }
    
}

