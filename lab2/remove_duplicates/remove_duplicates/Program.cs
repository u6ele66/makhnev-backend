using System;
using System.Linq;
using System.Collections.Generic;

namespace remove_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments!");
                Console.WriteLine("Usage remove_duplicates.exe <input string>");
            }

            else
            {
                string str = args[0];
                Console.WriteLine(str.Distinct().ToArray());
            }
        }
    }
}
