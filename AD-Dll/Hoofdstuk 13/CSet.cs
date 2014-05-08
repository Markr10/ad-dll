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
    /// Set class
    /// </summary>
    /// <typeparam name="T">Generic</typeparam>
    public class CSet<T>
    {
        private Dictionary<int, T> data;
        private int count;

        /// <summary>
        /// constructor maakt dictionary aan en een count variabele
        /// </summary>
        public CSet()
        {
            data = new Dictionary<int, T>();
            count = 0;
        }

        /// <summary>
        /// item toevoegen
        /// </summary>
        /// <param name="item">het item dat je gaat toevoegen</param>
        public void Add(T item)
        {
            if (!(data.ContainsValue(item)))
            {
                int Key = count;
                count++;
                data.Add(Key, item);
            }
        }

        /// <summary>
        /// item verwijderen
        /// </summary>
        /// <param name="key">de key van de value die je wilt verwijderen</param>
        public void Remove(int key)
        {
            data.Remove(key);
        }

        /// <summary>
        /// de lengte van de set opvragen
        /// </summary>
        /// <returns>int</returns>
        public int Size()
        {
            return data.Count;
        }

        /// <summary>
        /// union methode, twee sets samenvoegen
        /// </summary>
        /// <param name="aSet">is de set die je wilt gaan samenvoegen</param>
        /// <returns>een samengevoegde set</returns>
        public CSet<T> Union(CSet<T> aSet)
        {
            CSet<T> tempSet = new CSet<T>();
            foreach (T tObject in data.Values)
                tempSet.Add(tObject);
            foreach (T tObject in aSet.data.Values)
                if (!(this.data.ContainsValue(tObject)))
                    tempSet.Add(tObject);
            return tempSet;
        }


        /// <summary>
        /// intersection methode, deze methode zoekt de overeenkomsten
        /// </summary>
        /// <param name="aSet">is de set die je wilt gaan checken op overeenkomsten</param>
        /// <returns>de overeenkomsten</returns>
        public CSet<T> Intersection(CSet<T> aSet)
        {
            CSet<T> tempSet = new CSet<T>();
            foreach (T tObject in data.Values)
                if (aSet.data.ContainsValue(tObject))
                {
                    tempSet.Add((T)tObject);
                }
            return tempSet;
        }

        /// <summary>
        /// isSubset methode, checkt of de set ook in een andere set bestaat
        /// </summary>
        /// <param name="aSet">is de set die je wilt gaan checken</param>
        /// <returns>True of False</returns>
        public bool isSubset(CSet<T> aSet)
        {
            if (this.Size() > aSet.Size())
            {
                return false;
            }
            else
            {
                foreach (T key in this.data.Values)
                {
                    if (!(aSet.data.ContainsValue(key)))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Difference methode kijkt naar de verschillen in de sets
        /// </summary>
        /// <param name="aSet">de set die je wilt gaan checken</param>
        /// <returns>de verschillen tussen de sets</returns>
        public CSet<T> Difference(CSet<T> aSet)
        {
            CSet<T> tempSet = new CSet<T>();

            foreach (T tObject in data.Values)
            {
                if (!(aSet.data.ContainsValue(tObject)))
                {
                    tempSet.Add((T)tObject);
                }
            }
            return tempSet;
        }

        public override string ToString()
        {
            string s = "";

            foreach (int key in data.Keys)
            {
                s += data[key] + " ";
            }
            
            return s;
        }

    }

}