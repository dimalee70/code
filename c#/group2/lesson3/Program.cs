using System;

namespace lesson3
{
    class Program
    {

// 95 - 100	A	4	Excellent
// 90 - 94	A-	3.67
// 85 - 89	B+	3.33	Good
// 80 - 84	B	3
// 75 - 79	B-	2.67
// 70 - 74	C+	2.33
// 65 - 69	C	2	Satisfactory
// 60 - 64	C-	1.67
// 55 - 59	D+	1.33
// 50 - 54	D	1
// 25 - 49	FX	0	Unsatisfactory
// 0 - 24	F	0
// 0 - 24	FC	0

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = Convert.ToInt32
            (Console.ReadLine());

            // int b = Convert.ToInt32
            // (Console.ReadLine());

            // bool isTrue = (a > 10 && b > 10) 
            // || (a<10 && b < 10);

            // if (!((a > 10 && b > 10)))
            // {
            //     System.Console.WriteLine("a bigger then 10");
            // }
            // else
            // {
            //     System.Console.WriteLine("a less the 10");
            // }
            // if (b > 10)
            //     System.Console.WriteLine("b bigger the 10");
            // else if (b == 10)
            //     System.Console.WriteLine("b equal 10");
            // else if (a == 10)
            // {
            //     System.Console.WriteLine("a equal 10");
            // }
            // else
            // {
            //     System.Console.WriteLine("a less then 10");
            // }

            // System.Console.WriteLine("End");



            // if(a > 10)
            // {
            //     if(a < 100)
                
            //     {
            //         System.Console.WriteLine("a less 100 and bigger 10");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("a less 100 and bigger then 10");
            //     }
            // }
            // else
            // {
            //     if(a > -100)
                
            //     {
            //         System.Console.WriteLine("a less 10 and bigger -100");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("a less 10 and less then -100");
            //     }
            // }


            switch(a)
            {
                case 12:case 10:
                    System.Console.WriteLine("A equal 10 or a equal 12");
                    break;
                case 11:
                    System.Console.WriteLine("A equal 11");
                    break;
                default:
                    System.Console.WriteLine("default");
                    break;
            }
            char c = 'a';
            int t = (int) c;

            System.Console.WriteLine("enter char");

            char c2 = Convert.ToChar(Console.ReadLine());

            System.Console.WriteLine((int)c2);

            int a1 = 65;

            System.Console.WriteLine((char ) a1);

        }
    }
}
