using System;
using System.Collections.Generic;

namespace lesson2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> list = new List<int>();
            // list.Add(1);
            // list.Add(10);

            // // System.Console.WriteLine(list[0]);
            // // System.Console.WriteLine();

            // list.Add(13);
            // list.Add(2);
            // list.Add(13);


            // // list.Remove(1);
            // System.Console.WriteLine(list[0]);
    
            // list.RemoveAt(2);

            // list.RemoveRange(0,1);

            // list.LastIndexOf(13);
            
            // list.Clear();

            // list.Add(27);
            // list.Reverse();
            // list.Sort();
            // int lenth = list.Count;

            // list.BinarySearch(1);
            // foreach(int i in list)
            // {
            //     System.Console.Write(i + " ");
            // }


            // foreach(int i in list)
            // {
            //     if(i == 12)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }






            LinkedList<int> linkedList = 
                new LinkedList<int>();
            
            linkedList.AddLast(12);
            linkedList.AddFirst(1); 
            linkedList.AddFirst(5);
            
            LinkedListNode<int> node = linkedList
            .Find(5);

            // System.Console.WriteLine(node.ToString());
            // try
            // {
                System.Console.WriteLine(node.Value);
                if(node.Previous != null)
                {
                    System.Console.WriteLine(node.
                                    Previous.Value);
                }
                
                System.Console
                .WriteLine(node.Next.Value);
            // }catch(Exception e)
            // {
            //     System.Console.WriteLine("Error");
            // }
    



            // foreach(int i in linkedList)
            // {
            //     System.Console.Write(i + " ");
            // }
            // System.Console.WriteLine();

            // System.Console.WriteLine();

            // System.Console.WriteLine(linkedList.Find(1).Value);

            // System.Console.WriteLine(linkedList.ElementAt(2));

            
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Hello");
            hashSet.Add("World");
            hashSet.Add("Hello");




            foreach(string s in hashSet)
            {
                System.Console.Write(s + " ");
            } 
            System.Console.WriteLine();

            SortedSet<string> sortedSet
                = new SortedSet<string>();
            
            sortedSet.Add("Hello");
            sortedSet.Add("World");
            sortedSet.Add("Hello");
            sortedSet.Add("AAAAAA");

            foreach(string s in sortedSet)
            {
                System.Console.WriteLine(s + " ");
            }

            Dictionary<int, string> dictionary 
                = new Dictionary<int,string>();
            dictionary.Add(1, "Dima");

            dictionary.TryAdd(1,"Aruzhan");
            // if(!dictionary.ContainsKey(1))
            // {
            //     dictionary.Add(1, "Aruzhan");
            // }
    
            dictionary.Add(0, "Assem");

            foreach(KeyValuePair<int, string> i in dictionary)
            {
                System.Console.WriteLine
                (i.Key + " " + i.Value);
            }

            SortedDictionary<string, int> sortedDictionary
                = new SortedDictionary<string, int>();

            sortedDictionary.Add("Aruzhan", 1);
            sortedDictionary.Add("Assem", 0);


            foreach(var i in sortedDictionary)
            {
                System.Console.WriteLine(i.Value + 
                " " + i.Key);
            }
        
            System.Console.WriteLine();
            
        }
    }
}
