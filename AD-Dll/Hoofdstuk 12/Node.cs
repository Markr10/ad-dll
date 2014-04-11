using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_12
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;

        /// <summary>
        /// Standaard constructor.
        /// </summary>
        /// <remarks>
        /// De constructor van deze klasse is standaard leeg.
        /// </remarks>
        public Node(){}

        public override string ToString()
        {
            return Data.ToString();
        }

        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }

    
}
