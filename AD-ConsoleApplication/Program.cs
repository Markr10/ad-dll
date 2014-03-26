using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Hello User, type\n" +
                    " 1 for SimpleHash\n" +
                    " 2 for BetterHash\n" +
                    " 3 for CorruptHash\n" +
                    " exit for Exit.");
                switch(Console.ReadLine().ToLower())
                {
                    case "1":
                    {
                        new Hash().printHashTableSimpleHash();
                        break;
                    }
                    case "2":
                    {
                        new Hash().printHashTableBetterHash();
                        break;
                    }
                    case "3":
                    {
                        new Hash().printHashTableCorruptHash();
                        break;
                    }
                    case "exit":
                    {
                        exit = true;
                        break;
                    }
            }
            }
        }
    }
}
