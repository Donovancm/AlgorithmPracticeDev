using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_3
{
    class DoublyLinkedLists
    {
        public static DoublyLinkedList list;
        public static void InsertAfter(DoublyLinkedList list, DLinkedNode node, DLinkedNode newNode)
        {
            newNode.prev = node;
            if (node.next == null)
            {
                list.lastNode = newNode;
            }
            else
            {
                newNode.next = node.next;
                node.next.prev = newNode;
            }
            node.next = newNode;
        }
        public static void InsertBefore(DoublyLinkedList list, DLinkedNode node, DLinkedNode newNode)
        {
            newNode.next = node;
            if (node.prev == null)
            {
                newNode.prev = null;
                list.firstNode = newNode;
            }
            else
            {
                newNode.prev = node.prev;
                node.prev.next = newNode;
            }
            node.prev = newNode;
        }
        public static void InsertBeginning(DoublyLinkedList list, DLinkedNode newNode)
        {
            if (list.firstNode == null)
            {
                list.firstNode = newNode;
                list.lastNode = newNode;
                newNode.prev = null;
                newNode.next = null;
            }
            else
            {
                InsertBefore(list, list.firstNode, newNode);
            }
        }
        public static void Insertlast(DoublyLinkedList list, DLinkedNode newNode)
        {
            if (list.lastNode == null)
            {
                InsertBeginning(list, newNode);
            }
            else
            {
                InsertAfter(list, list.lastNode, newNode);
            }
        }
        public static void RemoveNode(DoublyLinkedList list, DLinkedNode node)
        {
            if (node.prev == null)
            {
                list.firstNode = node.next;
            }
            else
            {
                node.prev.next = node.next;
            }
            if (node.next == null)
            {
                list.lastNode = node.prev;
            }
            else
            {
                node.next.prev = node.prev;
            }
        }
        public static void DoublyLinkedListPrint()
        {
            //insert node
            list = new DoublyLinkedList();
            DLinkedNode node1 = new DLinkedNode(22);
            DLinkedNode node2 = new DLinkedNode(33);
            DLinkedNode node3 = new DLinkedNode(44);
            DLinkedNode node4 = new DLinkedNode(55);
            DLinkedNode node5 = new DLinkedNode(66);
            InsertBeginning(list, node1);
            InsertAfter(list, list.firstNode, node2);
            InsertAfter(list, node2, node3);
            InsertAfter(list, node3, node4);
            Insertlast(list, node5);
            RemoveNode(list,node5);

            var p = list.firstNode;
            while (p != null)
            {
                Console.WriteLine("value: "+ p.data);
               
                if (p.next.data == list.lastNode.data)
                {
                    Console.WriteLine("value: " + p.next.data);
                    break;
                }
                p = p.next;
            }

        }
        public class DLinkedNode
        {
            public int data;
            public DLinkedNode next = null;
            public DLinkedNode prev = null;
            public DLinkedNode(int data, DLinkedNode next, DLinkedNode prev)
            {
                this.data = data;
                this.next = next;
                this.prev = prev;
            }
            public DLinkedNode(int data)
            {
                this.data = data;
            }
        }
        public class DoublyLinkedList
        {
            public DLinkedNode firstNode;
            public DLinkedNode lastNode;


        }
    }
}
//public static DLinkedList node;
//public static DLinkedList InsertNext(DLinkedList node, int value)
//{
//    DLinkedList newNode = new DLinkedList(value);
//    if (node.next == null)
//    {
//        // Easy to handle
//        newNode.prev = node;
//        newNode.next = null; // already set in constructor
//        node.next = node;
//    }
//    else
//    {
//        // Insert in the middle
//        DLinkedList temp = node.next;
//        newNode.prev = node;
//        newNode.next = temp;
//        node.next = newNode;
//        temp.prev = newNode;
//        // temp.next does not have to be changed
//    }
//    return node;
//}
//public static void DoublyLinkedListPrint()
//{
//    node = new DLinkedList();
//    InsertNext(node, 22);
//    InsertNext(node, 33);
//    InsertNext(node, 44);
//    InsertNext(node, 55);

//    var p = node.next;
//    while (p.next != null)
//    {
//        Console.WriteLine(node.data);
//        p = p.next;
//    }
//}
//    }
//    public class DLinkedList
//{
//    public int data;
//    public DLinkedList next;
//    public DLinkedList prev;

//    public DLinkedList()
//    {
//        data = 0;
//        next = null;
//        prev = null;
//    }
//    public DLinkedList(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }
