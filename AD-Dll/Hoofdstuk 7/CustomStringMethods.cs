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
        }
    }
}
