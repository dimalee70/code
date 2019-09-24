using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // System.Console.WriteLine("Enter the number");
            // int num = Convert.ToInt32(Console.ReadLine());
            // if (num > 0)
            //     System.Console.WriteLine("Bigger than zero");
            // else if(num == 0)
            // {
            //     System.Console.WriteLine("equal zero");
            // }
            // else
            //     System.Console.WriteLine("Less than zero");


            // if((num > 0 && num < 10)|| (num < 0) && (num > -10))
            // {
            //     System.Console.WriteLine
            //     ("Num bigger than zero "+
            //     "Num less then 10" );
            // }


            // System.Console.WriteLine("End");



            // switch(num/10)
            // {
            //     case 1:
            //     case 2:
            //         System.Console.WriteLine("Cool");
            //         break;
            //     case 3:
            //         System.Console.WriteLine("Three");
            //         break;
            //     default:
            //         System.Console.WriteLine("Default");
            //         break;
            // }
            // System.Console.WriteLine();
            int number = Convert.ToInt32(System.Console.ReadLine());

            // if(number>=0 && number<=100)
            // {
                if(number > 100)
                {
                    System.Console.WriteLine("A+");
                }
                else
                {
                    switch(number/5)
                    {
                    case 10:
                        System.Console.WriteLine("D");
                        break;
                    case 11:
                        System.Console.WriteLine("D+");
                        break;
                    case 12:
                        System.Console.WriteLine("C-");
                        break;
                    case 13:
                        System.Console.WriteLine("C");
                        break;
                    case 14:
                        System.Console.WriteLine("C+");
                        break;
                    case 15:
                        System.Console.WriteLine("B-");
                        break;
                    case 16:
                        System.Console.WriteLine("B");
                        break;
                    case 17:
                        System.Console.WriteLine("B+");
                        break;
                    case 18:
                        System.Console.WriteLine("A-");
                        break;
                    case 19:
                        case 20:
                            System.Console.WriteLine("A+");
                            break;                                
                    default:
                        System.Console.WriteLine("F");
                        break;
                }
            }
        }
        // }
     
    }

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
// 0 - 49	F	0	Unsatisfactory


}
