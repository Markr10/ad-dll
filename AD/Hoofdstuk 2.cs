using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_1;
using AD_Dll.Hoofdstuk_2;
using AD_Dll;

namespace AD
{
    public partial class Hoofdstuk_2 : FormConsole
    {
        private Student[] students;
        private Student[] studentsOtherSchool;
        private int[,] grades;
        private double[,] sales;

        public Hoofdstuk_2() : base(false)
        {
            InitializeComponent();
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            students = new Student[3];
            students[0] = Student.getRandomStudent();
            students.SetValue(Student.getRandomStudent(), 1);

            studentsOtherSchool = new Student[]
            {
                Student.getRandomStudent(),
                Student.getRandomStudent(),
                Student.getRandomStudent(),
                Student.getRandomStudent(),
                Student.getRandomStudent(),
                Student.getRandomStudent()
            };

            btnShowArrays.Enabled = btnShowInfoArrays.Enabled = true;
        }

        private void btnShowArrays_Click(object sender, EventArgs e)
        {
            WriteFirstLine("students array:", "Student Arrays");
            for (int i = 0; i <= students.GetUpperBound(0); i++)
            {
                Console.Write(i.ToString() + ": ");
                if(students[i] == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(students[i].ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("studentsOtherSchool array:");
            for (int i = 0; i <= studentsOtherSchool.GetUpperBound(0); i++)
            {
                if (studentsOtherSchool[i] == null)
                {
                    Console.WriteLine(i.ToString() + ": " + "null");
                }
                else
                {
                    Console.WriteLine("{0}: {1}", i, studentsOtherSchool.GetValue(i));
                }
            }
            CloseConsole();
        }

        private void btnShowInfoArrays_Click(object sender, EventArgs e)
        {
            ShowConsole("Information about the Student Arrays");
            CustomMethods.printInfoAboutArray(students, "students array");
            Console.WriteLine();
            CustomMethods.printInfoAboutArray(studentsOtherSchool, "studentsOtherSchool array");
            CloseConsole();
        }

        private void btnCreateMDArrays_Click(object sender, EventArgs e)
        {
            sales = new double[4,5];
            grades = new int[,]
            {
                {1, 82, 74, 89, 100},
                {2, 93, 96, 85, 86},
                {3, 83, 72, 95, 89},
                {4, 91, 98, 79, 88}
            };

            sales.SetValue(4, 0, 0);
            sales.SetValue(105, 0, 1);
            sales[0, 2] = 25;
            sales[0, 3] = 57;
            sales[0, 4] = 309;

            for (int row = 1, lengthRow = sales.GetLength(0); row < lengthRow; row++)
            {
                for (int column = 0, lengthColumn = sales.GetLength(1); column < lengthColumn; column++)
                {
                    sales.SetValue(Other.rndObj.Next(0, 1000), row, column);
                }
            }

            btnShowMDArrays.Enabled = btnShowInfoMDArrays.Enabled = true;
        }

        private void btnShowMDArrays_Click(object sender, EventArgs e)
        {
            WriteFirstLine("grades array:", "Multidimensional Arrays");
            CustomMethods.print2DArray<int>(grades);
            Console.WriteLine();
            Console.WriteLine("sales array:");
            CustomMethods.print2DArray<double>(sales);
            CloseConsole();
        }

        private void btnShowInfoMDArrays_Click(object sender, EventArgs e)
        {
            WriteFirstLine("grades array:", "Information about multidimensional Arrays");
            Console.WriteLine("The first item of the grades array is: {0}", grades.GetValue(0, 0));
            CustomMethods.calculateAndPrintAverages(grades);
            Console.WriteLine();
            Console.WriteLine("sales array:");
            Console.WriteLine("The first item of the sales array is: {0}", sales[0, 0]);
            CustomMethods.calculateAndPrintAverages(sales);
            CloseConsole();
        }
    }
}
