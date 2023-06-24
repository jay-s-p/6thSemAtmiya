/*
Write a C# program for delegate.
*/
using System;

namespace CaesarCipher
{
    delegate string CipherMethod(string plainText, int shift);

    class Cipher
    {
        private static string Encrypt(string plainText, int shift)
        {
            char[] chars = plainText.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                if (c >= 'a' && c <= 'z')
                {
                    c = (char)(((c - 'a') + shift) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(((c - 'A') + shift) % 26 + 'A');
                }

                chars[i] = c;
            }

            return new string(chars);
        }

        private static string Decrypt(string cipherText, int shift)
        {
            return Encrypt(cipherText, -shift);
        }

        static void Main(string[] args)
        {
            CipherMethod encryptMethod = new CipherMethod(Encrypt);

            CipherMethod decryptMethod = new CipherMethod(Decrypt);

            Console.Write("Enter your name : ");
            string plainText = Console.ReadLine();
            int key = 2;

            string cipherText = encryptMethod(plainText, key);
            Console.WriteLine($"Encryption of {plainText} is {cipherText}");

            string decryptedText = decryptMethod(cipherText, key);
            Console.WriteLine($"\nDecryption of {cipherText} is {decryptedText}");
        }
    }
}
