using System;
using System.Collections.Generic;

namespace AD_Dll.Hoofdstuk_1
{
    /// <summary>
    /// Raymon Bunt
    /// Deze klasse maakt een list aan waar je feitelijk alles in kan opslaan
    /// </summary>
    /// <typeparam name="T">Het type gegevens dat wordt opgeslagen in het object</typeparam>
    public class Generics<T> where T : IComparable
    {
        List<T> list = new List<T>();

        /// <summary>
        /// Item toevoegen aan de list
        /// </summary>
        /// <param name="item">Het item dat je aan de list gaat toevoegen</param>
        public void addToList(T item)
        {
            list.Add(item);
        }
    }
}
