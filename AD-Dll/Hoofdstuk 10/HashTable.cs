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

        public void clear()
        {
            this.names = new string[10007];
        }

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
                else
                {
                    throw new ArgumentException("String of parameter incorrect");
                }
                names[hashVal] = name;
            }
            return names;
        }

        public static int SimpleHash(string s, string[] arr)
        {
            int tot = 0;
            char[] cname;
            cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
                tot += (int)cname[i];
            return tot % arr.GetUpperBound(0);
        }

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


    }
}
