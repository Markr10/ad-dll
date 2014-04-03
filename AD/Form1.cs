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

namespace AD
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new ActionMeasurement().MeasureMilliseconds(RandomIteration).ToString());
        }

        private void Sorteren_Click(object sender, EventArgs e)
        {
            Form sort = new Sorteren();
            sort.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Student> list = new List<Student>();
            list.Add(new Student() { Name = "Steve", Salary = 10000 });
            list.Add(new Student() { Name = "Janet", Salary = 10000 });
            list.Add(new Student() { Name = "Andrew", Salary = 10000 });
            list.Add(new Student() { Name = "Bill", Salary = 500000 });
            list.Add(new Student() { Name = "Lucy", Salary = 8000 });

            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses Student.ToString
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
