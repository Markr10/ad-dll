using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_13
{
    /// <summary>
    /// Raymon Bunt
    /// BitArray Set
    /// </summary>
    public class CSet2
    {
        private BitArray data;

        /// <summary>
        /// Constructor maakt nieuwe bitarray met lengte 5
        /// </summary>
        public CSet2()
        {
            data = new BitArray(5);
        }

        /// <summary>
        /// Item toevoegen aan bitarray
        /// </summary>
        /// <param name="item">Item dat toevoegd moet worden</param>
        public void Add(int item)
        {
            data[item] = true;
        }

        /// <summary>
        /// Item verwijderen uit bitarray
        /// </summary>
        /// <param name="item">Item dat verwijderd moet worden</param>
        public void Remove(int item)
        {
            data[item] = false;
        }

        /// <summary>
        /// Union methode, twee sets samenvoegen
        /// </summary>
        /// <param name="aSet">Is de set die je wilt gaan samenvoegen</param>
        /// <returns>Een samengevoegde set</returns>
        public CSet2 Union(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                tempSet.data[i] = (this.data[i] || aSet.data[i]);
            }
            return tempSet;
        }

        /// <summary>
        /// Intersection methode, deze methode zoekt de overeenkomsten
        /// </summary>
        /// <param name="aSet">Is de set die je wilt gaan checken op overeenkomsten</param>
        /// <returns>De overeenkomsten</returns>
        public CSet2 Intersection(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                tempSet.data[i] = (this.data[i] && aSet.data[i]);
            }
            return tempSet;
        }

        /// <summary>
        /// Difference methode kijkt naar de verschillen in de sets
        /// </summary>
        /// <param name="aSet">De set die je wilt gaan checken</param>
        /// <returns>De verschillen tussen de sets</returns>
        public CSet2 Difference(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                tempSet.data[i] = (this.data[i] && !(aSet.data[i]));
            }
            return tempSet;
        }

        /// <summary>
        /// isSubset methode, checkt of de set ook in een andere set bestaat
        /// </summary>
        /// <param name="aSet">De set die je wilt gaan checken</param>
        /// <returns>true of false</returns>
        public bool isSubset(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                if (this.data[i] && !(aSet.data[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Aangepaste ToString methode
        /// </summary>
        /// <returns>De String voor de ToString methode</returns>
        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i <= data.Count - 1; i++)
            {
                if (data[i])
                {
                    s += i;
                }

            }
            return s;
        }

    }
}
