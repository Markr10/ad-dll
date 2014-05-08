using System;
using System.Collections.Generic;

namespace AD_Dll.Hoofdstuk_5
{
    /// <summary>
    /// Wybren Jongstra
    /// Deze klasse verduidelijkt de werking van Queues
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// In de constructor wordt een Queue aangemaakt.
        /// Vervolgens wordt de Queue gevuld (push).
        /// Er worden daarna nog eens 2 items toegevoegd.
        /// Tenslotte worden er nog 3 items verwijderd (remove).
        /// </summary>
        static Queue()
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("A");
            q.Enqueue("M");
            q.Enqueue("G");
            q.Enqueue("W");

            Console.WriteLine("Current queue: ");
            foreach (string c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            q.Enqueue("V");
            q.Enqueue("H");
            Console.WriteLine("Current queue: ");
            foreach (string c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing some values ");
            string ch = (string) q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (string) q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
        }
    }
}
