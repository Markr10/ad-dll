using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_4;
using AD_Dll;

namespace AD
{
    public partial class BasicSearch : FormConsole
    {
        private Object thisLock = new Object();
        private ProcessTimer t = new ProcessTimer();

        public BasicSearch() : base(false)
        {
            InitializeComponent();
        }

        private void btnShowSeqSearch_Click(object sender, EventArgs e)
        {
            ShowConsole("Sequential search");

            Console.WriteLine("Enter 10 letters for the array separated by [Enter]: ");
            string[] searchArray = new string[10];

            for (int i = 0; i < searchArray.Length; i++)
            {
                searchArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter a letter to search for: ");
            string searchLetter = Console.ReadLine();
            lock (thisLock)
            {
                t.Start();
                WriteLastLine(Search<string>.linear(searchArray, searchLetter).ToString());
                t.Stop();
            }
            
            ShowConsole("timing");
            Console.WriteLine("Time in microseconds to perform BasicSearch: " + t.Duration(1).ToString());
            CloseConsole();
        }

        private void btnShowBinSearch_Click(object sender, EventArgs e)
        {
            ShowConsole("Binary search");           
            Console.WriteLine("Enter 10 numbers for the array separated by [Enter]: ");
            int[] searchArray = new int[10];

            for (int i = 0; i < searchArray.Length; i++)
            {
                    if(!Int32.TryParse(Console.ReadLine(), out searchArray[i]))
                    {
                        Console.WriteLine("Numbers only");
                        i--;
                    }                
            }

            Console.WriteLine("Enter a number to search for: ");
            int searchNumber;
            while (!Int32.TryParse(Console.ReadLine(), out searchNumber))
            {
                Console.WriteLine("Numbers only");
            }

            Array.Sort(searchArray);
            Console.WriteLine("Array sorted: ");
            for (int i = 0; i < searchArray.Length; i++)
            {
                Console.WriteLine(searchArray[i]);
            }

            lock (thisLock)
            {
                t.Start();
                WriteLastLine(Search<int>.binary(searchArray, searchNumber).ToString());
                t.Stop();
            }

            ShowConsole("timing");
            Console.WriteLine("Time in microseconds to perform BinarySearch: " + t.Duration(1).ToString());
            CloseConsole();
        }
    }
}
