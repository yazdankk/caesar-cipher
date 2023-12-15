using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace caesar_cipher
{
    internal class Program
    {
        static void Main()
        {
            string ciphertext = "";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("\n C A E S A R   C I P H E R\n");
            Console.WriteLine("enter string");
            string input = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter a key:");
            int key = int.Parse(Console.ReadLine());
            for (int n = 0; n < input.Length; n++)
            {
                char word = input[n];
                int letterNum = (alphabet.IndexOf(word) + key) % alphabet.Length;
                char letter = alphabet[letterNum];
                ciphertext += letter;
            }
            Console.WriteLine(ciphertext);
        }
    }
}