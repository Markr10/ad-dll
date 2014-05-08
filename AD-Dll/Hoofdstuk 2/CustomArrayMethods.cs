using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    /// <summary>
    /// Mark Roelans
    /// Methodes die gebruik maken van arrays
    /// </summary>
    public class CustomArrayMethods
    {
        /// <summary>
        /// Print een array.
        /// </summary>
        /// <typeparam name="T">Het type gegevens dat is opgeslagen in de array</typeparam>
        /// <param name="arrayToPrint">De array die geprint moet worden</param>
        /// <param name="firstLine">De tekst die geprint moet worden voordat de array mag worden geprint</param>
        public static void printArray<T>(T[] arrayToPrint, string firstLine)
        {
            Console.WriteLine(firstLine);
            for (int i = 0; i <= arrayToPrint.GetUpperBound(0); i++)
            {
                Console.Write(i.ToString() + ": ");
                if (arrayToPrint[i] != null)
                {
                    Console.WriteLine(arrayToPrint[i].ToString());
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
        }

        /// <summary>
        /// Print een array.
        /// </summary>
        /// <typeparam name="T">Het type gegevens dat is opgeslagen in de array</typeparam>
        /// <param name="array">De array die geprint moet worden</param>
        /// <param name="firstLine">De tekst die geprint moet worden voordat de array mag worden geprint</param>
        /// <param name="stringForEachItem">De tekst die voor elk item moet worden geprint</param>
        public static void printArray<T>(T[] array, string firstLine, string stringForEachItem)
        {
            Console.WriteLine(firstLine);
            foreach (object item in array)
            {
                Console.WriteLine(stringForEachItem + ": " + item.ToString());
            }
        }

        /// <summary>
        /// Print een zin naar de console waarin staat of het type van een item een array type is en
        /// van welk type het item precies is
        /// </summary>
        /// <param name="typeOfItem">Het type van een item</param>
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

        /// <summary>
        /// Print informatie over de gegeven array naar de console
        /// </summary>
        /// <param name="array">De array die gebruikt wordt bij
        /// het bepalen van de benodigde gegevens</param>
        /// <param name="nameOfArray">De naam van de array die gebruikt moet worden in
        /// de teksten die worden geprint</param>
        public static void printInfoAboutArray(Array array, string nameOfArray)
        {
            Console.WriteLine(nameOfArray + ":");
            printIsArrayTypeAndType(array.GetType());
            Console.WriteLine("The total number of elements in all dimensions of the " + nameOfArray + " is " + array.Length.ToString() + ".");
            printArrayDimensions(array, nameOfArray);
        }

        /// <summary>
        /// Print informatie over de array dimensies naar de console
        /// </summary>
        /// <param name="array">De array die gebruikt wordt bij
        /// het bepalen van de benodigde gegevens</param>
        /// <param name="nameOfArray">De naam van de array die gebruikt moet worden in
        /// de teksten die worden geprint</param>
        public static void printArrayDimensions(Array array, string nameOfArray)
        {
            if (array.Rank > 1)
            {
                Console.WriteLine("The " + nameOfArray + " has " + array.Rank + " dimensions.");
            }
            else
            {
                Console.WriteLine("The " + nameOfArray + " has " + array.Rank + " dimension.");
            }

            for (int i = 0; i < array.Rank; i++)
            {
                Console.WriteLine("The number of elements in the " + i.ToString() + " dimension of the " + nameOfArray + " is " + array.GetLength(i).ToString() + ".");
            }
        }
    }
}
