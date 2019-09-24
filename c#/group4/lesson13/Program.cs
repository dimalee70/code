using System;

namespace lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // MyArray myArray = new MyArray(10);
            // myArray[0] = "Hello";
            // myArray[2.3] = "fdvfvdf";
            // myArray[5] = "This is 5 element";

            // System.Console.WriteLine(myArray);
            // System.Console.WriteLine(myArray[0]);

            // MyArray myArray = new MyArray(3,5);
            // myArray[0,0] = "OO";
            // myArray[0,1] = "01";

            // System.Console.WriteLine(myArray[0,0]);
            // System.Console.WriteLine(myArray[0,1]);
            MyPoint m1 = new MyPoint(1,2);
            // m1++;
            MyPoint m2 = new MyPoint(3,4);
            MyPoint m3 = m1 + m2;

            System.Console.WriteLine(m1 == m2);
            System.Console.WriteLine(m1 != m2);

            System.Console.WriteLine(m3);
        
            // if(m1)
            // {
            //     System.Console.WriteLine("if(m1)");
            // }
            // else
            // {
            //     System.Console.WriteLine("false");
            // }

            // if(!m1)
            // {
            //     System.Console.WriteLine("if(m1)");
            // }
            // else
            // {
            //     System.Console.WriteLine("false");
            // }

            string answer = m1;
            System.Console.WriteLine(answer);
            int answerInt = (int) m1;

            System.Console.WriteLine(answerInt);
        }
    }
}
