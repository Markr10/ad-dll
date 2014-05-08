using System;

namespace AD_Dll.Hoofdstuk_3
{
    /// <summary>
    /// Wybren Jongstra
    /// Deze klasse sorteert een array door het gebruik van de InsertionSort methode
    /// </summary>
    /// <typeparam name="T">Het type gegevens dat wordt opgeslagen in het object</typeparam>
    public class InsertionSort<T> where T : IComparable
    {
        string result;

        /// <summary>
        /// Standaard constructor
        /// </summary>
        /// <remarks>De constructor van deze klasse is standaard leeg</remarks>
        public InsertionSort() {}

        /// <summary>
        /// Sorteert een array volgens de InsertionSort methode.
        /// De array wordt gesorteerd door int k in te voegen en vervolgens ermee te vergelijken.
        /// De gesorteerde nummers worden tijdelijk opgeslagen in temp
        /// </summary>
        /// <param name="array">De array die gesorteerd moet worden</param>
        /// <returns>De gesorteerde array</returns>
        public string Start(T[] array)
        {
            T temp; 
            int k;

            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                k = i - 1;
                while (k >= 0 && array[k].CompareTo(temp) > 0)
                {
                    array[k + 1] = array[k];
                    k--;
                }
                array[k + 1] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                result += (array[i] + " ");
            }
            
            return result;
        }
    }
}
