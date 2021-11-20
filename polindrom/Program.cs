using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                string str_replace = str.Replace(" ", "").ToLower();
                string str_1 = null;
                string str_2 = null;


                for (int i = 0; i < str_replace.Length; i++)
                {
                    str_1 += str_replace[i];
                }

                for (int i = str_replace.Length - 1; i != -1; i--)
                {
                    str_2 += str_replace[i];
                }

                if (str_1 == str_2)
                {
                    Console.WriteLine($"Строка ''{str}'' является полиндромом");
                }
                else
                {
                    Console.WriteLine($"Строка ''{str}'' не является полиндромом");
                }
            }
        }
    }
}
