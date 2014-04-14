using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_10;

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
            foreach(string key in )
            {
                if (!(name == ""))
                {
                    Console.WriteLine(name);
                }
            }
            CloseConsole();
        }
    }
}
