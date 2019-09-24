using System;

namespace lesson2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // User<int> u = new User<int>(1,"Dima");
            // System.Console.WriteLine(u);

            // User<double> u2 = new User<double>(1.2232, "Islam");

            // System.Console.WriteLine(u2);

            // User<string> u3 = new User<string>("2312312", "test");

            // System.Console.WriteLine(u3);

            // User<string> userString = new User<string>("12231","3243423");
            // User<int> userInt = new User<int>(123123,413432423);


            User<int, CellPhone> userIntString = new User<int, CellPhone>(1,new CellPhone());

            // User<int, Test<int, string, char>> userIntTest = new User<int, Test<int, string, char>>(5, new Test<int, string,char>(4,"test", 5));

            // System.Console.WriteLine(userIntTest);



            Test<int, string, InheritanceCellPhone> t = new Test<int, string, InheritanceCellPhone>(4,"apple", 2);
            t.add(0, new InheritanceCellPhone("XS"));
            t.add(1, new InheritanceCellPhone("X"));

            // Test<int, string, int> t = new Test<int, string, int>(4,"apple", 2);
            // t.add(0, 1);
            // t.add(1, 2);

            System.Console.WriteLine(t);

            t.pritnArr();

            var arr = t.arr;

            foreach(var v in arr)
            {
                v.hello();
                // System.Console.WriteLine(v.ToString());
            }


            
            Test<int, string, TestClass> t2 = new Test<int, string, TestClass>(4,"apple", 2);
            t2.add(0, new TestClass("XS"));
            t2.add(1, new TestClass("X"));

            // Test<int, string, int> t = new Test<int, string, int>(4,"apple", 2);
            // t.add(0, 1);
            // t.add(1, 2);

            System.Console.WriteLine(t);

            t.pritnArr();

            var arr2 = t2.arr;

            foreach(var v in arr2)
            {
                v.hello();
                // System.Console.WriteLine(v.ToString());
            }


            // Test t = new Test(1,"#");
            // System.Console.WriteLine(t);

        }
    }
}
