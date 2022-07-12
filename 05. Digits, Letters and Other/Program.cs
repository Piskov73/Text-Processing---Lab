using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            ////char[] numb=text.Where(x=>char.IsDigit(x)).ToArray();
            ////char[] leters=text.Where(x=>char.IsLetter(x)).ToArray();
            ////char[] other = text.Where(x => !char.IsDigit(x) && !char.IsLetter(x)).ToArray();
            ////Console.WriteLine(new String(numb));
            ////Console.WriteLine(new String(leters));
            ////Console.WriteLine(new String(other));
            StringBuilder digits = new StringBuilder();
            StringBuilder leters = new StringBuilder();
            StringBuilder other = new StringBuilder();
            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    digits.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    leters.Append(item);
                }
                else
                {
                    other.Append(item);
                }
               
                    
             
            }
            Console.WriteLine(digits);
            Console.WriteLine(leters);
            Console.WriteLine(other);

        }
    }
}
