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
        public static String[] getFirstTwoWordsOfAString(string stringWithTwoWords)
        {
            int len = stringWithTwoWords.Length;
            int pos = stringWithTwoWords.IndexOf(" ");
            string firstWord, secondWord;
            firstWord = stringWithTwoWords.Substring(0, pos);
            secondWord = stringWithTwoWords.Substring(pos + 1, len - (pos + 1));

            return new string[] { firstWord, secondWord };
        }

        public static void printString(string aboutStringText, string stringText)
        {
            Console.WriteLine("{0}: \"{1}\"", aboutStringText, stringText);
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

        public static void printArrayListWithWords(ArrayList words)
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

        public static void printArrayWithWords<T>(T[] words)
        {
            for (int i = 0, length = (words.Length - 1); i < length; i++)
            {
                Console.Write("\"{0}\" ", words[i]);
            }
            Console.WriteLine("\"{0}\"", words[words.GetUpperBound(0)]);
        }

        public static void printArrayWithSplitWords(string inputString, string[] stringArray)
        {
            CustomStringMethods.printString("Input String", inputString);
            Console.WriteLine("Words:");
            CustomStringMethods.printArrayWithWords(stringArray);
        }

        public static void EqualsAndPrint(string firstString, string secondString)
        {
            printString("First string", firstString);
            printString("Second string", secondString);
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
            printString("First object", firstObject.ToString());
            printString("Second object", secondObject.ToString());
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

        public static void FindPluralNounsAndPrint(string[] nouns)
        {
            ArrayList pluralNouns = new ArrayList();
            foreach (string noun in nouns)
            {
                if (noun.EndsWith("s"))
                {
                    pluralNouns.Add(noun);
                }
            }
            Console.WriteLine("The following plural nouns are found in the given String array:");
            printArrayListWithWords(pluralNouns);
        }
    }
}
