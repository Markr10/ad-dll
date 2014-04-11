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

namespace AD
{
    public partial class Strings : FormConsole
    {
        private string aString;

        public Strings() : base(false)
        {
            InitializeComponent();
            btnChangeString_Click(null, null);
        }

        private void btnShowString_Click(object sender, EventArgs e)
        {
            if(btnShowString.Text == "Show a String")
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
            string[] firstTwoWordsArray = CustomStringMethods.getFirstTwoWordsOfAString(inputString);
            ShowConsole("First two words of a String");
            CustomStringMethods.printString("Input String", inputString);
            CustomStringMethods.printString("First word", firstTwoWordsArray[0]);
            CustomStringMethods.printString("Second word", firstTwoWordsArray[1]);
            CloseConsole();
        }

        private void btnShowSubString_Click(object sender, EventArgs e)
        {
            int startPosition = 0;
            int lengthSubstring = 3;
            ShowConsole("Show substring of a String");
            CustomStringMethods.printString("Input String", aString);
            Console.WriteLine("Start position for Substring: " + startPosition.ToString());
            Console.WriteLine("Characters to pull for Substring: " +  lengthSubstring.ToString());
            CustomStringMethods.printString("Substring", aString.Substring(startPosition, lengthSubstring));
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
    }
}
