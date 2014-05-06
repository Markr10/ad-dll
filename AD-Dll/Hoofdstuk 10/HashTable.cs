using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_10
{
    //class HashTable<T> where T : IComparable<T>
    public class HashTable
    {
        /*
         * waarden initialiseren
         */
        private string[] names;
        private string name;
        private string[] someNames;
        private int hashVal;

        /// <summary>
        /// A class to demonstrate how hash functions work.
        /// </summary>
        public HashTable(string[] someNames)
        {
            clear();
            this.someNames = someNames;
        }

        /*
         * Maak de hashtable leeg
         */
        public void clear()
        {
            this.names = new string[29];
        }

        /*
         * kijken welke hashtable er aangemaakt moet worden (SimpleHash, BetterHash of BucketHash)
         * en maak deze aan en return de waarden
         */
        public string[] getHashTable(string nameHash)
        {
            clear();
            for (int i = 0; i <= someNames.GetUpperBound(0); i++)
            {
                name = someNames[i];
                if (nameHash.Equals("SimpleHash"))
                {
                    hashVal = SimpleHash(name, names);
                }
                else if (nameHash.Equals("BetterHash"))
                {
                    hashVal = BetterHash(name, names);
                }
                else if (nameHash.Equals("BucketHash"))
                {
                    BucketHash bHash = new BucketHash();
                    hashVal = bHash.Hash(name);
                }
                else
                {
                    throw new ArgumentException("String of parameter incorrect");
                }
                names[hashVal] = name;
            }
            return names;
        }

        /*
         * stukje voor het aanmaken van een simple hash
         */
        public static int SimpleHash(string s, string[] arr)
        {
            int tot = 0;
            char[] cname;
            cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
                tot += (int)cname[i];
            return tot % arr.GetUpperBound(0);
        }

        /*
         * stukje voor het aanmaken van een better hash
         */
        public static int BetterHash(string s, string[] arr)
        {
            long tot = 0;
            char[] cname;
            cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
            {
                tot += 37 * tot + (int)cname[i];
            }
            tot = tot % arr.GetUpperBound(0);
            return (int)tot;
        }

        /*
         * Zoeken in de hashtable
         */
        public static bool InHash(string s, string[] arr)
        {
            int hval = BetterHash(s, arr);
            if (arr[hval] == s)
                return true;
            else
                return false;
        }
    }
}
