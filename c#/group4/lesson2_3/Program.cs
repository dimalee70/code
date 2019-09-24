using System;

namespace lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User<double> user = new User<double>(1.343,"refe");
            System.Console.WriteLine(user);


            user.checkType();

            User<string> u = new User<string>
            ("!2132BBB", "Test");
            System.Console.WriteLine(u);

            User<User<char>> u2 = new User<User<char>>
            (new User<char>('e' , "fdfd"),"Hello");
            System.Console.WriteLine(u2);

            MyDictionary<int, string> myDictionary =
            new MyDictionary<int,string>(1231,"fdgd");

            MyDictionary<int, User<char>> m = 
            new MyDictionary<int, User<char>>
            (23, new User<char>('2', "String"));

            // Repository<Human> re = new Repository<Human>();

            // Repository <Student<int>> r = new Repository
            // <Student<int>>();

            // Repository<User<int>> rep = new Repository<User<int>>();

            

            System.Console.WriteLine(myDictionary.ToString());


            int [] arrInt = {1,2,3,4,5,6,7};
            string [] arrStr = {"wwd,","BMW", "KIA", "MERS"};
            Human[] arrHumans = {new Human(1, "Dima"),
                                new Human(2, "Assem"),
                                new Human(3, "Aruzhan")};

            printArr<int>(arrInt);
            printArr<string>(arrStr);
            printArr<Human>(arrHumans);

            MyGeneric<MyTest> myGeneric = 
            new MyGeneric<MyTest>(); 

            People<string>.name = "dfsdsd";
            People<int>.name = 212312;
            People<char>.name = 'q';
        }

        public static void printArr<T>(T [] arr)
        // where T : struct
        {
            foreach(T t in arr)
            {
                System.Console.Write(t.ToString() + " ");
            }
            System.Console.WriteLine();
        }

        
    }
}
