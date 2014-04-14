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
using System.Collections;

namespace AD
{
    public partial class ArrayAndArrayLists : FormConsole
    {
        private Student[] students;
        private Student[] studentsOtherSchool;
        private int[,] grades;
        private double[,] sales;
        private ArrayList gradesAL;
        private ArrayList names;

        public ArrayAndArrayLists() : base(false)
        {
            InitializeComponent();
        }

        private void btnCreateArrays_Click(object sender, EventArgs e)
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
            ShowConsole("Student Arrays");
            CustomMethods.printArray<Student>(students, "students array:");
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
            PauseConsole();
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

        private void btnSumNums_Click(object sender, EventArgs e)
        {
            WriteFirstLine("The sum of 1, 2, 3 is: " + CustomMethods.sumNums(1, 2, 3).ToString(), "Sum numbers");
            
            int[] numbersOneTillTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomMethods.sumNumsAndPrint(numbersOneTillTen);
            
            CustomMethods.sumNumsAndPrint(Other.rndObj.Next(0, 101), Other.rndObj.Next(0, 101),
                Other.rndObj.Next(0, 101), Other.rndObj.Next(0, 101), Other.rndObj.Next(0, 101));
            
            CloseConsole();
        }

        private void btnShowAJaggedArray_Click(object sender, EventArgs e)
        {
            int[][] jagged = new int[12][];
            jagged[0] = new int[2];
            jagged[0][0] = 23;
            jagged[0][1] = 13;
            jagged[7] = new int[6];
            jagged[7][0] = 65;
            jagged[7][1] = 28;
            jagged[7][2] = 93;
            jagged[7][3] = 26;
            jagged[7][4] = 19;
            jagged[7][5] = 45;
            CustomMethods.fillJaggedArrayRows(jagged, 1, 7, 10, 100, 1, 10);
            CustomMethods.fillJaggedArrayRows(jagged, 8, 12, 10, 100, 1, 10);
            ShowConsole("Jagged Array");
            CustomMethods.printJaggedArray<int>(jagged);
            CloseConsole();
        }

        private void btnJaggedArraySales_Click(object sender, EventArgs e)
        {
            int[] jan = new int[31];
            int[] feb = new int[29];
            int[][] sales = new int[][] { jan, feb };
            sales[0][0] = 41;
            sales[0][1] = 30;
            sales[0][2] = 23;
            sales[0][3] = 34;
            sales[0][4] = 28;
            sales[0][5] = 35;
            sales[0][6] = 45;
            sales[1][0] = 35;
            sales[1][1] = 37;
            sales[1][2] = 32;
            sales[1][3] = 26;
            sales[1][4] = 45;
            sales[1][5] = 38;
            sales[1][6] = 42;
            ShowConsole("Average sales with jagged Array");
            CustomMethods.calculateAndPrintAverages(sales, "sales for month", 2);
            CloseConsole();
        }

        private void btnCreateArrayLists_Click(object sender, EventArgs e)
        {
            gradesAL = new ArrayList();
            gradesAL.Add(100);
            gradesAL.Add(84);
            gradesAL.Insert(1, 99);
            gradesAL.Insert(3, 80);

            names = new ArrayList();
            names.Add("Mike");
            names.Add("Beata");
            names.Add("Raymond");
            names.Add("Bernica");
            names.Add("Jennifer");

            btnGetPositionArrayList.Enabled = btnAverageArrayList.Enabled =
                btnRemoveItemsArrayList.Enabled = btnShowInformationArrayList.Enabled =
                btnDemoALRangeMethods.Enabled = btnDemoALToArrayMethod.Enabled = true;
        }

        private void btnGetPositionArrayList_Click(object sender, EventArgs e)
        {
            WriteFirstLine("The grade 77 was added at position: " + gradesAL.Add(77).ToString(),
                "Get position of new item in ArrayList");
            CloseConsole();
        }

        private void btnAverageArrayList_Click(object sender, EventArgs e)
        {
            ShowConsole("Average grade in ArrayList");
            CustomMethods.calculateAndPrintAverages(gradesAL, "grade", 2);
            CloseConsole();
        }

        private void btnRemoveItemsArrayList_Click(object sender, EventArgs e)
        {
            ShowConsole("Remove Items for ArrayList");
            CustomMethods.removeAndPrint(gradesAL, 54);
            CustomMethods.removeAtAndPrint(gradesAL, (Object)70);
            CustomMethods.removeAtAndPrint(gradesAL, 2);
            CloseConsole();
        }

        private void btnShowInformationArrayList_Click(object sender, EventArgs e)
        {
            ShowConsole("Information about grades ArrayList");
            Console.WriteLine("The current capacity of the grades ArrayList is: " + gradesAL.Capacity.ToString());
            Console.WriteLine("The number of grades in the grades ArrayList is: " + gradesAL.Count.ToString());
            CloseConsole();
        }

        private void btnDemoALRangeMethods_Click(object sender, EventArgs e)
        {
            ShowConsole("Demonstration of the AddRange and InsertRange methods from ArrayList");
            CustomMethods.printArrayList(names, "The original list of names: ");

            string[] newNames = new string[]
            {
                "David",
                "Michael"
            };
            ArrayList moreNames = new ArrayList();
            moreNames.Add("Terrill");
            moreNames.Add("Donnie");
            moreNames.Add("Mayo");
            moreNames.Add("Clayton");
            moreNames.Add("Alisa");

            names.InsertRange(0, newNames);
            names.AddRange(moreNames);

            Console.WriteLine();
            CustomMethods.printArrayList(names, "The new list of names: ");
            CloseConsole();

            btnDemoALGetRangeMethod.Enabled = true;
        }

        private void btnDemoALGetRangeMethod_Click(object sender, EventArgs e)
        {
            ArrayList someNames = new ArrayList(names.GetRange(2, 4));
            ShowConsole("Demonstration of the GetRange method from ArrayList");
            CustomMethods.printArrayList(someNames, "someNames sub-ArrayList: ");
            CloseConsole();
        }

        private void btnDemoALToArrayMethod_Click(object sender, EventArgs e)
        {
            Object[] arrNames = names.ToArray();
            ShowConsole("Demonstration of the ToArray method from ArrayList");
            CustomMethods.printArray<Object>(arrNames, "Names from an array: ");
            CloseConsole();
        }
    }
}
