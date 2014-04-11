using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    public class CustomMethods
    {
        #region Custom Array Methods

        /// <summary>
        /// Print een zin naar de console waarin staat of het type van een item een array type is en
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

        /// <summary>
        /// Print informatie over de gegeven array naar de console.
        /// </summary>
        /// <param name="array">De array die gebruikt wordt bij
        /// het bepalen van de benodigde gegevens.</param>
        /// <param name="nameOfArray">De naam van de array die gebruikt moet worden in
        /// de teksten die worden geprint.</param>
        public static void printInfoAboutArray(Array array, string nameOfArray)
        {
            Console.WriteLine(nameOfArray + ":");
            printIsArrayTypeAndType(array.GetType());
            Console.WriteLine("The total number of elements in all dimensions of the " + nameOfArray + " is " + array.Length.ToString() + ".");
            printArrayDimensions(array, nameOfArray);
        }

        /// <summary>
        /// Print informatie over de array dimensies naar de console.
        /// </summary>
        /// <param name="array">De array die gebruikt wordt bij
        /// het bepalen van de benodigde gegevens.</param>
        /// <param name="nameOfArray">De naam van de array die gebruikt moet worden in
        /// de teksten die worden geprint.</param>
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

        #endregion

        #region Custom Multidimensional Array Methods

        public static void calculateAndPrintAverages(int[,] arrayWithNumbers)
        {
            int lengthColumn = arrayWithNumbers.GetLength(1);
            long total;
            for (int row = 0, lengthRow = arrayWithNumbers.GetLength(0); row < lengthRow; row++)
            {
                total = 0;
                for (int column = 0; column < lengthColumn; column++)
                {
                    total += arrayWithNumbers[row, column];
                }
                Console.WriteLine("Average of row " + row + " is: " + (total / lengthColumn));
            }
        }

        public static void calculateAndPrintAverages(double[,] arrayWithNumbers)
        {
            int lengthColumn = arrayWithNumbers.GetLength(1);
            double total;

            for (int row = 0, lengthRow = arrayWithNumbers.GetLength(0); row < lengthRow; row++)
            {
                total = 0;
                for (int column = 0; column < lengthColumn; column++)
                {
                    total += arrayWithNumbers[row, column];
                }
                Console.WriteLine("Average of row " + row + " is: " + (total / lengthColumn));
            }
        }

        public static void print2DArray<T>(T[,] array)
        {
            for (int row = 0, lengthRow = array.GetLength(0); row < lengthRow; row++)
            {
                for (int column = 0, lengthColumn = array.GetLength(1); column < lengthColumn; column++)
                {
                    Console.Write("[" + row.ToString() + "," + column.ToString() + "]: ");
                    if (array[row, column] == null)
                    {
                        Console.WriteLine("null");
                    }
                    else
                    {
                        Console.WriteLine(array[row, column].ToString());
                    }
                }
            }
        }

        #endregion
    }
}
