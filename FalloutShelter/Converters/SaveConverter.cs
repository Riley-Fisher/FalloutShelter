using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FalloutShelter.Converters {
    internal class SaveConverter {
        private static readonly byte[] RgbIv = Encoding.ASCII.GetBytes("tu89geji340t89u2");
        private static readonly byte[] _rgbKey = new Rfc2898DeriveBytes("UGxheWVy", RgbIv).GetBytes(32);

        public static string Encrypt(string text) {
            byte[] encrypted;
            using (var aesAlg = new AesCryptoServiceProvider {
                Key = _rgbKey,
                IV = RgbIv,
                Mode = CipherMode.CBC
            }) {
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (var msEncrypt = new MemoryStream()) {
                    using (var csEncrypt =
                        new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) {
                        using (var swEncrypt = new StreamWriter(csEncrypt)) {
                            swEncrypt.Write(text);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(byte[] cipherText) {
            string plaintext = null;
            using (var aesAlg = new AesCryptoServiceProvider {
                Key = _rgbKey,
                IV = RgbIv,
                Mode = CipherMode.CBC
            }) {
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (
                    var msDecrypt = new MemoryStream(Convert.FromBase64String(Encoding.ASCII.GetString(cipherText)))) {
                    using (var csDecrypt =
                        new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
                        using (var srDecrypt = new StreamReader(csDecrypt)) {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}