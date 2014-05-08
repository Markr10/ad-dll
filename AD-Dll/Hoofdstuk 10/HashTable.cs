using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_10
{
    /// <summary>
    /// Reinier Gombert
    /// Een klasse om een demonstratie te geven van hoe hash functies werken.
    /// </summary>
    public class HashTable
    {
        // variabelen declareren
        private string[] names;
        private string name;
        private string[] someNames;
        private int hashVal;

        /// <summary>
        /// HashTable constructor
        /// </summary>
        /// <param name="someNames">De namen die in deze hashtable opgeslagen moeten worden</param>
        public HashTable(string[] someNames)
        {
            clear();
            this.someNames = someNames;
        }

        /// <summary>
        /// Maak de hashtable leeg
        /// </summary>
        public void clear()
        {
            this.names = new string[29];
        }

        /// <summary>
        /// Kijken welke hashtable er aangemaakt moet worden (SimpleHash, BetterHash of BucketHash) en
        /// maak deze aan en return de waarden
        /// </summary>
        /// <param name="nameHash">De naam van de hashtable</param>
        /// <returns>De gehashte array</returns>
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

        /// <summary>
        /// Stukje voor het aanmaken van een simple hash
        /// </summary>
        /// <param name="s">De waarde die gehasht moet worden</param>
        /// <param name="arr">De array waaraan het item moet worden toegevoegd</param>
        /// <returns>De index waar het item moet staan</returns>
        public static int SimpleHash(string s, string[] arr)
        {
            int tot = 0;
            char[] cname;
            cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
            {
                tot += (int)cname[i];
            }
            return tot % arr.GetUpperBound(0);
        }

        /// <summary>
        /// Stukje voor het aanmaken van een better hash
        /// </summary>
        /// <param name="s">De waarde die gehasht moet worden</param>
        /// <param name="arr">De array waaraan het item moet worden toegevoegd</param>
        /// <returns>De index waar het item moet staan</returns>
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

        /// <summary>
        /// Zoeken in de hashtable
        /// </summary>
        /// <param name="s">De gezochte waarde</param>
        /// <param name="arr">De array waarin gezocht moet worden</param>
        /// <returns>Of de waarde gevonden is</returns>
        public static bool InHash(string s, string[] arr)
        {
            int hval = BetterHash(s, arr);
            if (arr[hval] == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
