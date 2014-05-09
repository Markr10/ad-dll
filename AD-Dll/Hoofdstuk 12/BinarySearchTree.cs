using System;

namespace AD_Dll.Hoofdstuk_12
{
    /// <summary>
    /// Reinier Gombert
    /// BinarySearchTree klasse
    /// </summary>
    /// <typeparam name="T">Het type gegevens dat wordt opgeslagen in het object</typeparam>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        // variabelen declareren
        public Node<T> root;

        /// <summary>
        /// BinarySearchTree constructor
        /// </summary>
        public BinarySearchTree()
        {
            root = null;
        }

        /// <summary>
        /// Nieuwe waarde toevoegen aan de search tree.
        /// Hierin wordt tevens bepaald waar deze waarde zal worden geplaatst
        /// zodat er een mooie binary search tree onstaat
        /// </summary>
        /// <param name="i">De waarde die toegevoegd moet worden</param>
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

        /// <summary>
        /// Waarden sorteren in order
        /// </summary>
        /// <param name="theRoot">De root node</param>
        public void InOrder(Node<T> theRoot)
        {
            if (theRoot != null)
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        /// <summary>
        /// Waarden sorteren in pre order
        /// </summary>
        /// <param name="theRoot">De root node</param>
        public void PreOrder(Node<T> theRoot)
        {
            if (theRoot != null)
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }

        /// <summary>
        /// Waarden sorteren in post order
        /// </summary>
        /// <param name="theRoot">De root node</param>
        public void PostOrder(Node<T> theRoot)
        {
            if (theRoot != null)
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }

        /// <summary>
        /// Minimum bepalen en returnen
        /// </summary>
        /// <returns>Het minimum</returns>
        public T FindMin()
        {
            Node<T> current = root;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Data;
        }

        /// <summary>
        /// Maximum bepalen en returnen
        /// </summary>
        /// <returns>Het maximum</returns>
        public T FindMax()
        {
            Node<T> current = root;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Data;
        }

        /// <summary>
        /// Een opgegeven waarde in de search tree zoeken en returnen als 
        /// deze gevonden is
        /// </summary>
        /// <param name="key">De gezochte waarde</param>
        /// <returns>De gevonden waarde. Null als er geen waarde gevonden is</returns>
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

        /// <summary>
        /// Alleen van toepassing om te kijken waar een bepaalde node zich bevindt.
        /// </summary>
        /// <param name="delNode">De gezochte node</param>
        /// <returns>De successor</returns>
        public Node<T> GetSuccessor(Node<T> delNode)
        {
            Node<T> successorParent = delNode;
            Node<T> successor = delNode;
            Node<T> current = delNode.Right;

            while (current != null)
            {
                successorParent = current;
                successor = current;
                current = current.Left;
            }

            if (successor != delNode.Right)
            {
                successorParent.Left = successor.Right;
                successor.Right = delNode.Right;
            }

            return successor;
        }

        /// <summary>
        /// Het verwijderen van een node in de search tree
        /// </summary>
        /// <param name="key">De te verwijderen waarde</param>
        /// <returns>Of de node verwijderd is</returns>
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
