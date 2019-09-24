using System;
using System.Collections.Generic;

namespace lesson2_8
{
    class Program
    {
        
        static void Main(string[] args)
        {
           List <int> myIntList = new List<int>();
            List<User> list = new List<User>();
            User user2 = new User(2,"Aruzhan", 18);
            User user4 = new User(4,"Nurbek", 30);
            User user3 = new User(3,"Dmitriy", 22);
            User user5 = new User(5,"Assem", 18);
            User user1 = new User(1,"Assem", 18);
    

            list.Add(user2);
            list.Add(user4);
            list.Add(user3);
            list.Add(user5);
            list.Add(user1);
            

            UserRepository userRepository
                = new UserRepository(list);


            foreach(User u in userRepository)
            {
                System.Console.WriteLine(u);
            }


            // foreach(User u in list)

            // userRepository.sortList();





            // foreach(User u in list)
            // {
            //     System.Console.WriteLine(u);
            // }
            // System.Console.WriteLine();
            // list.Sort();

            // foreach(User u in list)
            // {
            //     System.Console.WriteLine(u);
            // }


            // myIntList.Add(5);
            // myIntList.Add(3);
            // myIntList.Add(10);
            // myIntList.Add(15);

            // myIntList.Sort();

            // foreach(int i in myIntList)
            // {
            //     System.Console.WriteLine(i);
            // }
            

            

            Book b4 = new Book(4,"C# Tutorial");
            Book b3 = new Book(3,"Master i Margarita");
            Book b2 = new Book(1,"Violeta");
            Book b1 = new Book(1,"Voina i mir");
            Book b5 = new Book(1,"Voina i mir");
            Book b6 = b5;


            LinkedList<Book> listBook = new LinkedList<Book>();

            listBook.AddFirst(b4);
            listBook.AddFirst(b3);
            listBook.AddFirst(b2);
            listBook.AddFirst(b1);

            // BookComparer bookComparer = new BookComparer();

            // listBook.Sort(bookComparer);

            // foreach (var item in listBook)
            // {
            //     System.Console.WriteLine(item);
            // }

            // HashSet<Book> setBooks = 
            //     new HashSet<Book>(bookComparer);

      

            // setBooks.Add(b4);
            // setBooks.Add(b1);
            // setBooks.Add(b2);
            // setBooks.Add(b3);
            // setBooks.Add(b5);
            // setBooks.Add(b6);

            // foreach(Book i in setBooks)
            // {
            //     System.Console.WriteLine(i);
            // }

            // SortedSet<Book> sortedSet = 
            //     new SortedSet<Book>(bookComparer);

            // sortedSet.Add(b4);
            // sortedSet.Add(b1);
            // sortedSet.Add(b2);
            // sortedSet.Add(b3);
            // sortedSet.Add(b5);
            // sortedSet.Add(b6);

            // foreach(Book b in sortedSet)
            // {
            //     System.Console.WriteLine(b);
            // }

            // foreach(Book b in listBook)
            // {
            //     System.Console.WriteLine(b);
            // }

            IEnumerator<Book> item = listBook.GetEnumerator();


        
            // item.MoveNext();
            // System.Console.WriteLine(item.Current);
            // item.MoveNext();


            // System.Console.WriteLine(item.Current);
            // while(item.MoveNext())
            // {
            //     System.Console.WriteLine(item.Current);
            // }

            // item.Reset();
            // item.MoveNext();
            // System.Console.WriteLine(item.Current);


            // LinkedListNode<Book> itemNode = listBook.First;

            // System.Console.WriteLine(itemNode.Value);

            // itemNode = itemNode.Next;

            // System.Console.WriteLine(itemNode.Value);

        }
    }
}
