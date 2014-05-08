using System;

namespace AD_Dll.Hoofdstuk_12
{
    /// <summary>
    /// Reinier Gombert
    /// Node klasse
    /// </summary>
    /// <typeparam name="T">Het type gegevens dat wordt opgeslagen in het object</typeparam>
    public class Node<T> where T : IComparable<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;

        /// <summary>
        /// Standaard constructor
        /// </summary>
        /// <remarks>De constructor van deze klasse is standaard leeg</remarks>
        public Node() { }

        /// <summary>
        /// Aangepaste ToString methode
        /// </summary>
        /// <returns>De String voor de ToString methode</returns>
        public override string ToString()
        {
            return Data.ToString();
        }

        /// <summary>
        /// De node laten zien
        /// </summary>
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
}
