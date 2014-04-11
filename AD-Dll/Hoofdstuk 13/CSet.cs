using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.hoofdstuk_13
{
    public class CSet<T>
    {
        private Dictionary<int, T> data;
        private int count;

        public CSet()
        {
            data = new Dictionary<int, T>();
            count = 0;
        }

        public void Add(T item)
        {
            if (!(data.ContainsValue(item)))
            {
                int Key = count;
                count++;
                data.Add(Key, item);
            }
        }

        public void Remove(int key)
        {
            data.Remove(key);
        }

        public int Size()
        {
            return data.Count;
        }

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

        public bool isSubset(CSet<T> aSet)
        {
            if (this.Size() > aSet.Size())
                return false;
            else
                foreach (T key in this.data.Values)
                    if (!(aSet.data.ContainsValue(key)))
                        return false;
            return true;
        }

        public CSet<T> Difference(CSet<T> aSet)
        {
            CSet<T> tempSet = new CSet<T>();
            foreach (T tObject in data.Values)
                if (!(aSet.data.ContainsValue(tObject)))
                    tempSet.Add((T)tObject);
            return tempSet;
        }

        public override string ToString()
        {
            string s = "";
            foreach (int key in data.Keys)
                s += data[key] + " ";
            return s;
        }

    }

}