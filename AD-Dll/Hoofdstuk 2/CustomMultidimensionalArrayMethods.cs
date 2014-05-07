using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    /// <summary>
    /// Mark Roelans
    /// Methodes die gebruik maken van multidimensionale arrays.
    /// </summary>
    public class CustomMultidimensionalArrayMethods
    {
        /// <summary>
        /// Berekend per rij het gemiddelde en print dat.
        /// </summary>
        /// <param name="arrayWithNumbers">De array waarvan de gemiddelden moeten worden berekend.</param>
        public static void calculateAndPrintAverages(int[,] arrayWithNumbers)
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

        /// <summary>
        /// Berekend per rij het gemiddelde en print dat.
        /// </summary>
        /// <param name="arrayWithNumbers">De array waarvan de gemiddelden moeten worden berekend.</param>
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

        /// <summary>
        /// Print een tweedimensionale array.
        /// </summary>
        /// <typeparam name="T">Het type gegevens dat is opgeslagen in de tweedimensionale array.</typeparam>
        /// <param name="array">De tweedimensionale array die geprint moet worden.</param>
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

        /// <summary>
        /// Print een tweedimensionale array waarbij de verschillende items worden gescheiden door spaties.
        /// </summary>
        /// <typeparam name="T">Het type gegevens dat is opgeslagen in de tweedimensionale array.</typeparam>
        /// <param name="array">De tweedimensionale array die geprint moet worden.</param>
        public static void print2DArrayWithSpaces<T>(T[,] array)
        {
            for (int row = 0, lengthRow = array.GetLength(0); row < lengthRow; row++)
            {
                for (int column = 0, lengthColumn = array.GetLength(1); column < lengthColumn; column++)
                {
                    if (array[row, column] == null)
                    {
                        Console.WriteLine("null");
                    }
                    else
                    {
                        Console.Write(array[row, column].ToString());
                    }

                    if ((column + 1) != lengthColumn)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
