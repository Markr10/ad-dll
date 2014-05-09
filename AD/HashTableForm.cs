using AD_Dll.Hoofdstuk_10;
using System;

namespace AD
{
    public partial class HashTableForm : FormConsole
    {
        private HashTable hTable;

        public HashTableForm() : base(false)
        {
            InitializeComponent();
            string[] newNames = new string[6] { "Mark", "Danny", "Thomas", "Reinier", "Wybren", "Raymon" };
            hTable = new HashTable(newNames);

        }

        private void btnBetterHash_Click(object sender, EventArgs e)
        {
            ShowConsole("BetterHash");
            string[] betterHash = hTable.getHashTable("BetterHash");
            foreach (string name in betterHash)
            {
                Console.WriteLine(name);
            }
            CloseConsole();
        }

        private void btnSimpleHash_Click(object sender, EventArgs e)
        {
            ShowConsole("SimpleHash");
            string[] simpleHash = hTable.getHashTable("SimpleHash");
            foreach (string name in simpleHash)
            {
                Console.WriteLine(name);
            }
            CloseConsole();
        }
    }
}
