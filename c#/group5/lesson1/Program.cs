using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte t = 12;
            // sbyte mySByte = -12;

            // short myShort = -12;
            // ushort myUshort = 3432;

            // long myLong = 2131231323122131221L;
            // ulong myULong = 3423423432423432;
            // char myChar = 's';

            // double myDouble = 123.221323423423423;
            // float myFloat = 12123.2123243423423423F;

            // // System.Console.WriteLine(myDouble);
            // // System.Console.WriteLine(myFloat);

            // bool myBool = true;
            
            // // System.Console.WriteLine(324232);

            // // System.Console.WriteLine(myLong);

            // decimal myDecimal = 3443442322.43435456765756756M;
            // // System.Console.WriteLine(myDecimal);

            // var myVar = "reccrcerc";
            // dynamic myDynamic ="fefcecfevfv";
            
            // myDynamic = 123;

            // object obj = 1232;

            // short mySh = 3242;
            // int myIn = 2132312312;

            // short m = (short)myIn;
            // // System.Console.WriteLine(myIn);
            // System.Console.WriteLine(Convert.ToString(m,2));
            // System.Console.WriteLine(Convert.ToString(myIn,2));


            // double myD = 12.334;
            // int convertFromDouble = (int)myD;
            // System.Console.WriteLine(convertFromDouble);
            // System.Console.WriteLine
            // ((double) convertFromDouble);

            // string myStr = "\"Hello \n\'Wor\tld\"";
            // string myStrReference = new string("fdfvd");

            // System.Console.WriteLine(myStr);

            // System.Console.WriteLine("Hello\roo");

            // string concatStr = "Hello " + "World";
            // System.Console.WriteLine(concatStr);

            // System.Console.WriteLine("Hello " + "world");

            // System.Console.WriteLine($"Hello {concatStr}");

            // System.Console.WriteLine("dfergr {0} {1}",
            //  concatStr, "Why");

            // System.Console.WriteLine("Enter the word");
            // // string world = Console.ReadLine();

            // // System.Console.WriteLine();
            // // System.Console.WriteLine(world);


            // int intFromStr = Convert.ToInt32("123");

            // System.Console.WriteLine(intFromStr);

            // System.Console.WriteLine("Enter the number");

            // // int a = Convert
            // //     .ToInt32
            // //     (Console.ReadLine());

            // string a = Console.ReadLine();

            // // int b = Convert
            // //     .ToInt32
            // //     (Console.ReadLine());

            // string b = Console.ReadLine();



            // System.Console.WriteLine(a + b);

            // const double Pi = 3.14;

            // // int myIntHex = 0x111111;
            // // System.Console.WriteLine(myIntHex);

            // int myIntBynary =  0b1;

            // int myIntD = 100_9_____________99_____0;

            // char myUniChar = '\u0023';
            // System.Console.WriteLine(myUniChar);

            // int nullInt = 121;

            // int? myNullableInt = null;
            // bool? myBoolNulable = null;

            // string myNullStr = null;

            // int w ,e =34,r,y = 34;

            // // 3 + 5 * 4;
            // int incInt = 4;
            
            // System.Console.WriteLine(incInt++);
            // System.Console.WriteLine(incInt);


            int fiveBin = 5;//101
            int sevenBin = 7;//111

            int fiveAndFive = fiveBin & sevenBin;
            int fiveOrFive = fiveBin | sevenBin;
            int fiveXOrFive = fiveBin ^ sevenBin;

            // System.Console.WriteLine(Convert
            //     .ToString(fiveBin,2));

            System.Console.WriteLine(fiveAndFive);
            
            System.Console.WriteLine(Convert
                .ToString(fiveAndFive,2));

            System.Console.WriteLine(fiveOrFive);
                  System.Console.WriteLine(Convert
                .ToString(fiveOrFive,2));

            System.Console.WriteLine(fiveXOrFive);
                  System.Console.WriteLine(Convert
                .ToString(fiveXOrFive,2));


            int x = 5;
            x+= 20;
            System.Console.WriteLine(Convert.ToString(~x,2));
            System.Console.WriteLine(~x + 1);

          
            int a = 5;
            int b = 5;

            string answer = (a > b)? "A is bigger"
            :(a == b)? "A and B is equal ": "B is bigger";

            Console.BackgroundColor = 
            ConsoleColor.Green;
            System.Console.WriteLine(answer);

            // char t = (char)Console.Read();

            // System.Console.WriteLine(t);

            Console.ReadKey();














            // int t;
            // int t1 = 5;
            // t = 6;

            // Console.WriteLine("Hello World!");
        }
    }
}
