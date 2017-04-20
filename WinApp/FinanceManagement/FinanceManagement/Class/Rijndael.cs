using System.IO;
using System.Text;
using System.Security.Cryptography;
using System;

namespace Class
{

    /// <summary>
    /// Base64 の概要の説明です。
    /// </summary>
    public static class Base64
    {
        public static String Encode(String str)
        {
            return Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(str));
        }

        public static String Decode(String str)
        {
            return Encoding.GetEncoding("utf-8").GetString(Convert.FromBase64String(str));
        }
    }

    /// <summary>
    /// DES の概要の説明です。
    /// </summary>
    public static class DES
    {
        public const String DefaultKey = "password";

        /// <summary>
        /// 文字列を暗号化する
        /// </summary>
        /// <param name="str">暗号化する文字列</param>
        /// <param name="key">パスワード</param>
        /// <returns>暗号化された文字列</returns>
        public static String EncryptString(String str, String key)
        {
            Byte[] bytesIn = Encoding.UTF8.GetBytes(str);

            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                Byte[] bytesKey = Encoding.UTF8.GetBytes(key);

                des.Key = ResizeBytesArray(bytesKey, des.Key.Length);
                des.IV = ResizeBytesArray(bytesKey, des.IV.Length);

                using (MemoryStream msOut = new MemoryStream())
                using (ICryptoTransform desdecrypt = des.CreateEncryptor())
                using (CryptoStream cryptStreem = new CryptoStream(msOut, desdecrypt, CryptoStreamMode.Write))
                {
                    cryptStreem.Write(bytesIn, 0, bytesIn.Length);
                    cryptStreem.FlushFinalBlock();

                    return System.Convert.ToBase64String(msOut.ToArray());
                }
            }
        }

        /// <summary>
        /// 暗号化された文字列を復号化する
        /// </summary>
        /// <param name="str">暗号化された文字列</param>
        /// <param name="key">パスワード</param>
        /// <returns>復号化された文字列</returns>
        public static String DecryptString(String str, String key)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                Byte[] bytesKey = System.Text.Encoding.UTF8.GetBytes(key);

                des.Key = ResizeBytesArray(bytesKey, des.Key.Length);
                des.IV = ResizeBytesArray(bytesKey, des.IV.Length);

                Byte[] bytesIn = System.Convert.FromBase64String(str);

                using (MemoryStream msIn = new MemoryStream(bytesIn))
                using (ICryptoTransform desdecrypt = des.CreateDecryptor())
                using (CryptoStream cryptStreem = new CryptoStream(msIn, desdecrypt, CryptoStreamMode.Read))
                using (StreamReader srOut = new StreamReader(cryptStreem, Encoding.UTF8))
                {
                    return srOut.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 共有キー用に、バイト配列のサイズを変更する
        /// </summary>
        /// <param name="bytes">サイズを変更するバイト配列</param>
        /// <param name="newSize">バイト配列の新しい大きさ</param>
        /// <returns>サイズが変更されたバイト配列</returns>
        private static Byte[] ResizeBytesArray(Byte[] bytes, Int32 newSize)
        {
            Byte[] newBytes = new byte[newSize];
            if (bytes.Length <= newSize)
            {
                for (Int32 i = 0; i < bytes.Length; i++)
                    newBytes[i] = bytes[i];
            }
            else
            {
                Int32 pos = 0;
                for (Int32 i = 0; i < bytes.Length; i++)
                {
                    newBytes[pos++] ^= bytes[i];
                    if (pos >= newBytes.Length)
                        pos = 0;
                }
            }
            return newBytes;
        }
    }

    /// <summary>
    /// Rijndael の概要の説明です。
    /// </summary>
    public static class Rijndael
    {
        private const String DefaultPassPhrase = "Pas5pr@se";
        private const String DefaultSaltValue = "s@1tValue";
        private const String DefaultHashAlgorithm = "SHA1";
        private const Int32 DefaultPasswordIteations = 2;
        private const String DefaultInitialVector = "@1B2c3D4e5F6g7H8";
        private const Int32 DefaultKeySize = 256;

        /// <SUMMARY>
        /// 対象暗号鍵アルゴリズムで暗号化して返す
        /// </SUMMARY>
        /// <PARAM name="plainText">暗号化する文字列</PARAM>
        /// <RETURNS>暗号化された文字列</RETURNS>
        public static String Encrypt(String plainText)
        {
            Byte[] initVectorBytes = Encoding.ASCII.GetBytes(DefaultInitialVector);
            Byte[] saltValueBytes = Encoding.ASCII.GetBytes(DefaultSaltValue);

            Byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(DefaultPassPhrase, saltValueBytes, DefaultHashAlgorithm, DefaultPasswordIteations);

            Byte[] keyBytes = password.GetBytes(DefaultKeySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            cryptoStream.FlushFinalBlock();

            Byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            String cipherText = System.Convert.ToBase64String(cipherTextBytes);

            return cipherText;
        }

        /// <SUMMARY>
        /// 対象暗号鍵アルゴリズムで複合化して返す
        /// </SUMMARY>
        /// <PARAM name="cipherText">暗号化された文字列</PARAM>
        /// <RETURNS>複合化された文字列</RETURNS>
        public static String Decrypt(String cipherText)
        {
            Byte[] initVectorBytes = Encoding.ASCII.GetBytes(DefaultInitialVector);
            Byte[] saltValueBytes = Encoding.ASCII.GetBytes(DefaultSaltValue);

            Byte[] cipherTextBytes = System.Convert.FromBase64String(cipherText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(DefaultPassPhrase, saltValueBytes, DefaultHashAlgorithm, DefaultPasswordIteations);

            Byte[] keyBytes = password.GetBytes(DefaultKeySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            Byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            Int32 decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            memoryStream.Close();
            cryptoStream.Close();

            String plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

            return plainText;
        }
    }

}
