using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    public class CustomArrayMethods
    {
        /// <summary>
        /// Print naar de console een zin waarin staat of het type van een item een array type is en
        /// van welk type het item precies is.
        /// </summary>
        /// <param name="typeOfItem">Het type van een item.</param>
        public static void printIsArrayTypeAndType(Type typeOfItem)
        {
            if (typeOfItem.IsArray)
            {
                Console.Write("The array type is: ");
            }
            else
            {
                Console.Write("The item is not an array type. The item is of the type: ");
            }
            Console.WriteLine(typeOfItem.ToString() + ".");
        }
    }
}
