using System;
using System.Linq;
using System.Text;

namespace XBuilder.XCode
{
    internal class EncryptEngine
    {
        public static string StringEncryptor(string inputString, string xorKey)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);
            byte[] keyBytes = Encoding.UTF8.GetBytes(xorKey);
            byte[] outputBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                outputBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }
            return Convert.ToBase64String(outputBytes);
        }
        public static int GenerateRandomInt() { return new Random().Next(17, 27); }

        public static string GenerateRandomXorKey(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
