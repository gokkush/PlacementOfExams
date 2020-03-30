using DevExpress.Utils.Extensions;
using DPU_Soft.DAL.Base;
using DPU_Soft.DAL.Interfaces;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace DPU_Soft.BLL.Functions
{
    public static class GeneralFunctions
    {
        public static List<string> DegisenAlanalariGetir<T>(this T oldEntity, T currentEntity)
        {
            List<string> alanlar = new List<string>();
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity)??string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType==typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString())) oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentValue.ToString())) currentValue = new byte[] { 0 };
                    if ((((byte[])oldValue).Length != (((byte[])currentValue).Length)))
                        {
                        alanlar.Add(prop.Name);
                        }                   
                }
                if (prop.PropertyType == typeof(SecureString))
                {
                    var oldStr = ((SecureString)oldValue).ConvertToUnSecureString();
                    var curStr= ((SecureString)currentValue).ConvertToUnSecureString();
                    if (!oldStr.Equals(curStr))
                        alanlar.Add(prop.Name);
                }
                else if (!currentValue.Equals(oldValue))
                {
                    alanlar.Add(prop.Name);
                }
            }
            return alanlar;
        }
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["PlacementOfExamsContext"].ConnectionString;
        }

        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        public static void CreateUnitOfWork<T,TContext>(ref IUnitOfWork<T> uof) where T:class,IBaseEntity where TContext: DbContext
        {
            uof?.Dispose();
            uof = new UnitOfWork<T>(CreateContext<TContext>());
        }

        public static SecureString ConvertToSecureString(this string value)
        {
            var secureString = new SecureString();
            if (value.Length > 0)
                value.ToCharArray().ForEach(x => secureString.AppendChar(x));
            secureString.MakeReadOnly();


            return secureString;
        }

        public static string ConvertToUnSecureString(this SecureString value)
        {
            var result = Marshal.SecureStringToBSTR(value);
            return Marshal.PtrToStringAuto(result);
        }

        public static string Encrypt(this string sifrelenecekVeri, string anahtar)
        {
            if (sifrelenecekVeri == null) return null;
            var sifrelenecekVeriToByte = Encoding.UTF8.GetBytes(sifrelenecekVeri);
            var anahtarToByte = Encoding.UTF8.GetBytes(anahtar);

            anahtarToByte = SHA256.Create().ComputeHash(anahtarToByte);

            byte[] sifreliVeri = null;

            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(anahtarToByte, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(sifrelenecekVeriToByte, 0, sifrelenecekVeriToByte.Length);
                        cs.Close();
                    }

                    sifreliVeri = ms.ToArray();
                }
            }

            return Convert.ToBase64String(sifreliVeri);
        }

        public static string Decrypt(this string sifresiCozulecekVeri, string anahtar)
        {
            if (sifresiCozulecekVeri == null) return null;
            var sifresiCozulecekVeriToByte = Convert.FromBase64String(sifresiCozulecekVeri);
            var anahtarToByte = Encoding.UTF8.GetBytes(anahtar);

            anahtarToByte = SHA256.Create().ComputeHash(anahtarToByte);

            byte[] sifresiCozulmusVeri;
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(anahtarToByte, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(sifresiCozulecekVeriToByte, 0, sifresiCozulecekVeriToByte.Length);
                        cs.Close();
                    }

                    sifresiCozulmusVeri = ms.ToArray();
                }
            }

            return Encoding.UTF8.GetString(sifresiCozulmusVeri);
        }
    }
}
