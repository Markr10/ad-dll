using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_12
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        /*
         * waarden initialiseren
         */
        public Node<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        /*
         * Nieuwe waarde toevoegen aan de search tree
         * hierin wordt tevens bepaald waar deze waarde zal worden geplaatst
         * zodat er een mooie binary search tree onstaat
         */
        public void Insert(T i)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<T> current = root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    if (i.CompareTo(current.Data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        /*
         * waarden sorteren in order
         */
        public void InOrder(Node<T> theRoot)
        {
            if (theRoot != null)
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        /*
         * waarden sorteren in pre order
         */
        public void PreOrder(Node<T> theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }

        /*
         * waarden sorteren in post order
         */
        public void PostOrder(Node<T> theRoot)
        {
            if (!(theRoot == null))
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }

        /*
         * minimum bepalen en returnen
         */
        public T FindMin()
        {
            Node<T> current = root;
            while (!(current.Left == null))
            {
                current = current.Left;
            }
            return current.Data;
        }

        /*
         * maximum bepalen en returnen
         */
        public T FindMax()
        {
            Node<T> current = root;
            while (!(current.Right == null))
            {
                current = current.Right;
            }
            return current.Data;
        }

        /*
         * een opgegeven waarde in de search tree zoeken en returnen als 
         * deze gevonden is
         */
        public Node<T> Find(T key)
        {
            Node<T> current = root;
            while (current.Data.CompareTo(key) != 0)
            {
                if (key.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }

        /*
         * Alleen op toepassing om te kijken waar een bepaalde node zich bevindt.
         */
        public Node<T> GetSuccessor(Node<T> delNode)
        {
            Node<T> successorParent = delNode;
            Node<T> successor = delNode;
            Node<T> current = delNode.Right;
            while (!(current == null))
            {
                successorParent = current;
                successor = current;
                current = current.Left;
            }
            if (!(successor == delNode.Right))
            {
                successorParent.Left = successor.Right;
                successor.Right = delNode.Right;
            }
            return successor;
        }

        /*
         * Het verwijderen van een node in de search tree.
         */
        public bool Delete(T key)
        {
            Node<T> current = root;
            Node<T> parent = root;
            bool isLeftChild = true;
            while (current.Data.CompareTo(key) != 0)
            {
                parent = current;
                if (key.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.Right;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }
                if (current == null)
                {
                    return false;
                }
            }
            if ((current.Left == null) && (current.Right == null))
            {
                if (current == root)
                {
                    root = null;
                }
                else if (isLeftChild)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (current.Right == null)
            {
                if (current == root)
                {
                    root = current.Left;
                }
                else if (isLeftChild)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else if (current.Left == null)
            {
                if (current == root)
                {
                    root = current.Right;
                }
                else if (isLeftChild)
                {
                    parent.Left = parent.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else
            {
                Node<T> successor = GetSuccessor(current);
                if (current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.Left = successor;
                }
                else
                {
                    parent.Right = successor;
                }
                successor.Left = current.Left;
            }
            return true;
        }
    }
}


