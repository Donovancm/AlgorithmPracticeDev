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
        //public class Stack<T> : StackInterface<T>
        //{
        //    public bool IsEmpty()
        //    {
        //        Console.WriteLine("Yes it is empty!");
        //        return true;
        //    }

        //    public T Peek()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public T Pop()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Push(T e)
        //    {
        //        list.Push(e);
        //        throw new NotImplementedException();
        //    }
        //    public static void StackListPrint()
        //    {
        //        list.IsEmpty();
        //    }
        //}
    }
    //public interface StackInterface<T>
    //{
    //    void Push(T e);
    //    T Pop();
    //    T Peek();
    //    Boolean IsEmpty();
    //}
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
