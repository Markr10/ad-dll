using System;
using AD_Dll;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_1;
using AD_Dll.Hoofdstuk_13;

namespace AD
{
    public partial class FormMain : FormConsole
    {
        public FormMain() : base(true)
        {
            InitializeComponent();
        }

        /// <summary>
        /// random test method
        /// </summary>
        private void RandomIteration()
        {
            Random rnd = new Random();
            for (int i = short.MinValue; i < short.MaxValue; i++)
            {
                double res = rnd.Next(rnd.Next(rnd.Next(int.MaxValue))) % 500 * 5 / 5 % 1;
                res *= Math.PI;
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new ActionMeasurement().MeasureMilliseconds(RandomIteration).ToString(), "Timer");
        }

        private void btnSorteren_Click(object sender, EventArgs e)
        {
            new Sorteren().Show();
        }

        private void btnGenerics_Click(object sender, EventArgs e)
        {
            new GenericStudent().Show();
        }

        private void btnArrayAndArrayLists_Click(object sender, EventArgs e)
        {
           new ArrayAndArrayLists().Show();
        }

        private void btnStacksQueues_Click(object sender, EventArgs e)
        {
            new StacksAndQueues().Show();
        }

        private void btnBST_Click(object sender, EventArgs e)
        {
            new BinarySearchTree().Show();
        }

        private void btnCSet1_Click(object sender, EventArgs e)
        {
            ShowConsole("CSet1");
            CSet<string> setA = new CSet<string>();
            CSet<string> setB = new CSet<string>();
            CSet<string> setC = new CSet<string>();

            setA.Add("Milk");
            setA.Add("Eggs");
            setA.Add("Bacon");
            setA.Add("Cereal");
            setB.Add("Bacon");
            setB.Add("Eggs");
            setB.Add("Bread");


            setC = setA.Union(setB);

            Console.WriteLine();
            Console.WriteLine("A: " + setA.ToString());
            Console.WriteLine("B: " + setB.ToString());
            Console.WriteLine("A union B: " + setC.ToString());
            setC = setA.Intersection(setB);
            Console.WriteLine("A intersect B: " + setC.ToString());
            setC = setA.Difference(setB);
            Console.WriteLine("A diff B: " + setC.ToString());
            setC = setB.Difference(setA);
            Console.WriteLine("B diff A: " + setC.ToString());
            if (setB.isSubset(setA))
            {
                Console.WriteLine("b is a subset of a");
            }
            else
            {
                Console.WriteLine("b is not a subset of a");
            }
            CloseConsole();
        }

        private void btnCset2_Click(object sender, EventArgs e)
        {
            ShowConsole("CSet2");
            CSet2 setA = new CSet2();
            CSet2 setB = new CSet2();
            CSet2 setC = new CSet2();

            setA.Add(1);
            setA.Add(2);
            setA.Add(3);

            setB.Add(2);
            setB.Add(3);



            setC = setA.Union(setB);

            Console.WriteLine();
            Console.WriteLine("A: " + setA.ToString());
            Console.WriteLine("B: " + setB.ToString());
            Console.WriteLine("A union B: " + setC.ToString());
            setC = setA.Intersection(setB);
            Console.WriteLine("A intersect B: " + setC.ToString());
            setC = setA.Difference(setB);
            Console.WriteLine("A diff B: " + setC.ToString());
            setC = setB.Difference(setA);
            Console.WriteLine("B diff A: " + setC.ToString());
            if (setB.isSubset(setA))
            {
                Console.WriteLine("b is a subset of a");
            }
            else
            {
                Console.WriteLine("b is not a subset of a");
            }
            CloseConsole();
        }

        private void btnBasicSearch_Click(object sender, EventArgs e)
        {
            new BasicSearch().Show();
        }

        private void btnStrings_Click(object sender, EventArgs e)
        {
            new Strings().Show();
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            new StringBuilderForm().Show();
        }
    }
}
