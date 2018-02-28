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
            Console.WriteLine("Node List Input");
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
            while (p.Next != null && p.Next.Value.value <= node.value)
            {
                p = p.Next;
            }
            listNode.AddAfter(p, node);

            Console.WriteLine("Node List Output");
            foreach (var item in listNode)
            {
                Console.WriteLine(item.value);
            }
            return listNode;
        }
        public static LinkedList<Node> LinkedListSearch(LinkedList<Node> listNode, Node node)
        {
            if (listNode.First != null && listNode.First.Value.value == node.value)
            {
                Console.WriteLine("Found node with value: " + node.value +" at the start.");
                return listNode;
            }
            var p = listNode.First;
            while(p != null && p.Value.value != node.value)
            {
                try
                {
                    p = p.Next;
                    if (p.Value.value == node.value)
                    {
                        Console.WriteLine("Found node with value: " + node.value);
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Node with value: " + node.value + " not found");
                    
                }
            }
            return listNode;
        }
        public static LinkedList<Node> LinkedListDelete(LinkedList<Node> listNode, Node node)
        {
            Console.WriteLine("Node List Input");
            foreach (var item in listNode)
            {
                Console.WriteLine(item.value);
            }
            if (listNode.First == null || listNode.First.Value.value > node.value)
            {
                //Niet goed
                //listNode.First.Value = node;
                Console.WriteLine("Node with value: " +node.value+ " does not exist to delete.");
                return listNode;
            }
            else
            {
                if (listNode.First.Value.value == node.value)
                {
                    //goed
                    Console.WriteLine("Node with value: " + node.value + " has been deleted.");
                    listNode.Remove(listNode.First);
                    return listNode;
                }
            }
            var x = listNode.First;
            try
            {
                while (x.Next.Value != null && x.Next.Value.value <= node.value)
                {
                    if (x.Next.Value.value == node.value)
                    {
                        Console.WriteLine("Node with value:" + node.value + "has been deleted.");
                        listNode.Remove(x.Next.Value);
                        return listNode;
                    }
                    x = x.Next;
                }
            }catch (NullReferenceException)
            {
                //Niet goed
                Console.WriteLine("Node with value: " + node.value + " not found to be deleted.");
            }
            return listNode;
        }
        public static void LinkedListPrint()
        {
            LinkedList<Node> listNode = new LinkedList<Node>();
            listNode.AddFirst(new Node(22));
            listNode.AddLast(new Node(33));
            listNode.AddLast(new Node(44));
            listNode.AddLast(new Node(55));

            //LinkedListInsert(listNode, new Node(30));
            //LinkedListSearch(listNode, new Node(45));
            LinkedListDelete(listNode, new Node(21));

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
