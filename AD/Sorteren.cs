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
using AD_Dll.Hoofdstuk_3;

namespace AD
{
    public partial class Sorteren : Form
    {
        private ProcessTimer t = new ProcessTimer();

        public Sorteren()
        {
            InitializeComponent();
        }

        private int[] getArray()
        {
            string text = textBox1.Text;
            string[] textArray = text.Split();
            int[] intArray = new int[textArray.Length];
            for (int i = 0; i < textArray.Length; i++)
            {
                int.TryParse(textArray[i], out intArray[i]);
            }
            return intArray;
        }
        private Object thisLock = new Object();

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            inputArray.Clear();
            inputArray.Text = textBox1.Text.ToString();
            lock(thisLock)
            {
            t.Start();
            for (int times = 0; times < 99; times++)
            {
                outputArray.Text = new BubbleSort().Start(getArray());
            }
            t.Stop();
            }
            
            textBox2.Text = t.Duration(1).ToString();
        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
            inputArray.Clear();
            inputArray.Text = textBox1.Text.ToString();
            t.Start();
            for (int times = 0; times < 99; times++)
            {
                outputArray.Text = new InsertionSort().Start(getArray());
            }
                t.Stop();
            textBox3.Text = t.Duration(1).ToString();
        }

        private void SelectionSort_Click(object sender, EventArgs e)
        {
            inputArray.Clear();
            inputArray.Text = textBox1.Text.ToString();
            t.Start();
            for (int times = 0; times < 99; times++)
            {
                outputArray.Text = new SelectionSort().Start(getArray());
            }
            t.Stop();
            textBox4.Text = t.Duration(1).ToString();
        }

        private void random_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            String values;
            Random r = new Random();
            for (int rand = 0; rand < 50; rand++)
            {
                int number = r.Next(0, 200);
                values = textBox1.Text;
                textBox1.Text = values + " " + number;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
