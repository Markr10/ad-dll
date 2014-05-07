using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    /// <summary>
    /// Mark Roelans
    /// Methodes die gebruik maken van parameter arrays.
    /// </summary>
    public class CustomParameterArrayMethods
    {
        /// <summary>
        /// Telt de waarden van de parameters op en returned het resultaat.
        /// </summary>
        /// <param name="nums">De getallen die opgeteld moeten worden.</param>
        /// <returns>Het totaal van de opgetelde parameters.</returns>
        public static int sumNums(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        /// <summary>
        /// Telt de waarden van de parameters op en print het resultaat.
        /// </summary>
        /// <param name="nums">De getallen die opgeteld moeten worden.</param>
        public static void sumNumsAndPrint(params int[] nums)
        {
            Console.Write("The sum of ");
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if ((i + 1) != nums.Length)
                {
                    Console.Write(", ");
                }

                sum += nums[i];
            }
            Console.WriteLine(" is: " + sum.ToString());
        }
    }
}
