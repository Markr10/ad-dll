using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.hoofdstuk_13
{
    public class CSet
    {
        private Hashtable data;
        private int hashValue;

        public CSet()
        {
            data = new Hashtable();
        }

        public void Add(Object item)
        {
            if (!(data.ContainsValue(item)))
            {
                data.Add(Hash(item), item);
            }
        }

        private string Hash(Object item)
        {
            char[] chars;
            string s = item.ToString();
            chars = s.ToCharArray();
            
            
            for (int i = 0; i <= chars.GetUpperBound(0); i++)
            {
                hashValue += (int)chars[i];

            }
            return hashValue.ToString();
        }

        public void Remove(Object item)
        {
            data.Remove(Hash(item));
        }

        public int Size()
        {
            return data.Count;
        }

    }
}
