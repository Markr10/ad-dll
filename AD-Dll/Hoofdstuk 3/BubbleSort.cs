using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_3
{
    public class BubbleSort
    {
        string result;

        public BubbleSort()
        {

        }

        public string Start(int[] array)
        {
            int temp;

            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            foreach (int aa in array)
            {
                result += (aa + " ");
            }

            return result;
        }
    }
}
