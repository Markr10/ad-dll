using System;
using System.Collections;
using System.Collections.Generic;

namespace AD_Dll.Hoofdstuk_5
{
    /// <summary>
    /// Wybren Jongstra
    /// Deze klasse verduidelijkt de werking van Stacks
    /// </summary>
    public class Stacks
    {
        /// <summary>
        /// In de constructor wordt een Stack aangemaakt.
        /// Vervolgens wordt de Stack gevuld (push).
        /// Er wordt daarna gekeken welke waarde als eerste in de stack staat (peek).
        /// Tenslotte worden er nog 3 items verwijderd (remove).
        /// </summary>
        public Stacks()
        {
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

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

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
