using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_12;

namespace AD
{
    public partial class BinarySearchTree : FormConsole
    {
        private BinarySearchTree<int> iBST;
        private BinarySearchTree<string> sBST;

        private string waarden;

        /*
         * Bij het laden van de form gelijk een nieuwe Binary Searchtree toevoegen.
         * Hierin zitten de waarden die bekeken en getest zullen worden
         */
        public BinarySearchTree() : base(false)
        {
            InitializeComponent();
            // initialize int BST
            iBST = new BinarySearchTree<int>();
            iBST.Insert(51);
            iBST.Insert(89);
            iBST.Insert(60);
            iBST.Insert(24);
            iBST.Insert(44);
            iBST.Insert(19);
            iBST.Insert(65);
            iBST.Insert(39);
            // initialize string BST
            sBST = new BinarySearchTree<string>();
            sBST.Insert("Mark");
            sBST.Insert("Thomas");
            sBST.Insert("Wybren");
            sBST.Insert("Raymon");
            sBST.Insert("Danny");
            sBST.Insert("Reinier");
            // default = int
            changeBST("int");
        }

        /*
         * In plaats van INT nu STRING objecten gebruiken, wanneer men daarvoor kiest op de form
         */
        private void changeBST(string datatype)
        {
            if (datatype == "int")
            {
                waarden = "int";
            }
            else if (datatype == "string")
            {
                waarden = "string";
            }
        }

        /*
         * Laat de waarden in order zien
         */
        private void btnInOrder_Click(object sender, EventArgs e)
        {
            ShowConsole("Binary Search Tree: In Order Search");
            if (waarden == "int")
            {
                iBST.InOrder(iBST.root);
            }
            else
            {
                sBST.InOrder(sBST.root);
            }
            CloseConsole();
        }

        /*
         * Laat de waarden in Pre order zien
         */
        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            ShowConsole("Binary Search Tree: Pre Order Search");
            if (waarden == "int")
            {
                iBST.PreOrder(iBST.root);
            }
            else
            {
                sBST.PreOrder(sBST.root);
            }
            CloseConsole();
        }

        /*
         * Laat de waarden in Post order zien
         */
        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            ShowConsole("Binary Search Tree: Post Order Search");
            if (waarden == "int")
            {
                iBST.PostOrder(iBST.root);
            }
            else
            {
                sBST.PostOrder(sBST.root);
            }
            CloseConsole();
        }

        /*
         * Vind de minimum waarde
         */
        private void btnFindMin_Click(object sender, EventArgs e)
        {
            ShowConsole("Binary Search Tree: Find Minimum value");
            if (waarden == "int")
            {
                Console.WriteLine(iBST.FindMin());
            }
            else
            {
                Console.WriteLine(sBST.FindMin());
            }
            CloseConsole();
        }

        /*
         * Vind de maximum waarde
         */
        private void btnFindMax_Click(object sender, EventArgs e)
        {
            ShowConsole("Binary Search Tree: Find Maximum value");
            if (waarden == "int")
            {
                Console.WriteLine(iBST.FindMax());
            }
            else
            {
                Console.WriteLine(sBST.FindMax());
            }
            CloseConsole();
        }

        /*
         * Vind een opgegeven waarde
         */
        private void btnFind_Click(object sender, EventArgs e)
        {
            ShowConsole("Binary Search Tree: Find 24");
            if (waarden == "int")
            {
                Console.WriteLine(iBST.Find(24));
            }
            else
            {
                Console.WriteLine(sBST.Find("24"));
            }
            CloseConsole();
        }

        /*
         * stukje voor het verwerken van het indrukken van de radio-buttons
         */
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changeBST("int");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changeBST("string");
        }
    }
}
