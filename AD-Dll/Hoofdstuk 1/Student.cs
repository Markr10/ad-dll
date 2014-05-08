using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_1
{
    /// <summary>
    /// Raymon Bunt
    /// Een Student klasse om een student aan te maken
    /// </summary>
    public class Student : IComparable<Student>
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public int StudentID { get; set; }

        /// <summary>
        /// Vergelijkt een student met een andere student
        /// </summary>
        /// <param name="other">De andere student</param>
        /// <returns>Wanneer studentID van this.StudentID groter is dan other wordt 1 gereturned anders 0</returns>
        public int CompareTo(Student other)
        {
            // return de studentID
            if (this.StudentID > other.StudentID)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            // String representation.
            return this.Name.ToString() + ", " + this.StudentID;
        }

        /// <summary>
        /// Maakt een randomStudent aan
        /// </summary>
        /// <returns>Een nieuwe student</returns>
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
