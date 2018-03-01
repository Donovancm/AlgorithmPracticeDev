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

