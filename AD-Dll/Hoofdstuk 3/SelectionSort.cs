using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Wybren Jongstra
 * A class to sort an array using the SelectionSort method
 */

namespace AD_Dll.Hoofdstuk_3
{
    public class SelectionSort<T> where T : IComparable
    {
        string result;

        public SelectionSort()
        {

        }

        public string Start(T[] array)
        {
            T temp;
            int min_key;

            //Sorting array by placing the sorted numbers in temp
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
