using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_10
{
    /// <summary>
    /// Reinier Gombert
    /// </summary>
    public class BucketHash
    {
        private const int SIZE = 101;
        ArrayList[] data;
        /// <summary>
        /// De constructor zorgt er hier voor dat er een arraylist gevuld wordt
        /// met meerdere arraylists
        /// </summary>
        public BucketHash()
        {
            data = new ArrayList[SIZE];
            for (int i = 0; i <= SIZE - 1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }
        /// <summary>
        /// behandeld een in te voeren waarde om te gaan hashen
        /// </summary>
        /// <param name="s">een string die ingevoerd wordt om te verwerken</param>
        /// <returns>totaal van de hashwaarde(index) waar de ingevoerde string is verwerkt</returns>
        public int Hash(string s)
        {
            long tot = 0;
            char[] charray;
            charray = s.ToCharArray();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                int tempval = Convert.ToInt32(tot);
                tot += 37 * tempval + (int)charray[i];
            }
            tot = tot % data.GetUpperBound(0);
            if (tot < 0)
            {
                tot += data.GetUpperBound(0);
            }
            return (int)tot;
        }

        /// <summary>
        /// invoeren waarde in hash
        /// </summary>
        /// <param name="item">in te voeren waarde</param>
        public void Insert(string item)
        {
            int hash_value;
            hash_value = Hash(item);
            if (data[hash_value].Contains(item))
            {
                data[hash_value].Add(item);
            }
        }

        /// <summary>
        /// de te verwijderen item
        /// </summary>
        /// <param name="item">item</param>
        public void Remove(string item)
        {
            int hash_value;
            hash_value = Hash(item);
            if (data[hash_value].Contains(item))
            {
                data[hash_value].Remove(item);
            }
        }
    }
}
