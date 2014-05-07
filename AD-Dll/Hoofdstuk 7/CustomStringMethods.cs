using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_7
{
    /// <summary>
    /// Mark Roelans
    /// Zelfgemaakte methode(s) die gebruikt maken van String objecten of iets doen met strings.
    /// </summary>
    public class CustomStringMethods
    {
        /// <summary>
        /// Haalt de eerste twee woorden uit een String.
        /// </summary>
        /// <param name="stringWithTwoWords">Een String die bestaat uit minimaal twee woorden die gescheiden worden door een spatie.</param>
        /// <returns>Een String array waarin de eerste twee woorden staan.</returns>
        public static String[] GetFirstTwoWordsOfAString(string stringWithTwoWords)
        {
            int len = stringWithTwoWords.Length;
            int pos = stringWithTwoWords.IndexOf(" ");
            string firstWord, secondWord;
            firstWord = stringWithTwoWords.Substring(0, pos);
            secondWord = stringWithTwoWords.Substring(pos + 1, len - (pos + 1));

            return new string[] { firstWord, secondWord };
        }

        /// <summary>
        /// Print een String met informatie over deze String.
        /// </summary>
        /// <param name="aboutStringText">De informatie over de String die geprint moet worden.</param>
        /// <param name="stringText">De String die geprint moet worden.</param>
        public static void PrintString(string aboutStringText, string stringText)
        {
            Console.WriteLine("{0}: \"{1}\"", aboutStringText, stringText);
        }

        /// <summary>
        /// Print strings met informatie over deze groep strings.
        /// </summary>
        /// <param name="aboutStringText">De informatie over de groep strings die geprint moet worden.</param>
        /// <param name="strings">De strings die geprint moeten worden.</param>
        public static void PrintString(string aboutStringText, params string[] strings)
        {
            Console.Write("{0}: ", aboutStringText);
            PrintArrayWithWords(strings);
        }

        /// <summary>
        /// Haalt woorden uit een String.
        /// </summary>
        /// <param name="aString">Een String die bestaat uit minimaal twee woorden die gescheiden worden door een spatie.</param>
        /// <returns>Een ArrayList met de woorden uit de String.</returns>
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

        /// <summary>
        /// Print een ArrayList die woorden bevat.
        /// </summary>
        /// <param name="words">De ArrayList met woorden.</param>
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

        /// <summary>
        /// Print een array met woorden.
        /// </summary>
        /// <typeparam name="T">Het type gegevens die zijn opgeslagen in de array.</typeparam>
        /// <param name="words">Een array waarvan de toString methode een woord is.</param>
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

        /// <summary>
        /// Print de invoer string en de array waarin de woorden staan van de invoer string.
        /// </summary>
        /// <param name="inputString">De invoer string.</param>
        /// <param name="stringArray">De array waarin de woorden staan van de invoer string.</param>
        public static void PrintArrayWithSplitWords(string inputString, string[] stringArray)
        {
            CustomStringMethods.PrintString("Input String", inputString);
            Console.WriteLine("Words:");
            CustomStringMethods.PrintArrayWithWords(stringArray);
        }

        /// <summary>
        /// Controleert of twee strings gelijk zijn door middel van de Equals methode en print hierover informatie.
        /// </summary>
        /// <param name="firstString">De eerste string die vergeleken moet worden.</param>
        /// <param name="secondString">De tweede string die vergeleken moet worden.</param>
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

        /// <summary>
        /// Vergelijkt twee objecten met elkaar door middel van de CompareTo methode en
        /// en print hierover informatie.
        /// </summary>
        /// <typeparam name="T">Het type gegevens die zijn opgeslagen in de objecten.</typeparam>
        /// <param name="firstObject">Het eerste object dat vergeleken moet worden.</param>
        /// <param name="secondObject">Het tweede object dat vergeleken moet worden.</param>
        public static void CompareToAndPrint<T>(T firstObject, T secondObject) where T : IComparable
        {
            PrintString("First object", firstObject.ToString());
            PrintString("Second object", secondObject.ToString());
            Console.WriteLine("The output from CompareTo is: " + firstObject.CompareTo(secondObject));
        }

        /// <summary>
        /// Controleert of twee strings gelijk zijn door middel van de String Compare methode en print hierover informatie.
        /// </summary>
        /// <param name="firstString">De eerste string die vergeleken moet worden.</param>
        /// <param name="secondString">De tweede string die vergeleken moet worden.</param>
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

        /// <summary>
        /// Controleert of strings in een array met een bepaalde waarde eindigen en print hierover informatie.
        /// </summary>
        /// <param name="words">De array met strings die gecontroleert moeten worden.</param>
        /// <param name="value">De eind string waarop elke string gecontroleerd moet worden.</param>
        /// <param name="whatIsFound">Een beschrijving van wat precies is gevonden.</param>
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

        /// <summary>
        /// Controleert of strings in een array met een bepaalde waarde beginnen en print hierover informatie.
        /// </summary>
        /// <param name="words">De array met strings die gecontroleert moeten worden.</param>
        /// <param name="value">De begin string waarop elke string gecontroleerd moet worden.</param>
        /// <param name="whatIsFound">Een beschrijving van wat precies is gevonden.</param>
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

        /// <summary>
        /// Voegt een string binnen een string in en print hierover informatie.
        /// </summary>
        /// <param name="stringToUse">De string waarbinnen een string moet worden ingevoegd.</param>
        /// <param name="startIndex">De index van de plaats waar de string ingevoegd moet worden.</param>
        /// <param name="value">De string die ingevoegd moet worden.</param>
        /// <returns>De string met de ingevoegde string.</returns>
        public static String InsertPrintAndReturn(string stringToUse, int startIndex, string value)
        {
            stringToUse = stringToUse.Insert(startIndex, value);
            PrintString("Output String", stringToUse);
            return stringToUse;
        }

        /// <summary>
        /// Verwijderd een deel van een string en print hierover informatie.
        /// </summary>
        /// <param name="stringToUse">De string die gebruikt moet worden.</param>
        /// <param name="startIndex">De index van de plaats waar begonnen moet worden met het verwijderden.</param>
        /// <param name="count">Het aantal karakters dat verwijderd moet worden.</param>
        /// <returns>De string waaruit een deel verwijderd is.</returns>
        public static String RemovePrintAndReturn(string stringToUse, int startIndex, int count)
        {
            stringToUse = stringToUse.Remove(startIndex, count);
            PrintString("Output String", stringToUse);
            return stringToUse;
        }

        /// <summary>
        /// Voegt een string binnen een string in, verwijderd een deel van de nieuwe string en print hierover informatie.
        /// </summary>
        /// <param name="stringToUse">De string die gebruikt moet worden.</param>
        /// <param name="startIndex">De index van de plaats waar de string ingevoegd moet worden en
        /// de index van de plaats waar begonnen moet worden met het verwijderden.</param>
        /// <param name="value">De string die ingevoegd moet worden.</param>
        /// <param name="count">Het aantal karakters dat verwijderd moet worden.</param>
        /// <returns>De string met de ingevoegde string en waaruit een deel verwijderd is.</returns>
        public static String PrintInsertAndRemove(string stringToUse, int startIndex, string value, int count)
        {
            PrintString("Input  String", stringToUse);
            PrintString("Insert String", value);
            stringToUse = InsertPrintAndReturn(stringToUse, startIndex, value);
            PrintString("Characters to remove", stringToUse.Substring(startIndex, count));
            return RemovePrintAndReturn(stringToUse, startIndex, count);
        }

        /// <summary>
        /// Vervangt delen van strings in een array met een andere string en print hierover informatie.
        /// </summary>
        /// <param name="words">De array met strings waarvan bepaalde delen vervangen moeten worden.</param>
        /// <param name="stringToReplace">De string die vervangen moet worden.</param>
        /// <param name="replacementString">De string waarmee de te vervangen string mee vervangen moet worden.</param>
        public static void ReplaceAndPrint(string[] words, string stringToReplace, string replacementString)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace(stringToReplace, replacementString);
            }
            AD_Dll.Hoofdstuk_2.CustomArrayMethods.printArray(words, "Array after replacement:");
        }

        /// <summary>
        /// Print een 2D Array uitgelijnt.
        /// </summary>
        /// <param name="array">De tweedimensionale die uitgelijnt moet worden.</param>
        /// <param name="totalWidth">Het totale aantal karakters die een kolom maximaal mag bevatten.</param>
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

        /// <summary>
        /// Trimt strings in een array op bepaalde waarden.
        /// </summary>
        /// <param name="arr">De string array die getrimt moet worden.</param>
        /// <param name="trimChars">De karakters waarop getrimt moet worden.
        /// Indien er geen karakters zijn opgegeven wordt een spatie als trim karakter gebruikt.</param>
        public static void trimVals(string[] arr, params char[] trimChars)
        {
            if (trimChars.Length == 0)
            {
                trimChars = new char[] { ' ' };
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Trim(trimChars);
            }
        }

        /// <summary>
        /// Trimt het einde van strings in een array op bepaalde waarden.
        /// </summary>
        /// <param name="arr">De string array die getrimt moet worden.</param>
        /// <param name="trimChars">De karakters waarop getrimt moet worden.
        /// Indien er geen karakters zijn opgegeven wordt een spatie als trim karakter gebruikt.</param>
        public static void trimEndVals(string[] arr, params char[] trimChars)
        {
            if (trimChars.Length == 0)
            {
                trimChars = new char[] { ' ' };
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].TrimEnd(trimChars);
            }
        }
    }
}