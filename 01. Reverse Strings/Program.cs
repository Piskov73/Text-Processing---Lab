using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word=Console.ReadLine();
            while (word!="end")
            {
                string revers = string.Empty;
                int lenghtWord=word.Length;
                for (int i = lenghtWord-1; i >= 0; i--)
                {
                    revers += word[i];
                }
                Console.WriteLine($"{word} = {revers}");

                
                word = Console.ReadLine();
            }
        }
    }
}
