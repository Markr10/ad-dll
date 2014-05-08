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
        /// constructor maakt nieuwe bitarray met lengte 5
        /// </summary>
        public CSet2()
        {
            data = new BitArray(5);
        }

        /// <summary>
        /// item toevoegen aan bitarray
        /// </summary>
        /// <param name="item">item dat je wilt toevoegen</param>
        public void Add(int item)
        {
            data[item] = true;
        }

        /// <summary>
        /// item verwijderen uit bitarray
        /// </summary>
        /// <param name="item">item dat je wilt verwijderen</param>
        public void Remove(int item)
        {
            data[item] = false;
        }

        /// <summary>
        /// union methode, twee sets samenvoegen
        /// </summary>
        /// <param name="aSet">is de set die je wilt gaan samenvoegen</param>
        /// <returns>een samengevoegde set</returns>
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
        /// intersection methode, deze methode zoekt de overeenkomsten
        /// </summary>
        /// <param name="aSet">is de set die je wilt gaan checken op overeenkomsten</param>
        /// <returns>de overeenkomsten</returns>
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
        /// <param name="aSet">de set die je wilt gaan checken</param>
        /// <returns>de verschillen tussen de sets</returns>
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
        /// <param name="aSet">is de set die je wilt gaan checken</param>
        /// <returns>True of False</returns>
        public bool isSubset(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                if(this.data[i] && !(aSet.data[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i <= data.Count - 1; i++)
            {
                if(data[i])
                {
                    s += i;
                }
                
            }
            return s;
        }

    }
}