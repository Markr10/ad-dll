using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/**
 * Wybren Jongstra
 * A class to explain the working of Stacks
 */

namespace AD_Dll.Hoofdstuk_5
{
    public class Stacks
    {
        static Stacks()
        {
            //Fill the Stack
            Stack<char> st = new Stack<char>();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            //Add 'v' and 'h' to the stack
            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            //Remove 3 items out the Stack
            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }
    }
}
