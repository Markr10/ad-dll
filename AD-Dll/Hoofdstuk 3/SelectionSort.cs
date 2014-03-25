using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_3
{
    public class SelectionSort
    {
        string result;

        public SelectionSort()
        {

        }

        public string Start(int[] array)
        {
            int array_size = array.Length;
            int tmp, min_key;

            for (int j = 0; j < array_size - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array_size; k++)
                {
                    if (array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }
                tmp = array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }

            for (int i = 0; i < array_size; i++)
            {
                result += (array[i] + " ");
            }

            return result;
        }
    }
}
