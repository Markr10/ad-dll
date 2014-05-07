using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    public class CustomMethods
    {
        #region Custom Parameter Array Methods

        public static int sumNums(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        public static void sumNumsAndPrint(params int[] nums)
        {
            Console.Write("The sum of ");
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if ((i + 1) != nums.Length)
                {
                    Console.Write(", ");
                }

                sum += nums[i];
            }
            Console.WriteLine(" is: " + sum.ToString());
        }

        #endregion

        #region Custom Jagged Array Methods

        /// <summary>
        /// Print een jagged array naar de console.
        /// </summary>
        /// <typeparam name="T">Het type gegevens die zijn opgeslagen in de jagged array.</typeparam>
        /// <param name="array">De jagged array die moet worden uitgeprint.</param>
        /// <remarks>
        /// Om de opmaak te behouden mag de index van de rijen niet groter worden als 99.
        /// Tevens mag de index van kolommen niet groter worden als 9.
        /// Bovendien wordt er vanuit gegaan dat de (gehele) jagged array gevuld is.
        /// </remarks>
        public static void printJaggedArray<T>(T[][] array)
        {
            Console.Write("    ");
            for (int i = 0, length = getMaxColumnLengthJaggedArray<T>(array); i < length; i++)
            {
                Console.Write("[0" + i.ToString() + "]");
            }
            Console.WriteLine();

            for (int row = 0, lengthRow = array.Length; row < lengthRow; row++)
            {
                Console.Write("[" + getNumberWithLeadingZero(row) + "] ");
                for (int column = 0, lengthColumn = array[row].Length; column < lengthColumn; column++)
                {
                    if (array[row][column] == null)
                    {
                        Console.Write("null");
                    }
                    else
                    {
                        Console.Write(array[row][column].ToString());
                    }

                    if ((column + 1) < lengthColumn)
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static string getNumberWithLeadingZero(int value)
        {
            if (value < 10)
            {
                return "0" + value.ToString();
            }
            return value.ToString();
        }

        public static int getMaxColumnLengthJaggedArray<T>(T[][] array)
        {
            int maxLength = 0;
            for (int row = 0, lengthRow = array.Length; row < lengthRow; row++)
            {
                if (array[row].Length > maxLength)
                {
                    maxLength = array[row].Length;
                }
            }
            return maxLength;
        }

        /// <summary>
        /// Hiermee worden bepaalde rijen van een jagged array gevuld met willekeurige getallen.
        /// </summary>
        /// <param name="jaggedArray">De jagged array waarvan de rijen moeten worden gevuld.</param>
        /// <param name="index">De index van de rij waarmee moet worden begonnen bij het vullen.</param>
        /// <param name="maxIndex">De index van de rij die niet meer gevuld hoeft te worden.</param>
        /// <param name="cellMinValue">De inclusieve ondergrens van het willekeurig getal voor de gevulde cel.</param>
        /// <param name="cellMaxValue">De exclusieve bovengrens van het willekeurig getal voor de gevulde cel.</param>
        /// <param name="rowColumnMinValue">De inclusieve ondergrens van het willekeurig getal voor het aantal kolommen van een rij.</param>
        /// <param name="rowColumnMaxValue">De exclusieve bovengrens van het willekeurig getal voor het aantal kolommen van een rij.</param>
        /// <returns>De jagged array met gevulde rijen.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="cellMinValue"/> moet kleiner zijn dan of gelijk zijn aan <paramref name="cellMaxValue"/>.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="rowColumnMinValue"/> moet kleiner zijn dan of gelijk zijn aan <paramref name="rowColumnMaxValue"/>.</exception>
        public static int[][] fillJaggedArrayRows(int[][] jaggedArray, int index, int maxIndex, int cellMinValue, int cellMaxValue, int rowColumnMinValue, int rowColumnMaxValue)
        {
            if(cellMinValue > cellMaxValue)
            {
                throw new ArgumentOutOfRangeException("cellMinValue","cellMinValue moet kleiner zijn dan of gelijk zijn aan cellMaxValue.");
            }
            if (rowColumnMinValue > rowColumnMaxValue)
            {
                throw new ArgumentOutOfRangeException("rowColumnMinValue", "rowColumnMinValue moet kleiner zijn dan of gelijk zijn aan rowColumnMaxValue.");
            }

            for (; index < maxIndex; index++)
            {
                if (jaggedArray[index] == null)
                {
                    jaggedArray[index] = new int[Other.rndObj.Next(rowColumnMinValue, rowColumnMaxValue)];
                }

                for (int column = 0, lengthColumn = jaggedArray[index].Length; column < lengthColumn; column++)
                {
                    jaggedArray[index][column] = Other.rndObj.Next(cellMinValue, cellMaxValue);
                }
            }
            return jaggedArray;
        }

        /// <summary>
        /// Berekend de gemiddelden van elke rij en print deze naar de console.
        /// </summary>
        /// <param name="arrayWithNumbers">De jagged array die gebruikt moet worden voor het berekenen van de gemiddelden.</param>
        /// <param name="averageForText">De tekst die aangeeft waarvan de gemiddelden zijn. De tekst
        /// wordt in een zin geprint naar de console.</param>
        /// <param name="digits">Het aantal decimalen dat wordt getoond wanneer het gemiddelde wordt geprint.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="digits"/> moet groter zijn dan 0 en kleiner zijn dan 28.</exception>
        public static void calculateAndPrintAverages(int[][] arrayWithNumbers, string averageForText, int digits)
        {
            if (digits < 0 && digits > 28)
            {
                throw new ArgumentOutOfRangeException("digits", "digits moet groter zijn dan 0 en kleiner zijn dan 28.");
            }

            int lengthColumn = 0;
            double total;

            for (int row = 0, lengthRow = arrayWithNumbers.Length; row < lengthRow; row++)
            {
                total = 0;
                lengthColumn = arrayWithNumbers[row].Length;
                for (int column = 0; column < lengthColumn; column++)
                {
                    total += arrayWithNumbers[row][column];
                }
                Console.WriteLine("Average " + averageForText + " " + row + " is: " + Math.Round((total / lengthColumn), digits));
            }
        }

        #endregion

        #region Custom ArrayList Methods

        /// <summary>
        /// Berekend de gemiddelden van alle cijfers in de ArrayList en print deze naar de console.
        /// </summary>
        /// <param name="arrayWithNumbers">De ArrayList die gebruikt moet worden voor het berekenen van de gemiddelden.</param>
        /// <param name="averageForText">De tekst die aangeeft wat voor gemiddelde uitgerekend wordt. De tekst
        /// wordt in een zin geprint naar de console.</param>
        /// <param name="digits">Het aantal decimalen dat wordt getoond wanneer het gemiddelde wordt geprint.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="digits"/> moet groter zijn dan 0 en kleiner zijn dan 28.</exception>
        public static void calculateAndPrintAverages(ArrayList arrayWithNumbers, string averageForText, int digits)
        {
            if (digits < 0 && digits > 28)
            {
                throw new ArgumentOutOfRangeException("digits", "digits moet groter zijn dan 0 en kleiner zijn dan 28.");
            }

            double total = total = 0;
            
            foreach (Object grade in arrayWithNumbers)
	        {
		        total += (int)grade;
	        }

            Console.WriteLine("The average " + averageForText + " is: " + Math.Round((total / arrayWithNumbers.Count), digits));
        }

        public static void removeAndPrint(ArrayList arrayList, Object item)
        {
            if (arrayList.Contains(item))
            {
                arrayList.Remove(item);
                Console.WriteLine(item.ToString() + " is removed from the ArrayList.");
            }
            else
            {
                Console.WriteLine(item.ToString() + " is not in the ArrayList.");
            }
        }

        public static void removeAtAndPrint(ArrayList arrayList, Object item)
        {
            int pos = arrayList.IndexOf(item);
            if(pos != -1)
            {
                arrayList.RemoveAt(pos);
                Console.WriteLine(item.ToString() + " is removed from the ArrayList.");
            }
            else
            {
                Console.WriteLine(item.ToString() + " is not in the ArrayList.");
            }
        }

        public static void removeAtAndPrint(ArrayList arrayList, int index)
        {
            if (index >= 0 && index < arrayList.Count)
            {
                arrayList.RemoveAt(index);
                Console.WriteLine("The item at index " + index + " is removed from the ArrayList.");
            }
            else
            {
                Console.WriteLine("Index " + index.ToString() + " does not exist in the ArrayList.");
            }
        }

        public static void printArrayList(ArrayList arrayList, string firstLine)
        {
            Console.WriteLine(firstLine);
            foreach (Object item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region Generics methods with Arrays from Chapter 7

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

        public static void printArray<T>(T[] array, string firstLine, string stringForEachItem)
        {
            Console.WriteLine(firstLine);
            foreach (object item in array)
            {
                Console.WriteLine(stringForEachItem + ": " + item.ToString());
            }
        }

        #endregion
    }
}
