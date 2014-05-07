using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    /// <summary>
    /// Mark Roelans
    /// Methodes die gebruik maken van jagged arrays.
    /// </summary>
    public class CustomJaggedArrayMethods
    {
        /// <summary>
        /// Print een jagged array naar de console.
        /// </summary>
        /// <typeparam name="T">Het type gegevens dat is opgeslagen in de jagged array.</typeparam>
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

        /// <summary>
        /// Returned een String die uit minimaal twee cijfers bestaat.
        /// </summary>
        /// <param name="value">Het positieve getal dat moet worden omgezet.</param>
        /// <returns>Een String die uit minimaal twee cijfers bestaat.</returns>
        private static string getNumberWithLeadingZero(int value)
        {
            if (value < 10)
            {
                return "0" + value.ToString();
            }
            return value.ToString();
        }

        /// <summary>
        /// Returned de grootste kolom lengte van de jagged array.
        /// </summary>
        /// <typeparam name="T">Het type gegevens dat is opgeslagen in de jagged array.</typeparam>
        /// <param name="array">De jagged array waarvan de grootste kolom lengte moet worden bepaald.</param>
        /// <returns>De grootste kolom lengte van de jagged array.</returns>
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
            if (cellMinValue > cellMaxValue)
            {
                throw new ArgumentOutOfRangeException("cellMinValue", "cellMinValue moet kleiner zijn dan of gelijk zijn aan cellMaxValue.");
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
    }
}
