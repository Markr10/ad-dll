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
    }
}
