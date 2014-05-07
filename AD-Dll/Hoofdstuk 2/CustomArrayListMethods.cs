using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    /// <summary>
    /// Mark Roelans
    /// Zelfgemaakte methode(s) die gebruikt maken van ArrayList objecten.
    /// </summary>
    public class CustomArrayListMethods
    {
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

        /// <summary>
        /// Verwijderd een item uit de ArrayList met de Remove methode en print hierover informatie.
        /// </summary>
        /// <param name="arrayList">De ArrayList waaruit het item verwijderd moet worden.</param>
        /// <param name="item">Het item dat verwijderd moet worden.</param>
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

        /// <summary>
        /// Verwijderd een item uit de ArrayList met de RemoveAt methode en print hierover informatie.
        /// </summary>
        /// <param name="arrayList">De ArrayList waaruit het item verwijderd moet worden.</param>
        /// <param name="item">Het item dat verwijderd moet worden.</param>
        public static void removeAtAndPrint(ArrayList arrayList, Object item)
        {
            int pos = arrayList.IndexOf(item);
            if (pos != -1)
            {
                arrayList.RemoveAt(pos);
                Console.WriteLine(item.ToString() + " is removed from the ArrayList.");
            }
            else
            {
                Console.WriteLine(item.ToString() + " is not in the ArrayList.");
            }
        }

        /// <summary>
        /// Verwijderd een item uit de ArrayList met de RemoveAt methode en print hierover informatie.
        /// </summary>
        /// <param name="arrayList">De ArrayList waaruit het item verwijderd moet worden.</param>
        /// <param name="index">De index van het item dat verwijderd moet worden.</param>
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

        /// <summary>
        /// Print een ArrayList.
        /// </summary>
        /// <param name="arrayList">De ArrayList die geprint moet worden.</param>
        /// <param name="firstLine">De tekst die geprint moet worden voordat de ArrayList mag worden geprint.</param>
        public static void printArrayList(ArrayList arrayList, string firstLine)
        {
            Console.WriteLine(firstLine);
            foreach (Object item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
