using System;
using System.Text;

namespace AD_Dll
{
    /// <summary>
    /// Methodes die niet specifiek bij een hoofdstuk horen.
    /// </summary>
    public class Other
    {
        public static readonly Random rndObj = new Random();

        /// <summary>
        /// Generates a random string with the given length
        /// </summary>
        /// <param name="length">The length of the string</param>
        /// <returns>A random string</returns>
        public static string getRandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < length; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rndObj.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
