using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HIMS_Project.BLL
{
    class CryptoLab_BLL
    {
        private const string mysecurityKey = "aPdRgUkX";

        public string EncryptText(string EncryptPw)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                TripleDESCryptoServiceProvider tDCP = new TripleDESCryptoServiceProvider();

                byte[] myEncryptArray = utf8.GetBytes(EncryptPw);

                byte[] myEncryptKay = md5.ComputeHash(utf8.GetBytes(mysecurityKey));

                tDCP.Key = myEncryptKay;
                tDCP.Mode = CipherMode.ECB;
                tDCP.Padding = PaddingMode.PKCS7;

                var MyCrytpoTransform = tDCP.CreateEncryptor();

                byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(myEncryptArray, 0, myEncryptArray.Length);

                return Convert.ToBase64String(MyresultArray, 0, MyresultArray.Length);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string DecryptText(string DecryptPw)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                TripleDESCryptoServiceProvider tDCP = new TripleDESCryptoServiceProvider();

                byte[] myDecryptArray = Convert.FromBase64String(DecryptPw);

                byte[] myEncryptKay = md5.ComputeHash(utf8.GetBytes(mysecurityKey));

                tDCP.Key = myEncryptKay;
                tDCP.Mode = CipherMode.ECB;
                tDCP.Padding = PaddingMode.PKCS7;

                var MyCrytpoTransform = tDCP.CreateDecryptor();

                byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(myDecryptArray, 0, myDecryptArray.Length);

                tDCP.Clear();

                return UTF8Encoding.UTF8.GetString(MyresultArray);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
