using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_3
{
    class Stacks
    {
        public static Stack<SLinkedNode> list = new Stack<SLinkedNode>();
        public static void StackListPrint()
        {
            SLinkedNode node1 = new SLinkedNode(22);
            SLinkedNode node2 = new SLinkedNode(33);
            SLinkedNode node3 = new SLinkedNode(44);
            SLinkedNode node4 = new SLinkedNode(55);
            list.Push(node1);
            list.Push(node2);
            list.Push(node3);
            list.Push(node4);
            

            Console.WriteLine("Print list of pushed nodes");
            foreach (var node in list)
            {
                Console.WriteLine(node.data);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Print function peek");
            Console.WriteLine(list.Peek().data);
            Console.WriteLine("------------------");
            Console.WriteLine("Print node that wil be poped");
            Console.WriteLine(list.Pop().data);
            Console.WriteLine("------------------");
            Console.WriteLine("Print list after pop a node");
            foreach (var node in list)
            {
                Console.WriteLine(node.data);
            }
        }
        public class SLinkedNode
        {
            public int data;
            public SLinkedNode next = null;
            public SLinkedNode(int data)
            {
                this.data = data;
            }
        }
        public class SLinkedList
        {
            public SLinkedNode firstNode;
            public SLinkedNode lastNode;
        }
    }
}
