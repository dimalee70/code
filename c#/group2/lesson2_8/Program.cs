using System;
using System.Collections;
using System.Collections.Generic;

namespace lesson2_8
{
    class Program
    {
        private const int V = 22;
        public static int sum = 0;
        public static string myWord;
        delegate void Print();

        delegate void PrintWorld(string world);

        delegate int ReturnDelegate(params int [] arr);
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            Person p = new Person("Dima", 22);
            Person p2 = new Person("Islam", 18);
            Person p3 = new Person("Test", 22);

            list.Add(p);
            list.Add(p2);
            int t = list.Count;
            // list.Clear();
            // list.Remove(p2);
            // Person n =  list[0];
            // list.RemoveAt(0);
            // list.RemoveAll(pers => pers.Age == 22);
            

            foreach(Person item in list)
            {
                System.Console.WriteLine(item.Name);
            }

            LinkedList <int> linkedList = 
                new LinkedList<int>();

            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddLast(4);

            linkedList.RemoveFirst();

            linkedList.RemoveLast();
            linkedList.Remove(2);
            // linkedList.Cle;


            foreach(int i in linkedList)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

            HashSet<int> hashSet =  new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(10);
            hashSet.Add(22);
            hashSet.Add(55);
            hashSet.Add(5);
            hashSet.Add(6);

            System.Console.WriteLine(hashSet.ToString());
            foreach(int it in hashSet)
            {
                System.Console.Write(it + " ");
            }
            System.Console.WriteLine();

            SortedSet<string> sortedSet = new SortedSet<string>();

            sortedSet.Add("erre");
            sortedSet.Add("erre");
            sortedSet.Add("g");
            sortedSet.Add("f");
            sortedSet.Add("e");
            sortedSet.Add("d");
            sortedSet.Add("c");
            sortedSet.Add("eab");
            sortedSet.Add("ab");
            sortedSet.Add("a");

            foreach(string it in sortedSet)
            {
                System.Console.Write(it + " ");
            }
            System.Console.WriteLine();

            Dictionary<int, char> charDictionary = 
                new Dictionary<int, char>();

            charDictionary.Add(3,'c');
            charDictionary.Add(1,'b');
            charDictionary.Add(2,'a');
            // charDictionary.Add(1,'z');

            foreach(int k in charDictionary.Keys)
            {
                System.Console.Write(k + " ");
            }
            System.Console.WriteLine();
            foreach(char v in charDictionary.Values)
            {
                System.Console.Write(v + " ");
            }
            System.Console.WriteLine();

            foreach(KeyValuePair<int, char> e in charDictionary)
            {
                System.Console.WriteLine(e);
            }

            SortedDictionary<int, char> sortedDictionary = 
                new SortedDictionary<int, char>();

                        sortedDictionary.Add(3,'c');
            sortedDictionary.Add(1,'b');
            sortedDictionary.Add(2,'a');
            // charDictionary.Add(1,'z');

            foreach(int k in sortedDictionary.Keys)
            {
                System.Console.Write(k + " ");
            }
            System.Console.WriteLine();
            foreach(char v in sortedDictionary.Values)
            {
                System.Console.Write(v + " ");
            }
            System.Console.WriteLine();

            foreach(KeyValuePair<int, char> e in sortedDictionary)
            {
                System.Console.WriteLine(e);
            }


            Hashtable hashtable = 
            new Hashtable();

 






            // ArrayList<int> arrayList = new ArrayList<int>();

            // ArrayList arrayList = new ArrayList();
            // arrayList.Add("herge");
            // arrayList.Add(34234);
            // arrayList.Add(new Person());

            // System.Console.WriteLine(arrayList[2].ToString());



            // Console.WriteLine("Hello World!");
            // Print print  = () => Hello();
            // print += () => 
            // {
            //     System.Console.WriteLine("Hello");
            // };

            // print();

            // PrintWorld printWorld =
            // (string w) => 
            // {
            //     System.Console.WriteLine("Your word is " + w);
            // };

            // printWorld("Islam");

            // printWorld = 
            // (string w ) => 
            // {
            //     myWord = w;

            // };

            // printWorld("Dima");
            // System.Console.WriteLine(myWord);


            
            // ReturnDelegate r = (int  [] arr) =>
            // {
            //     foreach(int t in arr)
            //     {
            //         sum+= t;
            //     }
            //     return sum;
            // };

            // sum = r(1,2,3);
            // System.Console.WriteLine(sum);
            
            
        }

        public static void Hello()
        {
            System.Console.WriteLine("Hello");
        }
    }
}
