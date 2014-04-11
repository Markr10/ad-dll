using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_4
{
    public class Search<T> where T : IComparable<T>
    {
       
        public static int linear(T[] a, T v)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (v.Equals(a[i]))
                {
                    Console.WriteLine("Found at index: ");
                    return i;
                }
            }
            return -1;
        }

        public static int binary(T[] a, T v)
        {
            int low = 0;
            int high = a.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                T midVal = a[mid];
                int result = v.CompareTo(midVal);

                if (result < 0)
                {
                    high = mid - 1;
                }

                else if (result > 0)
                {
                    low = mid + 1;
                }

                else
                {
                    Console.WriteLine("Found at index: ");
                    return mid;
                }
            }
            return -1;
        }
    }
}



