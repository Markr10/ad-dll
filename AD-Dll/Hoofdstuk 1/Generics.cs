using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_1
{
    /// <summary>
    /// Raymon Bunt
    /// deze klasse maakt een list aan waar je feitelijk alles in kan opslaan
    /// </summary>
    /// <typeparam name="T">T staat voor dat je alle datatypen kan opslaan</typeparam>
    public class Generics<T> where T : IComparable
    {
        List<T> list = new List<T>();

        /// <summary>
        /// item toevoegen aan de list
        /// </summary>
        /// <param name="item">het item dat je aan de list gaat toevoegen</param>
        public void addToList(T item)
        {
            list.Add(item);
        }


        
    }

}