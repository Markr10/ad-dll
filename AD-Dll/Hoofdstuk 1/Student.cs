using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_1
{
    public class Student : IComparable<Student>
    {

        public int Salary { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            // Alphabetic sort if salary is equal. [A to Z]
            if (this.Salary == other.Salary)
            {
                return this.Name.CompareTo(other.Name);
            }
            // Default to salary sort. [High to low]
            return other.Salary.CompareTo(this.Salary);
        }

        public override string ToString()
        {
            // String representation.
            return this.Salary.ToString() + "," + this.Name;
        }
    }

}
