using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_7
{
    public class CustomStringMethods
    {
        public static String[] GetFirstTwoWordsOfAString(string stringWithTwoWords)
        {
            int len = stringWithTwoWords.Length;
            int pos = stringWithTwoWords.IndexOf(" ");
            string firstWord, secondWord;
            firstWord = stringWithTwoWords.Substring(0, pos);
            secondWord = stringWithTwoWords.Substring(pos + 1, len - (pos + 1));

            return new string[] { firstWord, secondWord };
        }

        public static void PrintString(string aboutStringText, string stringText)
        {
            Console.WriteLine("{0}: \"{1}\"", aboutStringText, stringText);
        }

        public static void PrintString(string aboutStringText, params string[] strings)
        {
            Console.Write("{0}: ", aboutStringText);
            PrintArrayWithWords(strings);
        }

        public static ArrayList SplitWords(string aString)
        {
            int pos;
            string word;
            ArrayList words = new ArrayList();
            pos = aString.IndexOf(" ");
            while (pos > 0)
            {
                word = aString.Substring(0, pos);
                words.Add(word);
                aString = aString.Substring(pos + 1, aString.Length - (pos + 1));
                pos = aString.IndexOf(" ");
                if (pos == -1)
                {
                    word = aString.Substring(0, aString.Length);
                    words.Add(word);
                }
            }
            return words;
        }

        public static void PrintArrayListWithWords(ArrayList words)
        {
            foreach (Object word in words)
            {
                Console.Write("\"{0}\"", word);
                if (words.IndexOf(word) != (words.Count - 1))
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        public static void PrintArrayWithWords<T>(T[] words)
        {
            for (int i = 0, length = (words.Length - 1); i < length; i++)
            {
                Console.Write("\"{0}\" ", words[i]);
            }
            if (words.Length != 0)
            {
                Console.WriteLine("\"{0}\"", words[words.GetUpperBound(0)]);
            }
        }

        public static void PrintArrayWithSplitWords(string inputString, string[] stringArray)
        {
            CustomStringMethods.PrintString("Input String", inputString);
            Console.WriteLine("Words:");
            CustomStringMethods.PrintArrayWithWords(stringArray);
        }

        public static void EqualsAndPrint(string firstString, string secondString)
        {
            PrintString("First string", firstString);
            PrintString("Second string", secondString);
            if (firstString.Equals(secondString))
            {
                Console.WriteLine("They are the same.");
            }
            else
            {
                Console.WriteLine("They are not the same.");
            }
        }

        public static void CompareToAndPrint<T>(T firstObject, T secondObject) where T : IComparable
        {
            PrintString("First object", firstObject.ToString());
            PrintString("Second object", secondObject.ToString());
            Console.WriteLine("The output from CompareTo is: " + firstObject.CompareTo(secondObject));
        }

        public static void CompareAndPrint(string firstString, string secondString)
        {
            int compVal = String.Compare(firstString, secondString);
            switch (compVal)
            {
                case 0:
                    Console.WriteLine(firstString + " " + secondString + " are equal");
                    break;
                case 1:
                    Console.WriteLine(firstString + " is less than " + secondString);
                    break;
                case 2:
                    Console.WriteLine(firstString + " is greater than" + secondString);
                    break;
                default:
                    Console.WriteLine("Can't compare");
                    break;
            }
        }

        public static void EndsWithAndPrint(string[] words, string value, string whatIsFound)
        {
            ArrayList wordsFound = new ArrayList();
            foreach (string word in words)
            {
                if (word.EndsWith(value))
                {
                    wordsFound.Add(word);
                }
            }
            Console.WriteLine("The following " + whatIsFound + " are found in the given String array:");
            PrintArrayListWithWords(wordsFound);
        }

        public static void StartsWithAndPrint(string[] words, string value, string whatIsFound)
        {
            ArrayList wordsFound = new ArrayList();
            foreach (string word in words)
            {
                if (word.StartsWith(value))
                {
                    wordsFound.Add(word);
                }
            }
            Console.WriteLine("The following " + whatIsFound + " are found in the given String array:");
            PrintArrayListWithWords(wordsFound);
        }

        public static String InsertPrintAndReturn(string stringToUse, int startIndex, string value)
        {
            stringToUse = stringToUse.Insert(startIndex, value);
            PrintString("Output String", stringToUse);
            return stringToUse;
        }

        public static String RemovePrintAndReturn(string stringToUse, int startIndex, int count)
        {
            stringToUse = stringToUse.Remove(startIndex, count);
            PrintString("Output String", stringToUse);
            return stringToUse;
        }

        public static String PrintInsertAndRemove(string stringToUse, int startIndex, string value, int count)
        {
            PrintString("Input  String", stringToUse);
            PrintString("Insert String", value);
            stringToUse = InsertPrintAndReturn(stringToUse, startIndex, value);
            PrintString("Characters to remove", stringToUse.Substring(startIndex, count));
            return RemovePrintAndReturn(stringToUse, startIndex, count);
        }

        public static void ReplaceAndPrint(string[] words, string stringToReplace, string replacementString)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace(stringToReplace, replacementString);
            }
            AD_Dll.Hoofdstuk_2.CustomMethods.printArray(words, "Array after replacement:");
        }

        public static void print2DArrayPadRight(string[,] array, int totalWidth)
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
                        Console.Write(array[row, column].PadRight(totalWidth));
                    }

                    if ((column + 1) != lengthColumn)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void trimVals(string[] arr, params Char[] trimChars)
        {
            if (trimChars.Length == 0)
            {
                trimChars = new char[] { ' ' };
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Trim(trimChars);
                arr[i] = arr[i].TrimEnd(trimChars);
            }
        }
    }
}
