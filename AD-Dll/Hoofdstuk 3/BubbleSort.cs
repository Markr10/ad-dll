using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Wybren Jongstra
 * A class to sort an array using the BubbleSort method
 */

namespace AD_Dll.Hoofdstuk_3
{
    public class BubbleSort<T> where T : IComparable
    {
        string result;

        public BubbleSort()
        {

        }

        public string Start(T[] array)
        {
            T temp;
            
            //Sorting array by placing the sorted numbers in temp
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
