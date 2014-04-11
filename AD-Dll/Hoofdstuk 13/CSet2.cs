using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_13
{
    public class CSet2
    {
        private BitArray data;

        public CSet2()
        {
            data = new BitArray(5);
        }

        public void Add(int item)
        {
            data[item] = true;
        }

        public void Remove(int item)
        {
            data[item] = false;
        }

        public CSet2 Union(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                tempSet.data[i] = (this.data[i] || aSet.data[i]);
            }
            return tempSet;
        }

        public CSet2 Intersection(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                tempSet.data[i] = (this.data[i] && aSet.data[i]);
            }
            return tempSet;
        }

        public CSet2 Difference(CSet2 aSet)
        {
            CSet2 tempSet = new CSet2();
            for (int i = 0; i <= data.Count - 1; i++)
            {
                tempSet.data[i] = (this.data[i] && !(aSet.data[i]));
            }
            return tempSet;
        }

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