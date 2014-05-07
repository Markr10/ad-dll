using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_1
{
    public class Student : IComparable<Student>
    {
        /// <summary>
        /// Raymon Bunt
        /// student class maakt een student aan
        /// </summary>
        

        public String Name { get; set; }
        public int Age { get; set; }
        public int StudentID{ get; set;}


        /// <summary>
        /// vergelijkt een student met een andere student
        /// </summary>
        /// <param name="other">de andere student</param>
        /// <returns>als de studentID van this.StudentID groter is dan de other dan returnt hij 1 anders 0</returns>
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

        
        /// <summary>
        /// maakt een randomStudent aan
        /// </summary>
        /// <returns>nieuwe student</returns>
        public static Student getRandomStudent()
        {
            return new Student()
            {
                Name = Other.getRandomString(Other.rndObj.Next(3, 11)).ToLowerInvariant(),
                Age = Other.rndObj.Next(16, 31),
                StudentID = Other.rndObj.Next(180000, 400001)
            };
        }

        
    }

}
