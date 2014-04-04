using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_1
{
    public class Student : IComparable<Student>
    {

        public String Name { get; set; }
        public int Age { get; set; }
        public int StudentID{ get; set;}

        public int CompareTo(Student other)
        {
            //return de studentID
            if (this.StudentID > other.StudentID)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return other.StudentID.CompareTo(this.StudentID);
            
        }

        public override string ToString()
        {
            // String representation.
            return this.Name.ToString() + ", " + this.StudentID;
        }
    }

}
