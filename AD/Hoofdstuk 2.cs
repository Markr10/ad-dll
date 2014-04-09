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

        public Hoofdstuk_2() : base(false)
        {
            InitializeComponent();
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            students = new Student[3];
            students[0] = Other.getRandomStudent();
            students.SetValue(Other.getRandomStudent(), 1);

            studentsOtherSchool = new Student[]
            {
                Other.getRandomStudent(),
                Other.getRandomStudent(),
                Other.getRandomStudent(),
                Other.getRandomStudent(),
                Other.getRandomStudent(),
                Other.getRandomStudent()
            };

            btnShowArrays.Enabled = btnShowInfoArrays.Enabled = true;
        }

        private void btnShowArrays_Click(object sender, EventArgs e)
        {
            WriteFirstLine("students array:", "Student Arrays");
            for (int i = 0; i <= students.GetUpperBound(0); i++)
            {
                if(students[i] == null)
                {
                    Console.WriteLine(i.ToString() + ": " +  "null");
                }
                else
                {
                    Console.WriteLine(i.ToString() + ": " + students[i].ToString());
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
            CustomArrayMethods.printInfoAboutArray(students, "students array");
            Console.WriteLine();
            CustomArrayMethods.printInfoAboutArray(studentsOtherSchool, "studentsOtherSchool array");
            CloseConsole();
        }
    }
}
