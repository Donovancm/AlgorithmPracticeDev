using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_3
{
    class DoublyLinkedLists
    {
        public static void InsertAfter(DoublyLinkedList list, Node node, Node newNode)
        {
            //newNode.prev = node;
            //newNode = node.next;
            //if (node.next == null)
            //{
            //    list.lastNode = newNode;
            //}
            //else
            //{
            //    node.next.prev = newNode;
            //}
            //node.next = newNode;
        }
        public static void InsertBefore(DLinkedNode list, Node node, Node newNode)
        {

        }
        public static void InsertBeginning(DLinkedNode list, Node newNode)
        {

        }
        public static void Insertlast(DLinkedNode list, Node newNode)
        {

        }
        public static void RemoveNode(DLinkedNode list, Node node)
        {

        }
        public static void DoublyLinkedListPrint()
        {

        }
        public class DLinkedNode
        {
            public int data;
            public DLinkedNode next;
            public DLinkedNode prev;
        }
        public class DoublyLinkedList
        {
            DLinkedNode firstNode;
            DLinkedNode lastNode;
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