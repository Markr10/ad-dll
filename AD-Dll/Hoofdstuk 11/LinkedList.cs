using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_11
{
    /// <summary>
    /// Thomas Oldengarm
    /// LinkedList klasse
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// LinkedList aanmaken, items aanmaken, items toevoegen en items weergeven
        /// </summary>
        public static void Main()
        {
            LinkedListNode<string> node = new LinkedListNode<string>("Mike");
            LinkedList<string> names = new LinkedList<string>();
            names.AddFirst(node);
            LinkedListNode<string> node1 = new LinkedListNode<string>("David");
            names.AddAfter(node, node1);
            LinkedListNode<string> node2 = new LinkedListNode<string>("Raymond");
            names.AddAfter(node1, node2);
            LinkedListNode<string> node3 = new LinkedListNode<string>("Johan");
            names.AddAfter(node1, node3);
            LinkedListNode<string> node4 = new LinkedListNode<string>(null);

            LinkedListNode<string> aNode = names.First; // eerste item
            while (aNode != null) // gaat langs alle items
            {
                Console.WriteLine(aNode.Value); // display item
                aNode = aNode.Next; // pak volgende item
            }

            Console.WriteLine(); // witregel

            LinkedList<int> nums = new LinkedList<int>(); // nieuwe LinkedList
            nums.AddLast(11); // items toevoegen
            nums.AddLast(6);
            nums.AddFirst(9);
            nums.AddLast(7);
            LinkedListNode<int> intnode = nums.Find(6);
            nums.AddBefore(intnode, 5);
            foreach (int num in nums)
            {
                Console.WriteLine(num); // laat alle items zien
            }
        }
    }
}
