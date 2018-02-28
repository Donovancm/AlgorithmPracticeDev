using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_3
{
    class LinkedLists
    {
        public LinkedListNode<Node> listNode;


        public static LinkedList<Node> LinkedListInsert(LinkedList<Node> listNode, Node node)
        {
            Console.WriteLine("Integer Array Input");
            foreach (var item in listNode)
            {
                Console.WriteLine(item.value);
            }
            if (listNode.First == null || listNode.First.Value.value > node.value)
            {
                listNode.First.Value = node;
                return listNode;
            }
            var p = listNode.First;
            while (p.Next != null && p.Next.Value.value <= node.value )
            {
                p = p.Next;
            }
            listNode.AddAfter(p, node);   
             
            Console.WriteLine("Integer Array Output");
            foreach (var item in listNode)
            {
                Console.WriteLine(item.value);
            }
            return listNode;
        }
        public static void LinkedListSearch()
        {

        }
        public static void LinkedListDelete()
        {

        }
        public static void LinkedListPrint()
        {
            LinkedList<Node> listNode = new LinkedList<Node>();
            listNode.AddFirst(new Node(22));
            listNode.AddLast(new Node(33));
            listNode.AddLast(new Node(44));
            listNode.AddLast(new Node(55));

            LinkedListInsert(listNode, new Node(30));

        }
    }
    public class Node
    {
        //public Node next;
        public int value;

        public Node(int value)
        {
            this.value = value;
        }

    }
}
