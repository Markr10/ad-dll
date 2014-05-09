using AD_Dll.Hoofdstuk_1;
using System;
using System.Collections.Generic;

namespace AD
{
    public partial class GenericStudent : FormConsole
    {
        public GenericStudent() : base(false)
        {
            InitializeComponent();
            CreateOutput();
        }

        public void CreateOutput()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { Name = "Wybren", Age = 21, StudentID = 282235 });
            list.Add(new Student() { Name = "Raymon", Age = 20, StudentID = 197955 });
            list.Add(new Student() { Name = "Mark", Age = 20, StudentID = 255815 });


            // Gebruikt IComparable.CompareTo()
            list.Sort();

            ShowConsole("Generics");
            // Gebruikt Student.ToString()
            foreach (var element in list)
            {
                textBox1.Text += element.ToString() + "\r\n";
                Console.WriteLine(element);
            }
            CloseConsole();
        }
    }
}
