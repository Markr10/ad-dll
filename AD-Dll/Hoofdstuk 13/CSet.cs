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
    /// Set klasse
    /// </summary>
    /// <typeparam name="T">Het type gegevens dat is opgeslagen in de klasse</typeparam>
    public class CSet<T>
    {
        private Dictionary<int, T> data;
        private int count;

        /// <summary>
        /// Constructor maakt dictionary aan en een count variabele
        /// </summary>
        public CSet()
        {
            data = new Dictionary<int, T>();
            count = 0;
        }

        /// <summary>
        /// Item toevoegen
        /// </summary>
        /// <param name="item">Item dat toevoegd moet worden</param>
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
        /// Item verwijderen
        /// </summary>
        /// <param name="key">De key van de value die verwijderd moet worden</param>
        public void Remove(int key)
        {
            data.Remove(key);
        }

        /// <summary>
        /// De lengte van de set opvragen
        /// </summary>
        /// <returns>De lengte van de set</returns>
        public int Size()
        {
            return data.Count;
        }

        /// <summary>
        /// Union methode, twee sets samenvoegen
        /// </summary>
        /// <param name="aSet">De set die samengevoegd moet worden</param>
        /// <returns>Een samengevoegde set</returns>
        public CSet<T> Union(CSet<T> aSet)
        {
            CSet<T> tempSet = new CSet<T>();
            foreach (T tObject in data.Values)
            {
                tempSet.Add(tObject);
            }
            foreach (T tObject in aSet.data.Values)
            {
                if (!(this.data.ContainsValue(tObject)))
                {
                    tempSet.Add(tObject);
                }
            }
            return tempSet;
        }


        /// <summary>
        /// Intersection methode, deze methode zoekt de overeenkomsten
        /// </summary>
        /// <param name="aSet">De set die gecheckt moet worden op overeenkomsten</param>
        /// <returns>De overeenkomsten</returns>
        public CSet<T> Intersection(CSet<T> aSet)
        {
            CSet<T> tempSet = new CSet<T>();
            foreach (T tObject in data.Values)
            {
                if (aSet.data.ContainsValue(tObject))
                {
                    tempSet.Add((T)tObject);
                }
            }
            return tempSet;
        }

        /// <summary>
        /// isSubset methode, checkt of de set ook in een andere set bestaat
        /// </summary>
        /// <param name="aSet">De set die gecheckt moet worden</param>
        /// <returns>true of false</returns>
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
        /// <param name="aSet">De set die gecheckt moet worden</param>
        /// <returns>De verschillen tussen de sets</returns>
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

        /// <summary>
        /// Aangepaste ToString methode
        /// </summary>
        /// <returns>De String voor de ToString methode</returns>
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
