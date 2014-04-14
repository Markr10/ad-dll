using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_7
{
    public class CustomStringBuilderMethods
    {
        public static void PrintInfo(StringBuilder stBuff, string name)
        {
            Console.WriteLine("Length of {0}: {1}", name, stBuff.Length);
            Console.WriteLine("Capacity of {0}: {1}", name, stBuff.Capacity);
            Console.WriteLine("Maximum capacity of {0}: {1}", name, stBuff.MaxCapacity);
            Console.WriteLine("Text of {0}: {1}", name, stBuff);
            Console.WriteLine();
        }
    }
}