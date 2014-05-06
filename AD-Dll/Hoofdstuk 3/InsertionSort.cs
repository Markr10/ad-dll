using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Wybren Jongstra
 * A class to sort an array using the InsertionSort method
 */

namespace AD_Dll.Hoofdstuk_3
{
    public class InsertionSort<T> where T : IComparable
    {
        string result;

        public InsertionSort()
        {

        }

        public string Start(T[] array)
        {

            T temp; 
            int k;

            //Sorting array using the inserted int k
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
