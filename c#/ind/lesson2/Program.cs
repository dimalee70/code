using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int decInt = 10;

            // Console.WriteLine(++decInt);
            // System.Console.WriteLine(decInt);

            // bool isBigger = 20 == 30;
            // System.Console.WriteLine(isBigger);
                    //or //and /xor
            // 0 0  0     0    0     
            // 0 1  1     0    1
            // 1 0  1     0    1
            // 1 1  1     1    0

            // int orOne = 10;             //1010
            // int orTwo = 5;              //0101
            // int orAns = orOne | orTwo;  //1111

            // System.Console.WriteLine(orOne);
            // System.Console.WriteLine(Convert.ToString(orOne, 2));
            // System.Console.WriteLine(orTwo);
            // System.Console.WriteLine(Convert.ToString(orTwo, 2));
            // System.Console.WriteLine(orAns);
            // System.Console.WriteLine(Convert.ToString(orAns, 2));

            // int andOne = 10;               //1010
            // int andTwo = 5;                //0101
            // int andAns = andOne & andTwo;  //0000

            // System.Console.WriteLine(andOne);
            // System.Console.WriteLine(Convert.ToString(andOne, 2));
            // System.Console.WriteLine(andTwo);
            // System.Console.WriteLine(Convert.ToString(andTwo, 2));
            // System.Console.WriteLine(andAns);
            // System.Console.WriteLine(Convert.ToString(andAns, 2));

            // int xorOne = 10;               //1010
            // int xorTwo = 15;               //1111
            // int xorAns = xorOne ^ xorTwo;  //0101

            // System.Console.WriteLine(xorOne);
            // System.Console.WriteLine(Convert.ToString(xorOne, 2));
            // System.Console.WriteLine(xorTwo);
            // System.Console.WriteLine(Convert.ToString(xorTwo, 2));
            // System.Console.WriteLine(xorAns);
            // System.Console.WriteLine(Convert.ToString(xorAns, 2));


            // bool myAndBool = (30 < 20) && (20 > 10);
            // System.Console.WriteLine(myAndBool);
            // bool myOrBool = (30 < 20) || (20 > 10);
            // System.Console.WriteLine(myOrBool);
            // bool myNoBool = !(30 < 20) && (20 > 10);
            // System.Console.WriteLine(myNoBool);
            
            // int x, y,z ;
            // x = y = z = 20;

            // int x = 10;
            // // x = x + 20;
            // x += 20;
            // System.Console.WriteLine(x);

            // int oneRight = 30;              //11110
            // int shiftRight = oneRight >> 3; //00011
            // System.Console.WriteLine(oneRight);
            // System.Console.WriteLine(Convert.ToString(oneRight, 2));
            // System.Console.WriteLine(shiftRight);
            // System.Console.WriteLine(Convert.ToString(shiftRight, 2));

            // int oneLeft = 30;              //00011110
            // int shiftLeft = oneLeft << 3;  //11110000
            // System.Console.WriteLine(oneLeft);
            // System.Console.WriteLine(Convert.ToString(oneLeft, 2));
            // System.Console.WriteLine(shiftLeft);
            // System.Console.WriteLine(Convert.ToString(shiftLeft, 2));
            
            // int oneComp = 30;              //0000 0000 0000 0000 0000 0000 0001 1110
            // int comp = ~oneComp;           //1111 1111 1111 1111 1111 1111 1110 0001
            // System.Console.WriteLine(oneComp);
            // System.Console.WriteLine(Convert.ToString(oneComp, 2));
            // System.Console.WriteLine(comp);
            // System.Console.WriteLine(Convert.ToString(comp, 2));

            // int a = 10,b = 15;
            // string answer = (a > b)? "A is bigger": "A is not bigger";

            // int answerInt = (a > b)? 20: 30;
            // System.Console.WriteLine(answerInt);

            // short myShort = 100;
            // int shortToInt = myShort;
            // int myIntToShort = 80000000;

            // short intToShort = (short)myIntToShort;
            // System.Console.WriteLine(intToShort);

            // double myDouble = 1324.43434;
            // int intFromDouble = (int)myDouble;
            // System.Console.WriteLine(intFromDouble);

            // double myDoubleFromInt = intFromDouble;
            // System.Console.WriteLine(myDoubleFromInt);

            // char myChar = 'A';

            // int intFromChar = (int) myChar;
            // System.Console.WriteLine(intFromChar);

            // char myCharFromInt = (char) 65;
            // System.Console.WriteLine(myCharFromInt);

            int parseInt = Int32.Parse("10");
            int tryParseInt;
            Int32.TryParse("10ewfees", out tryParseInt);
            System.Console.WriteLine(tryParseInt);



        }
    }
}
