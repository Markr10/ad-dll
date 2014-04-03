using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_1
{
    public class Generics<T> where T : IComparable
    {
        List<T> list = new List<T>();

        public void addToList(T item)
        {
            list.Add(item);
        }


        
    }

}