using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_2
{
    public class CustomMethods
    {
        #region Generics methods with Arrays from Chapter 7

        public static void print2DArrayWithSpaces<T>(T[,] array)
        {
            for (int row = 0, lengthRow = array.GetLength(0); row < lengthRow; row++)
            {
                for (int column = 0, lengthColumn = array.GetLength(1); column < lengthColumn; column++)
                {
                    if (array[row, column] == null)
                    {
                        Console.WriteLine("null");
                    }
                    else
                    {
                        Console.Write(array[row, column].ToString());
                    }

                    if ((column + 1) != lengthColumn)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void printArray<T>(T[] array, string firstLine, string stringForEachItem)
        {
            Console.WriteLine(firstLine);
            foreach (object item in array)
            {
                Console.WriteLine(stringForEachItem + ": " + item.ToString());
            }
        }

        #endregion
    }
}
