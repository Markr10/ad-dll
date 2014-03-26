using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AD_Dll.Hoofdstuk_10;

namespace AD_ConsoleApplication
{
    class Hash
    {
        HashTable customHashTable;

        public Hash()
        {
            customHashTable = new HashTable(new string[]{"David",
"Jennifer", "Donnie", "Mayo", "Raymond",
"Bernica", "Mike", "Clayton", "Beata", "Michael"});
        }

        public void printHashTableSimpleHash()
        {
            ShowDistrib(customHashTable.getHashTable("SimpleHash"));
        }

        public void printHashTableBetterHash()
        {
            ShowDistrib(customHashTable.getHashTable("BetterHash"));
        }

        public void printHashTableCorruptHash()
        {
            ShowDistrib(customHashTable.getHashTable("3"));
        }

        public void ShowDistrib(string[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] != null)
                    Console.WriteLine(i + " " + arr[i]);
            }
            Console.WriteLine();
        }
    }
}
