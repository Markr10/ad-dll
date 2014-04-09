using AD_Dll.Hoofdstuk_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll
{
    public class Other
    {
        private static Random rndObj = new Random();

        /// <summary>
        /// Generates a random string with the given length.
        /// </summary>
        /// <param name="length">The length of the string.</param>
        /// <returns>A random string.</returns>
        public static string getRandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for(int i = 0; i < length; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rndObj.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public static Student getRandomStudent()
        {
            return new Student()
            {
                Name = getRandomString(rndObj.Next(3, 11)).ToLowerInvariant(),
                Age = rndObj.Next(16, 31),
                StudentID = rndObj.Next(180000, 400001)
            };
        }
    }
}
