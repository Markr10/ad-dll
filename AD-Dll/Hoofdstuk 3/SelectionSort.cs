using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_3
{
    /// <summary>
    /// Wybren Jongstra
    /// Deze klasse sorteert een array door het gebruik van de SelectionSort methode
    /// </summary>
    /// <typeparam name="T">Het type gegevens dat is opgeslagen in de klasse</typeparam>
    public class SelectionSort<T> where T : IComparable
    {
        string result;

        /// <summary>
        /// Standaard constructor
        /// </summary>
        /// <remarks>De constructor van deze klasse is standaard leeg</remarks>
        public SelectionSort() {}

        /// <summary>
        /// Sorteert een array volgens de SelectionSort methode.
        /// De gesorteerde nummers worden tijdelijk opgeslagen in temp
        /// </summary>
        /// <param name="array">De array die gesorteerd moet worden</param>
        /// <returns>De gesorteerde array</returns>
        public string Start(T[] array)
        {
            T temp;
            int min_key;

            for (int j = 0; j < array.Length - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[k].CompareTo(array[min_key]) < 0)
                    {
                        min_key = k;
                    }
                }
                temp = array[min_key];
                array[min_key] = array[j];
                array[j] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                result += (array[i] + " ");
            }

            return result;
        }
    }
}
