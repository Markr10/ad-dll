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

        private static String getNumberWithLeadingZero(int value)
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
    }
}
