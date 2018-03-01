using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_3
{
    class Queues
    {
        public static Queue<SLinkedNode> list = new Queue<SLinkedNode>();
        public static void QueueListPrint()
        {
            SLinkedNode node1 = new SLinkedNode(22);
            SLinkedNode node2 = new SLinkedNode(33);
            SLinkedNode node3 = new SLinkedNode(44);
            SLinkedNode node4 = new SLinkedNode(55);
            list.Enqueue(node1);
            list.Enqueue(node2);
            list.Enqueue(node3);
            list.Enqueue(node4);

            Console.WriteLine("Print list of enqueued nodes");
            foreach (var node in list)
            {
                Console.WriteLine(node.data);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Print function peek");
            Console.WriteLine(list.Peek().data);
            Console.WriteLine("------------------");
            Console.WriteLine("Print node that wil be dequeued");
            Console.WriteLine(list.Dequeue().data);
            Console.WriteLine("------------------");
            Console.WriteLine("Print list after dequeued a node");
            foreach (var node in list)
            {
                Console.WriteLine(node.data);
            }
            SLinkedNode node6 = new SLinkedNode(99);
            list.Enqueue(node6);
            Console.WriteLine("Print new list of enqueued nodes");
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
