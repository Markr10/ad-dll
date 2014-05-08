using System;

namespace AD_Dll.Hoofdstuk_4
{
    /// <summary>
    /// Thomas Oldengarm
    /// Search klasse
    /// </summary>
    /// <typeparam name="T">Het type gegevens dat wordt opgeslagen in het object</typeparam>
    public class Search<T> where T : IComparable<T>
    {
       /// <summary>
       /// Lineare zoekfuntie
       /// </summary>
       /// <param name="a">De array waarin gezocht moet worden</param>
       /// <param name="v">Het item wat gezocht moet worden</param>
       /// <returns>De index van het item in de array. -1 als het item niet gevonden is</returns>
        public static int linear(T[] a, T v) 
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (v.Equals(a[i])) // als gevonden is, return de index nummer
                {
                    Console.WriteLine("Found at index: ");
                    return i;
                }
            }
            return -1; // niet gevonden, return -1
        }

        /// <summary>
        /// Binaire zoekfunctie
        /// </summary>
        /// <param name="a">De array waarin gezocht moet worden</param>
        /// <param name="v">Het item wat gezocht moet worden</param>
        /// <returns>De index van het item in de array. -1 als het item niet gevonden is</returns>
        public static int binary(T[] a, T v) 
        {
            int low = 0;
            int high = a.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2; // zoek het midden van de array
                T midVal = a[mid];
                int result = v.CompareTo(midVal);

                if (result < 0) // key ligt lager
                {
                    high = mid - 1;
                }

                else if (result > 0) // key ligt hoger
                {
                    low = mid + 1;
                }

                else // key gevonden, return index
                {
                    Console.WriteLine("Found at index: ");
                    return mid;
                }
            }
            return -1; // key niet gevonden
        }
    }
}
