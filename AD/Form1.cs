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
    public partial class Form1 : FormConsole
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
            list.Add(new Student() { Name = "Wybren", Age = 21, StudentID = 282235 });
            list.Add(new Student() { Name = "Raymon", Age = 20, StudentID = 197955 });
            list.Add(new Student() { Name = "Mark", Age = 20, StudentID = 255815 });
            

            // Uses IComparable.CompareTo()
            list.Sort();

            ShowConsole("Generics");
            // Uses Student.ToString
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            CloseConsole();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Voorkom dat wanneer de applicatie via cmd.exe aangeroepen is, cmd.exe afgesloten wordt.
            Program.setConsoleWindowVisibility(true);
        }
    }
}
