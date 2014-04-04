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
    public partial class GenericStudent : FormConsole
    {
        public GenericStudent()
        {
            InitializeComponent();
            CreateOutput();
        }

        private void GenericStudent_Load(object sender, EventArgs e)
        {

        }

        public void CreateOutput()
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
                textBox1.Text += element.ToString() + "\r\n";
                Console.WriteLine(element);
            }
            CloseConsole();
        }

    }
}
