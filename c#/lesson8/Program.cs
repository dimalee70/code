using System;

namespace lesson8
{
    class Program
    {
        public enum Sex {Male=1, Female};
        static void Main(string[] args)
        {
            // uint ans = 1;
            // uint a = 5;
            // CoOrds coOrds = new CoOrds(12,12);
            // CoOrds c = new CoOrds(12);
            // // coOrds.x = 10;
            // // coOrds.y = 20;
            System.Console.WriteLine(Sex.Male.ToString());
            User us = new User("Dmitriy",Sex.Male.ToString(),24);
            us.Info();
            us.AgeOfHuman= 12;
            us.MessHello();
            // Book book = new Book("Tolstoy","Voina i Mir",1869);
            // // book.AuthorOfBook = "Tolstoy";
            // // book.NameOfBook = "Voina i Mir";
            // // book.YearOfBook = 1869;
            // book.Info();
            // // System.Console.WriteLine(c.x);
            // // System.Console.WriteLine(c.y);
            // // System.Console.WriteLine(Factorial(a,ref ans));
            // // System.Console.WriteLine(ans);
            Book[] books=new Book[3];
            books[0].NameOfBook = "Война и мир";
            books[0].AuthorOfBook = "Л. Н. Толстой";
            books[0].YearOfBook = 1869;
 
            // books[1].NameOfBook = "Преступление и наказание";
            // books[1].AuthorOfBook = "Ф. М. Достоевский";
            // books[1].YearOfBook = 1866;
  
            // books[2].NameOfBook = "Отцы и дети";
            // books[2].AuthorOfBook = "И. С. Тургенев";
            // books[2].YearOfBook = 1862;
 
            // foreach (Book b in books)
            // {
            //     System.Console.WriteLine(b.YearOfBook);
            // }
            // // CoOrds coords1 = new CoOrds();
            // // CoOrds coords2 = new CoOrds(10, 10);

            // // // Display results:
            // // Console.Write("CoOrds 1: ");
            // // Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

            // // Console.Write("CoOrds 2: ");
            // // Console.WriteLine("x = {0}, y = {1}", coords2.x, coords2.y);

            // // // Keep the console window open in debug mode.
            // // Console.WriteLine("Press any key to exit.");
            // // Console.ReadKey();
            // // System.Console.WriteLine((int)Day.Sun);
            // // System.Console.WriteLine(Day.Sun);
            // Day day = Day.Fri;
            // System.Console.WriteLine((int)day);


        }
        // static uint Factorial(uint a,ref uint ans){
        //     ans *= a;
        //     if(a == 1){
        //         return ans;
        //     }
        //     return Factorial(--a,ref ans);
        // }
        //enum
        enum Day { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };
        
    }
    //enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    // struct
    public struct CoOrds
    {
        public int x, y;

        public CoOrds(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public CoOrds(int t){
            x = t;
            y = 0;
        }
// }
    }
}


//}
