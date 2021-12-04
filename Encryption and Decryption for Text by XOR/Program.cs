using System;

namespace Encryption_and_Decryption_for_Text_by_XOR
{
    class Program
    {
        public static string XORCipher(string text, string key)
        {
            int dataLen = text.Length;
            int keyLen = key.Length;
            char[] output = new char[dataLen];

            for (int i = 0; i < dataLen; ++i)
            {
                output[i] = (char)(text[i] ^ key[i % keyLen]);
            }

            return new string(output);
        }





        static void Main(string[] args)
        {

            string cipherText = XORCipher("Hello World", "1234");
            string plainText = XORCipher(cipherText, "1234");

            Console.WriteLine(cipherText);
            Console.WriteLine(plainText);

            Console.ReadKey();
        }
    }
}
