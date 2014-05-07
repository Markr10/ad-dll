using AD_Dll.Hoofdstuk_7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_2;

namespace AD
{
    public partial class Strings : FormConsole
    {
        private string aString;
        private string data;
        private char[] delimiter;

        public Strings() : base(false)
        {
            InitializeComponent();
            btnChangeString_Click(null, null);
        }

        private void btnShowString_Click(object sender, EventArgs e)
        {
            if (btnShowString.Text == "Show a String")
            {
                string name = "Jennifer Ingram";
                MessageBox.Show(name, "A String");
                btnShowString.Text = "Show another String";
            }
            else
            {
                string name = "Mike McMillan\nInstructor, CIS\tRoom 306";
                MessageBox.Show(name, "Another String");
                btnShowString.Text = "Show a String";
            }
        }

        private void btnTwoWords_Click(object sender, EventArgs e)
        {
            string inputString = "Hello, world!";
            string[] firstTwoWordsArray = CustomStringMethods.GetFirstTwoWordsOfAString(inputString);
            ShowConsole("First two words of a String");
            CustomStringMethods.PrintString("Input String", inputString);
            CustomStringMethods.PrintString("First word", firstTwoWordsArray[0]);
            CustomStringMethods.PrintString("Second word", firstTwoWordsArray[1]);
            CloseConsole();
        }

        private void btnShowSubString_Click(object sender, EventArgs e)
        {
            int startPosition = 0;
            int lengthSubstring = 3;
            ShowConsole("Show substring of a String");
            CustomStringMethods.PrintString("Input String", aString);
            Console.WriteLine("Start position for Substring: " + startPosition.ToString());
            Console.WriteLine("Characters to pull for Substring: " + lengthSubstring.ToString());
            CustomStringMethods.PrintString("Substring", aString.Substring(startPosition, lengthSubstring));
            CloseConsole();
        }

        private void btnChangeString_Click(object sender, EventArgs e)
        {
            if (aString != "Now is the time")
            {
                aString = "Now is the time";
            }
            else
            {
                aString = "now is the time for all good people ";
            }
        }

        private void btnSplitWords_Click(object sender, EventArgs e)
        {
            ShowConsole("Split words");
            CustomStringMethods.PrintString("Input String", aString);
            Console.WriteLine("Words:");
            CustomStringMethods.PrintArrayListWithWords(CustomStringMethods.SplitWords(aString));
            CloseConsole();
        }

        private void btnInitDataAndCharArray_Click(object sender, EventArgs e)
        {
            data = "Mike,McMillan,3000 W. Scenic,North Little Rock,AR,72118";
            delimiter = new char[] { ',' };

            btnSplitMethod.Enabled = btnJoinMethod.Enabled = true;
            btnInitDataAndCharArray.Enabled = false;
        }

        private void btnSplitMethod_Click(object sender, EventArgs e)
        {
            string[] sdata = data.Split(delimiter, data.Length);

            ShowConsole("Split method");
            CustomStringMethods.PrintArrayWithSplitWords(data, sdata);

            sdata = data.Split(delimiter, 2);
            CustomArrayMethods.printArray(sdata, "Split method with 2 as the maximum number of substrings to return, gives the following elements in the returned array:");
            CloseConsole();
        }

        private void btnJoinMethod_Click(object sender, EventArgs e)
        {
            string[] sdata;
            sdata = data.Split(delimiter, data.Length);

            ShowConsole("Join method");
            CustomStringMethods.PrintArrayWithSplitWords(data, sdata);

            string joined;
            joined = String.Join(",", sdata);

            Console.WriteLine("Joined string:");
            Console.WriteLine(joined);
            CloseConsole();
        }

        private void btnCharCode_Click(object sender, EventArgs e)
        {
            int charCode;
            charCode = (int)'a';

            WriteFirstLine("The character code of \"a\" is: " + charCode.ToString(), "Character code of \"a\"");
            CloseConsole();
        }

        private void btnEqualsMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("Equals method");
            string s1 = "foobar";
            string s2 = "foobar";
            CustomStringMethods.EqualsAndPrint(s1, s2);
            CloseConsole();
        }

        private void btnCompareToMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("CompareTo method");
            string s1 = "foobar";
            string s2 = "foobar";
            CustomStringMethods.CompareToAndPrint(s1, s2); // returns 0
            s2 = "foofoo";
            CustomStringMethods.CompareToAndPrint(s1, s2); // returns -1
            s2 = "fooaar";
            CustomStringMethods.CompareToAndPrint(s1, s2); // returns 1
            CloseConsole();
        }

        private void btnCompareMethod_Click(object sender, EventArgs e)
        {
            string s1 = "foobar";
            string s2 = "foobar";

            ShowConsole("Compare method");
            CustomStringMethods.CompareAndPrint(s1, s2);
            CloseConsole();
        }

        private void btnEndsWithMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("Demonstration of the EndsWith method");
            string[] nouns = new string[] { "cat", "dog", "bird", "eggs", "bones" };
            CustomStringMethods.EndsWithAndPrint(nouns, "s", "plural nouns");
            CloseConsole();
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            ShowConsole("Demonstration of the StartsWith method");
            string[] words = new string[] { "triangle", "diagonal", "trimester", "bifocal", "triglycerides" };
            CustomStringMethods.StartsWithAndPrint(words, "tri", "words that start with \"tri\"");
            CloseConsole();
        }

        private void btnInsertMethod_Click(object sender, EventArgs e)
        {
            string s1 = "Hello, . Welcome to my class.";
            string name = "Clayton";
            int pos = s1.IndexOf(",");

            ShowConsole("Demonstration of the Insert method");
            CustomStringMethods.PrintString("Input  String", s1);
            CustomStringMethods.PrintString("Insert String", name);
            CustomStringMethods.InsertPrintAndReturn(s1, (pos + 2), name);
            CloseConsole();
        }

        private void btnRemoveMethod_Click(object sender, EventArgs e)
        {
            string s1 = "Hello, . Welcome to my class.";
            string name = "Ella";
            int pos = s1.IndexOf(",");

            ShowConsole("Demonstration of the Remove method");
            CustomStringMethods.PrintInsertAndRemove(s1, (pos + 2), name, name.Length);
            name = "William Shakespeare";
            CustomStringMethods.PrintInsertAndRemove(s1, (pos + 2), name, name.Length);
            CloseConsole();
        }

        private void btnReplaceMethod_Click(object sender, EventArgs e)
        {
            string[] words = new string[] { "recieve", "decieve", "reciept" };
            string stringToReplace = "cie";
            string replacementString = "cei";

            ShowConsole("Demonstration of the Replace method");
            CustomStringMethods.PrintString("Characters to replace", stringToReplace);
            CustomStringMethods.PrintString("Replacement characters", replacementString);
            Console.WriteLine();
            CustomArrayMethods.printArray(words, "Array before replacement:");
            Console.WriteLine();
            CustomStringMethods.ReplaceAndPrint(words, stringToReplace, replacementString);
            CloseConsole();
        }

        private void btnPadMethods_Click(object sender, EventArgs e)
        {
            string s1 = "Hello";
            string s2 = "world";
            string s3 = "Goodbye";

            string[,] names = new string[,]
            {
                {"1504", "Mary", "Ella", "Steve", "Bob"},
                {"1133", "Elizabeth", "Alex", "David", "Joe"},
                {"2624", "Joel", "Chris", "Craig", "Bill"}
            };


            ShowConsole("Demonstration of the PadLeft and PadRight methods");
            CustomStringMethods.PrintString("Input Strings", s1, s2, s3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(s1.PadLeft(10));
            Console.WriteLine(s2);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(s1.PadLeft(10));
            Console.WriteLine(s2.PadLeft(10));
            Console.Write(s3.PadLeft(10));
            Console.WriteLine(s2.PadLeft(10));

            Console.WriteLine();
            Console.WriteLine();
            CustomMethods.print2DArrayWithSpaces(names);
            Console.WriteLine();
            CustomStringMethods.print2DArrayPadRight(names, 10);

            CloseConsole();
        }

        private void btnOtherMethods_Click(object sender, EventArgs e)
        {
            string s1, s2, s3 = String.Empty;

            ShowConsole("Demonstration of some other methods of the class String");

            Console.WriteLine("Concat method");
            s1 = "hello";
            s2 = "world";
            s3 = "";
            CustomStringMethods.PrintString("Input Strings", s1, s2, s3);
            s3 = String.Concat(s1, " ", s2);
            CustomStringMethods.PrintString("Output String", s3);

            Console.WriteLine();
            s1 = "hello";
            Console.WriteLine("ToUpper method");
            CustomStringMethods.PrintString("Input  String", s1);
            s1 = s1.ToUpper();
            CustomStringMethods.PrintString("Output String", s1);

            PauseConsole();

            Console.WriteLine();
            s1 = "WORLD";
            Console.WriteLine("ToLower method");
            CustomStringMethods.PrintString("Input  String", s1);
            CustomStringMethods.PrintString("Output String", s1.ToLower());

            Console.WriteLine();
            string[] names = new string[] { " David", " Raymond", "Mike ", "Bernica " };
            Console.WriteLine("Trim method");
            CustomStringMethods.PrintString("Input  Strings", names);
            CustomStringMethods.trimVals(names);
            CustomStringMethods.PrintString("Output Strings", names);

            Console.WriteLine();
            string[] otherNames = new string[] { " Lamont", " Doris", "Olympia ", "Maybelle " };
            Console.WriteLine("TrimEnd method");
            CustomStringMethods.PrintString("Input  Strings", otherNames);
            CustomStringMethods.trimEndVals(otherNames);
            CustomStringMethods.PrintString("Output Strings", otherNames);

            Console.WriteLine();
            string[] htmlComments = new string[] { "<!-- Start Page Number Function -->", "<!-- Get user name and password -->",
                "<!-- End Title page -->", "<!-- End script -->" };
            char[] commentChars = new char[] { '<', '!', '-', '>' };
            CustomArrayMethods.printArray(htmlComments, "Input:");
            CustomStringMethods.trimVals(htmlComments, commentChars);
            CustomMethods.printArray(htmlComments, "Output:", "Comment");

            CloseConsole();
        }
    }
}
