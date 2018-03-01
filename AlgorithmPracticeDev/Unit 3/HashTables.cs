using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_3
{
    class HashTables
    {
        //public static Queue<SLinkedNode> list = new Queue<SLinkedNode>();
        public static Hashtable ht = new Hashtable();
        public static void HashTablesPrint()
        {
            ht.Add(11, "Eleven");
            ht.Add(22, "TwentyTwo");
            ht.Add(33, "ThirtyThree");
            ht.Add(44, "FortyFour");
            ht.Add(55, "FiftyFive");
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);






            Console.WriteLine("Print list of Key and its value");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Find hashtable element with key: 44 and it's value of " + ht[44]);
            Console.WriteLine("------------------");
            Console.WriteLine("Remove hashtable element with key: 44 and it's value of " + ht[44]);
            ht.Remove(44);
            Console.WriteLine("------------------");
            Console.WriteLine("Print list of Key and its value after key 44 has been removed");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
            }
        }
    }
}
