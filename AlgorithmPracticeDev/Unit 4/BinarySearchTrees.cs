using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_4
{
    class BinarySearchTrees
    {
        public static void BinarySearchTreesPrint()
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

            Console.WriteLine("\nTree (inorder)");
            t.InOrderRecursiveTreeDisplay(t.root);
            Console.WriteLine();
            //Find selected value in binary search Tree
            //bool check = t.RecursiveFindValue(t.root, 10);
            bool check = t.find(11);
            if (!check)
            {
                Console.WriteLine("Value does not exists!");
            }

            t.Remove(1);
            //t.Remove(77);
            //t.Remove(1);
            //t.Remove(10);
            Console.WriteLine();
            t.InOrderRecursiveTreeDisplay(t.root);
            Console.ReadLine();
        }
    }
    public class TreeNode
    {
        public int data;
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(int data)
        {
            this.data = data;
        }
    }
    public class Tree
    {
        public TreeNode root { get; set; }

        public Tree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            TreeNode newItem = new TreeNode(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                TreeNode current = root;
                TreeNode parent = null;
                while (current != null)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newItem;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newItem;
                        }
                    }
                }
            }
        }
        public void InOrderRecursiveTreeDisplay(TreeNode root)
        {
            if (root != null)
            {
                InOrderRecursiveTreeDisplay(root.left);
                Console.Write("({0})", root.data);
                InOrderRecursiveTreeDisplay(root.right);
            }
        }
        public bool RecursiveFindValue(TreeNode root, int data)
        {
            if (root != null)
            {
                RecursiveFindValue(root.left, data);
                RecursiveFindValue(root.right, data);
                if (root.data == data)
                {
                    //Console.WriteLine("Value exists!");
                    return true;
                }
                
            }
            return false;
        }
        public TreeNode GoToTarget(int target)//method will return target node
        {
            TreeNode c = root;
            TreeNode returnThis = null;
            while (c != null)
            {
                if (target < c.data)
                {
                    c = c.left;
                }
                if (target == c.data)
                {
                    returnThis = c;
                    break;
                }
                if (target > c.data)
                {
                    c = c.right;
                }
            }
            return returnThis;
        }
        public TreeNode ParentOfTarget(TreeNode target)
        {
            //this method will return the parent node of the target node
            TreeNode current = root;
            TreeNode parent = null;
            while (current != null)
            {
                if (current.left == target || current.right == target)
                {
                    parent = current;
                    break;
                }
                if (target.data < current.data && current.left != target)
                {
                    current = current.left;
                }
                if (target.data > current.data && current.right != target)
                {
                    current = current.right;
                }
            }
            return parent;
        }
        public bool find(int target)
        {
            if (root != null && regular_find(target) != false)
            {
                return true;
            }
            else
            { return false; }
        }
        public bool regular_find(int target)
        {
            bool isFound = false;
            TreeNode current = root;
            while (current != null && isFound == false)
            {
                if (current.data == target)
                {
                    isFound = true;
                }
                if (target < current.data)
                {
                    if (current.left == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                if (target > current.data)
                {
                    if (current.right == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }
            if (isFound == true)
            {
                Console.WriteLine("Found it!");
                return true;
            }
            else
            {
                Console.WriteLine("Nope, DNE");
                return false;
            }
        }
        public void Remove(int target)
        {
            if (root == null || find(target) == false)//before we can remove, check to see if it exists
            {
                Console.WriteLine("Value not found to delete!");
                return;
            }
            else
            {
                Console.WriteLine("{0} was removed from the tree", Private_Remove(target));//Private Remove method called here
                return;
            }
        }
        public int Private_Remove(int target)//private remove method does all work, returns the integer value removed
        {
            int temp;
            TreeNode targetNode = GoToTarget(target);
            //case 1, removing the root
            if (targetNode == root)
            {
                if (targetNode.left == null && targetNode.right == null)
                {
                    temp = root.data;
                    root = null;
                    return temp;
                }
                if (targetNode.left != null)
                {
                    //replace top with left if a left-right node dne, else go far right as possible
                    //delete left
                    TreeNode current = root.left;

                    temp = root.data;
                    if (root.left.right == null)//if theres no right child of the left child...
                    { root.data = root.left.data; }
                    else //if there is, we go left and then far right until...
                    {
                        while (current != null)
                        { //we replace the root node with 2nd highest value
                            if (current.right.right == null)
                            { root.data = current.right.data; break; }
                            current = current.right;
                        }
                        if (current.right != null) { current.right = current.right.right; }//works
                        else { current.right = null; }
                        return temp;
                    }

                    if (root.left.left == null)
                    {
                        root.left = null;
                    }
                    else { root.left = root.left.left; }
                    return temp;
                }
                if (targetNode.right != null)
                {
                    temp = root.data;
                    root.data = root.right.data;
                    if (root.right.right == null)
                    {
                        root.right = null;
                    }
                    else { root.right = root.right.right; }
                    return temp;
                }
            }

            //case 2 , removing nonroot
            if (targetNode.left == null && targetNode.right == null)
            {//target has no children
                if (ParentOfTarget(targetNode).left == targetNode)
                {
                    temp = targetNode.data;
                    ParentOfTarget(targetNode).left = null;
                }
                else
                {
                    temp = targetNode.data;
                    ParentOfTarget(targetNode).right = null;
                }
                return temp;
            }
            //target has 1 child
            if (targetNode.left != null && targetNode.right == null)
            {
                temp = targetNode.data;
                ParentOfTarget(targetNode).right = targetNode.left;
                //ParentOfTarget(targetNode).left = targetNode.left;//HERE
                return temp;

            }
            if (targetNode.right != null && targetNode.left == null)
            {
                temp = targetNode.data;
                //here if parent is the root, make it left = target->right
                if (ParentOfTarget(targetNode) == root)
                {
                    ParentOfTarget(targetNode).left = targetNode.right;
                }
                else
                    ParentOfTarget(targetNode).right = targetNode.right;

                return temp;

            }
            //target node has 2 children
            if (targetNode.left != null && targetNode.right != null)
            {
                if (ParentOfTarget(targetNode).left == targetNode)
                {
                    //take child.left and replace target
                    temp = targetNode.data;
                    targetNode.data = targetNode.left.data;
                    targetNode.left = null;
                    return temp;
                }
                else
                {
                    temp = targetNode.data;
                    targetNode.data = targetNode.left.data;
                    //check if left->left not null...
                    if (targetNode.left.left != null)
                    {
                        targetNode.left = targetNode.left.left;
                    }
                    else
                        targetNode.left = null;
                    return temp;
                }

            }
            return Int32.MinValue;
        }
    }
}
