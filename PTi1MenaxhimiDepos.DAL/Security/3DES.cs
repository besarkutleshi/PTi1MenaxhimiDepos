using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PTi1MenaxhimiDepos.DAL.Security
{
    public static class _3DES
    {
        static string hash = "adwasdwasdwasf";
        static string vleraencrypt = "";
        static string vleradecrypt = "";
        public static string Encryptt(string data)
        {
            byte[] datae = UTF8Encoding.UTF8.GetBytes(data);
            using (MD5CryptoServiceProvider mDS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mDS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transfrom = tripleDES.CreateEncryptor();
                    byte[] results = transfrom.TransformFinalBlock(datae, 0, datae.Length);
                    vleraencrypt = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return vleraencrypt;
        }

        public static string Decrypt(string data)
        {
            byte[] datae = Convert.FromBase64String(data);
            using (MD5CryptoServiceProvider mDS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mDS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transfrom = tripleDES.CreateDecryptor();
                    byte[] results = transfrom.TransformFinalBlock(datae, 0, datae.Length);
                    vleradecrypt = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return vleradecrypt;
        }
    }
}
