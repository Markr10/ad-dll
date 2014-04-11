using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int array_size = array.Length;

            T temp; 
            int k;
            for (int i = 1; i < array_size; i++)
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

            for (int i = 0; i < array_size; i++)
            {
                result += (array[i] + " ");
            }
            
            return result;
        }
    }
}
