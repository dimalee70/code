using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = 5;
            // int t = n % 3;

            // Console.WriteLine(++n);
            // bool myBool = n == 5;

            // int myBin = 2;// 10
            // int myBin2 = 1;//01
            // int andOp = myBin & myBin2;
            // int orOp = myBin | myBin2;
            // int xorOp = myBin ^ myBin2;

            // System.Console.WriteLine(Convert.ToString(andOp,2));
            // System.Console.WriteLine(andOp);
            // System.Console.WriteLine(orOp);
            // System.Console.WriteLine(Convert.ToString(xorOp,2));
            // System.Console.WriteLine();

            bool ifOprAnd = (5 == 5) && (5 != 5);

            bool ifOprOr = (5 == 5) || (5 != 5);

            bool ifOprNot = !((5 == 5) || (5 != 5));

            System.Console.WriteLine(ifOprAnd);
            System.Console.WriteLine(ifOprOr);
            System.Console.WriteLine(ifOprNot);
            
            int t,r = 3 ,y,u,i;
            t = y = u = i = 8;
            
            t = 5;

            t = t + 5;
            t += 5;

            // int binONE = 2; //10
            // int binTwo = 2; //10

            // binONE &= binTwo;

            // binONE = binONE & 2;

            // System.Console.WriteLine(Convert.ToString(binONE, 2)); 

            int myIntMod = 10;

            myIntMod %= 7;

            myIntMod %= 2;

            System.Console.WriteLine(myIntMod);

            int binNine = 9;//1001	

            binNine = binNine >> 3;


            System.Console.WriteLine(binNine);

            int shiftLeft = 9 << 3;
            System.Console.WriteLine(shiftLeft);
            System.Console.WriteLine("test " + Convert.ToString(shiftLeft,2));

            long complement = 9l;//1001;
            System.Console.WriteLine(Convert.ToString
                (~complement,2));

                System.Console.WriteLine(344);


            int num1 = 16;
            int num2 = 15;
            string ans = 
                (num1 < num2)?"Num2 bigger"
                :"Num1 bigger";

            int y1 = (num1 == num2)?
                0:(num1 > num2)? 1:
                (num1 < num2) ? - 1:
                -12;
            System.Console.WriteLine(y1);
            byte myByte = 250;


            short myShort = 300;

            byte byteFromShort = (byte) myShort;
            System.Console.WriteLine(byteFromShort);
            // int myInt = myShort;

            // System.Console.WriteLine(myInt);

            // char chrA = 'A';

            // System.Console.WriteLine("Number A " + (int) chrA);

            // string myDigit = "32";
            
            // int myIntDigit = Convert.ToInt32(myDigit);

            // System.Console.WriteLine(myIntDigit);

            // System.Console.WriteLine("Мое число = "  + myIntDigit);

            // System.Console.WriteLine($"Мое число = {myIntDigit} fvsvds{myDigit}");
            // System.Console.WriteLine("Мое число ={1} {0} fvsvds{1}{2}", myIntDigit, myIntMod,3);

            // System.Console.WriteLine("Enter the name ");
            // string name = Console.ReadLine();
            // System.Console.WriteLine($"Привет, {name}");
            // System.Console.WriteLine("Enter the number :");
            // int age = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine($"Your age is {age}");
            // System.Console.WriteLine();
            // System.Console.WriteLine("enter");
            // Console.BackgroundColor = ConsoleColor.DarkYellow;
            // Console.ForegroundColor = ConsoleColor.White;
            // int Read = Console.Read();
            // System.Console.WriteLine((char)Read);

            int M = Int32.Parse(Console.ReadLine());

            int p;
            Int32.TryParse(Console.ReadLine(), out p);

            System.Console.WriteLine(M);
            System.Console.WriteLine(p);



        }
    }
}
