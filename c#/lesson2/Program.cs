using System;

namespace lesson2
{
    class Program
    {

        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 5;
            if(number1 > number2)
            {
                System.Console.WriteLine("number1 is bigger");
            }
            else if(number2 > number1)
            {
                System.Console.WriteLine("number2 is bigger");
            }
            else
            {
                Console.WriteLine("number2 is equal number1");
            }
            // if else else if
            
        }
            


//        95 - 100	A		Excellent
//        90 - 94	A-
//        85 - 89	B+		Good
//        80 - 84	B
//        75 - 79	B-
//        70 - 74	C+		Satisfactory
//        65 - 69	C
//        60 - 64	C-
//        55 - 59	D+
//        50 - 54	D
//        0 - 49	F		Unsatisfactory
//        0 - 49	FC

            //nested if
            // if(t <= 10){
            //     Console.WriteLine($"{t} less or equal {10}");
            //     if(t <= 5)
            //         Console.WriteLine($"{t} less or equal {5}");
            //     else
            //         Console.WriteLine($"{t} bigger than {5}");
            // }else
            //     Console.WriteLine($"{t} bigger than {10}");


            //ternary operation
            //  bool b = (t == 1)? true : false;
            // Console.WriteLine(b);


            //switch case statements
            // switch(t){
            //     case 1:
            //     Console.WriteLine(1);
            //     break;
            //     case 2:
            //     Console.WriteLine(2);
            //     break;
            //     case 3:
            //     Console.WriteLine(3);
            //     break;
            //     case 4:
            //     Console.WriteLine(4);
            //     break;
            //     default:
            //       Console.WriteLine("default");
            //       break;
                
            // }

            // if else statements
            // if(t == 11){
            //     Console.WriteLine(11);
            // }else if (t > 0 && t < 11){
            //     Console.WriteLine("less");
            // }
            // else{
            //     Console.WriteLine(false);
            // }


            //&& || ! - logistic operands
            
            //== >= <= < > - Camprassion operands

            //Console.WriteLine("Hello World!");
        
    }
}
