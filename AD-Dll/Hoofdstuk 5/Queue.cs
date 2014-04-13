using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_5
{
    public class Queue
    {
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
