using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordRemuve = Console.ReadLine();
            string word = Console.ReadLine();
            int indexOf=word.IndexOf(wordRemuve);
            while (indexOf!=-1)
            {
               word= word.Remove(indexOf, wordRemuve.Length);
                indexOf = word.IndexOf(wordRemuve);
            }
            Console.WriteLine(word);
        }
    }
}
