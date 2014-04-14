using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_7;
using AD_Dll;

namespace AD
{
    public partial class StringBuilderForm : FormConsole
    {
        private StringBuilder stBuff1;
        private StringBuilder stBuff2;
        private StringBuilder stBuff3;
        private Object thisLock = new Object();
        private ProcessTimer t = new ProcessTimer();

        public StringBuilderForm() : base(false)
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            stBuff1 = new StringBuilder();
            stBuff2 = new StringBuilder(25);
            stBuff3 = new StringBuilder("Hello, world");

            btnShow.Enabled = true;
            btnCreate.Enabled = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowConsole("Information about StringBuilders");
            StringBuilder stBuff = new StringBuilder("Ken Thompson");

            CustomStringBuilderMethods.PrintInfo(stBuff, "stBuff");
            CustomStringBuilderMethods.PrintInfo(stBuff1, "stBuff1");
            PauseConsole();
            Console.WriteLine();
            CustomStringBuilderMethods.PrintInfo(stBuff2, "stBuff2");
            CustomStringBuilderMethods.PrintInfo(stBuff3, "stBuff3");

            stBuff.Length = 10;
            stBuff.EnsureCapacity(25);
            Console.WriteLine("stBuff with new properties:");
            CustomStringBuilderMethods.PrintInfo(stBuff, "stBuff");

            CloseConsole();
        }

        private void btnAppendMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("Append method");
            StringBuilder stBuff = new StringBuilder();
            String[] words = new string[] { "now ", "is ", "the ", "time ", "for ", "all ", "good ",
                "men ", "to ", "come ", "to ", "the ", "aid ", "of ", "their ", "party" };
            for (int i = 0; i <= words.GetUpperBound(0); i++)
            {
                stBuff.Append(words[i]);
            }
            Console.WriteLine(stBuff);

            CloseConsole();
        }

        private void btnFormatString_Click(object sender, EventArgs e)
        {
            ShowConsole("Format StringBuilder");
            StringBuilder stBuff = new StringBuilder();
            Console.WriteLine();
            stBuff.AppendFormat("Your order is for {0000} widgets.", 234);
            stBuff.AppendFormat("\nWe have {0000} widgets left.", 12);
            Console.WriteLine(stBuff);

            CloseConsole();
        }

        private void btnInsertMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("Insert Method");

            StringBuilder stBuff = new StringBuilder();
            stBuff.Insert(0, "Hello");
            stBuff.Append("world");
            stBuff.Insert(5, ", ");
            Console.WriteLine(stBuff);
            char[] chars = new char[] { 't', 'h', 'e', 'r', 'e' };
            stBuff.Insert(5, " " + chars);
            Console.WriteLine(stBuff);

            stBuff = new StringBuilder();
            stBuff.Insert(0, "and on ", 6);
            Console.WriteLine(stBuff);

            CloseConsole();
        }

        private void btnRemoveMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("Remove Method");

            StringBuilder stBuff = new StringBuilder("noise in+++++string");
            stBuff.Remove(9, 5);
            Console.WriteLine(stBuff);

            CloseConsole();
        }

        private void btnReplaceMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("Replace Method");

            StringBuilder stBuff = new StringBuilder("recieve decieve reciept");
            stBuff.Replace("cie", "cei");
            Console.WriteLine(stBuff);

            CloseConsole();
        }

        private void btnToStringMethod_Click(object sender, EventArgs e)
        {
            ShowConsole("ToString method");
            StringBuilder stBuff = new StringBuilder("HELLO WORLD");
            string st = stBuff.ToString();
            st = st.ToLower();
            st = st.Replace(st.Substring(0, 1),
            st.Substring(0, 1).ToUpper());
            stBuff.Replace(stBuff.ToString(), st);
            Console.WriteLine(stBuff);

            CloseConsole();
        }

        private void btnTiming_Click(object sender, EventArgs e)
        {
            ShowConsole("Timing");

            int size = 100;
            for (int i = 0; i <= 3; i++)
            {
                lock (thisLock)
                {
                    t.Start();
                    StringBuilderForm.BuildSB(size);
                    t.Stop();
                }

                Console.WriteLine("Time in microseconds to build StringBuilder object for " + size + " elements: " + t.Duration(1).ToString());

                lock (thisLock)
                {
                    t.Start();
                    StringBuilderForm.BuildString(size);
                    t.Stop();
                }

                Console.WriteLine("Time in microseconds to build String object for " + size + " elements: " + t.Duration(1).ToString());
                Console.WriteLine();
                size *= 10;
            }

            CloseConsole();
        }

        private static void BuildSB(int size)
        {
            StringBuilder sbObject = new StringBuilder();

            for (int i = 0; i <= size; i++)
            {
                sbObject.Append("a");
            }
        }

        private static void BuildString(int size)
        {
            string stringObject = "";
            for (int i = 0; i <= size; i++)
            {
                stringObject += "a";
            }
        }
    }
}
