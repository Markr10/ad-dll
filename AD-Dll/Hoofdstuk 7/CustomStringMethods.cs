using System;
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
            secondWord = stringWithTwoWords.Substring(pos + 1, (len - 1) - pos);

            return new string[] { firstWord, secondWord };
        }

        public static void printString(string aboutStringText, string stringText)
        {
            Console.WriteLine("{0}: \"{1}\"", aboutStringText, stringText);
        }
    }
}
