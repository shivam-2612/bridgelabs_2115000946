using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class EncryptDecryptCSV
{
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567890123456");
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890123456");

    static string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] input = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = encryptor.TransformFinalBlock(input, 0, input.Length);
            return Convert.ToBase64String(encrypted);
        }
    }

    static string Decrypt(string cipherText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] input = Convert.FromBase64String(cipherText);
            byte[] decrypted = decryptor.TransformFinalBlock(input, 0, input.Length);
            return Encoding.UTF8.GetString(decrypted);
        }
    }

    static void Main()
    {
        string filePath = "sensitive_data.csv";
        string encryptedFile = "encrypted_data.csv";
        string decryptedFile = "decrypted_data.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                data[3] = Encrypt(data[3]);
                data[2] = Encrypt(data[2]);
                lines[i] = string.Join(",", data);
            }
            File.WriteAllLines(encryptedFile, lines);
        }

        if (File.Exists(encryptedFile))
        {
            string[] lines = File.ReadAllLines(encryptedFile);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                data[3] = Decrypt(data[3]);
                data[2] = Decrypt(data[2]);
                lines[i] = string.Join(",", data);
            }
            File.WriteAllLines(decryptedFile, lines);
        }
    }
}
