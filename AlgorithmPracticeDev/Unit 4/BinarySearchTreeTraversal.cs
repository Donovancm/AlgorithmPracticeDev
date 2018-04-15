using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_4
{
    class BinarySearchTreeTraversal
    {
        public class Tree
        {
            public Node root;
            public Tree()
            {
                root = null;
            }
            public Node ReturnRoot()
            {
                return root;
            }
            public void Insert(int id)
            {
                Node newNode = new Node();
                newNode.item = id;
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (id < current.item)
                        {
                            current = current.left;
                            if (current == null)
                            {
                                parent.left = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = newNode;
                                return;
                            }
                        }
                    }
                }
            }
            public void Preorder(Node root)
            {
                if (root != null)
                {
                    Console.WriteLine(root.item + "");
                    Preorder(root.left);
                    Preorder(root.right);
                }
            }
            public void Inorder(Node root)
            {
                if (root != null)
                {
                    Inorder(root.left);
                    Console.WriteLine(root.item + " ");
                    Inorder(root.right);
                }
            }
            public void Postorder(Node root)
            {
                if (root != null)
                {
                    Postorder(root.left);
                    Postorder(root.right);
                    Console.WriteLine(root.item + "");
                }
            }
            public int BSTFind(Node node, int s)
            {
                if (node == null)
                {
                    Console.WriteLine("Targeted Node has not been found");
                    return s;
                }
                else if (s.CompareTo(node.item) < 0)
                {
                    return BSTFind(node.left, s);
                }
                else if (s.CompareTo(node.item) > 0)
                {
                    return BSTFind(node.right, s);
                }
                Console.WriteLine("Targeted Node has been found");
                return s;
            }
        }
        public static void BSTTraversalPrint()
        {
            Tree t = new Tree();
            t.Insert(8);
            t.Insert(3);
            t.Insert(10);
            t.Insert(1);
            t.Insert(6);
            t.Insert(14);
            t.Insert(4);
            t.Insert(7);
            t.Insert(13);

            Console.WriteLine("Inorder Traversal : ");
            t.Inorder(t.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            t.Preorder(t.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            t.Postorder(t.ReturnRoot());
            Console.WriteLine(" ");

            Console.WriteLine("Finding your selected target in BST");
            int input = Convert.ToInt32(Console.ReadLine());
            t.BSTFind(t.root, input);
            Console.ReadLine();
        }
        public class Node
        {
            public int item;
            public Node left;
            public Node right;
        }
    }
}
