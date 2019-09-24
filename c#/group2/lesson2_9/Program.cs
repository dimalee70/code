using System;
using System.Collections;
using System.Collections.Generic;

namespace lesson2_9
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<int> myList = new List<int>();

            // myList.Add(6);
            // myList.Add(2);
            // myList.Add(9);
            // myList.Add(1);
            // myList.Add(60);
            // myList.Add(0);
            // myList.Add(9);
            // myList.Add(12);
            // myList.Add(15);

            // myList.Sort();

            // foreach(int i in myList)
            // {
            //     System.Console.Write(i+ " ");
            // }
            // System.Console.WriteLine();

            // Console.WriteLine("Hello World!");


            List<User> myUser = new List<User>();
            myUser.Add(new User("Dima", 22));
            myUser.Add(new User("Islam", 18));
            myUser.Add(new User("Petya", 32));
            myUser.Add(new User("John", 42));
            myUser.Add(new User("Steve", 54));
            myUser.Add(new User("Chaning", 8));
            myUser.Add(new User("Nursultan", 70));

            // myUser.Sort(new UserComparator());

            IEnumerator<User> UserIEnum = myUser.GetEnumerator();
            while(UserIEnum.MoveNext())
            {
                System.Console.WriteLine(UserIEnum.Current);
            }
            UserIEnum.Reset();

            System.Console.WriteLine("========================");

            UserIEnum.MoveNext();
            System.Console.WriteLine(UserIEnum.Current);
            UserIEnum.MoveNext();
            System.Console.WriteLine(UserIEnum.Current);
            UserIEnum.MoveNext();
            System.Console.WriteLine(UserIEnum.Current);

            UserIEnum.Reset();
            UserIEnum.MoveNext();
            System.Console.WriteLine(UserIEnum.Current);


            // foreach (var item in myUser)
            // {
            //     System.Console.WriteLine(item);
            // }


            // SortedSet<User> hashSetUsers = new SortedSet<User>
            // (new UserComparator());

            // User u = new User("Dima", 22);
            // hashSetUsers.Add(u);
            // hashSetUsers.Add(new User("Islam", 8));
            // hashSetUsers.Add(new User("Dima", 32));
            // hashSetUsers.Add(new User("John", 42));
            // hashSetUsers.Add(new User("Steve", 54));
            // hashSetUsers.Add(new User("Chaning", 8));

            // foreach (var item in hashSetUsers)
            // {
            //     System.Console.WriteLine(item);
            // }
            
            // foreach( int i in getNumbers())
            // {
            //     System.Console.Write(i +  " ");
            // }
            
        }

        // public static IEnumerable<int> getNumbers()
        // {
        //     int pos = 0;
        //     while(true)
        //     {
        //         if (pos == 10)
        //             yield break;
        //         yield return pos++; 
        //     }
          
        // }
    }
}
