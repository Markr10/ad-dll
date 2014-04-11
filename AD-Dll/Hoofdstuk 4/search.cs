using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class search<T> where T : IComparable<T>
    {
       
        public int linear(T[] a, T v)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (v.Equals(a[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int binary(T[] a, T v)
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
                    return mid;
                }
            }
            return -1;
        }
    }
}



