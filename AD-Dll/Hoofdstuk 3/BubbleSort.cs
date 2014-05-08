using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_3
{
    /// <summary>
    /// Wybren Jongstra
    /// Deze klasse sorteert een array door het gebruik van de BubbleSort methode
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleSort<T> where T : IComparable
    {
        string result;

        /// <summary>
        /// Lege constructor
        /// </summary>
        public BubbleSort()
        {

        }

        /// <summary>
        /// Sorteert een array volgens de BubbleSort methode.
        /// De gesorteerde nummers worden tijdelijk opgeslagen in temp.
        /// </summary>
        /// <param name="array">De array die gesorteerd moet worden</param>
        /// <returns>Gesorteerde array</returns>
        public string Start(T[] array)
        {
            T temp;
            
            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            foreach (T aa in array)
            {
                result += (aa + " ");
            }

            return result;
        }
    }
}
