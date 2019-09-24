using System;
namespace lesson2
{
  class Program
  {
    static void Main(string[] args)
    {

      // int myInt = 6;

      // bool isEqual = myInt == 6;
      // System.Console.WriteLine(isEqual);
      // int myIntInc = myInt++;
      // isEqual = myInt != 6;

      // System.Console.WriteLine(isEqual);

      // System.Console.WriteLine(myIntInc);
      // System.Console.WriteLine(myInt);

      // --myInt;

      // System.Console.WriteLine(myInt);
      // myInt++; // myInt = myInt + 1;
      // System.Console.WriteLine(myInt+1);
      // int answer = myInt % 3;

      


      // Console.Title = "Работа с консолью";


      // int bin =  0b0101;
      // int bin2 = 0b0111;
            //     0111 
            //     0101
            //     0010

      // int hexNum = 0x7f;

      // System.Console.WriteLine(hexNum);
      // System.Console.WriteLine(bin | bin2);
      // System.Console.WriteLine(bin & bin2);
      // System.Console.WriteLine(bin ^ bin2);

      // bool myBool = 3 == 3;
      // bool myBool2 = 4 > 6;

      // bool andBool = myBool && myBool2; // true and false
      // bool orBool = myBool || myBool2; // true or false
      // bool notBool = (myBool && !myBool2); //not (false)

      // System.Console.WriteLine(andBool);
      // System.Console.WriteLine(orBool);
      // System.Console.WriteLine(notBool);


      char myChar; //декларация




      // myChar = 'T'; //инициализация

      // char myChar2 = 'G'; //декларация с инициализацией

      // char myChar3, myChar4 = 'd', myChar5;

      // myChar3 = myChar4 = myChar5 = 'R';

      double myDoule = 1.5;

      myDoule += 0.5;
      // myDoule = myDoule + 0.5;

      System.Console.WriteLine(myDoule);


      int bin =  0b101; //101000
      int bin2 = 0b0111;
            //     0111 
      // bin |= bin2;
      // bin = bin | bin2;

      // System.Console.WriteLine(bin);

      int binShiftRight = bin >> 3;
      int binShiftLeft = bin << 3;

      System.Console.WriteLine(Convert.ToString(binShiftLeft,2));
      System.Console.WriteLine(binShiftLeft);

      System.Console.WriteLine(Convert.ToString(~bin,2));

      int num1 = 30;
      int num2 = 20;
      string answer = (num1 > num2)? "Num1 bigger" : 
        (num1 == num2)? "Num1 equal Num2":"Num2 bigger";

      System.Console.WriteLine(answer);
      

      int intToShort = 65000;

      System.Console.WriteLine(Convert.ToString((int)intToShort,2));

      System.Console.WriteLine(intToShort);

      short intShort = (short)intToShort;


      double myDoubleToInt = 2.9;

      int fromDouble = (int)myDoubleToInt;

      System.Console.WriteLine(fromDouble);



      


      // System.Console.WriteLine(Convert.ToString((short)intShort,(short)2));
      // System.Console.WriteLine(intShort);


      // int 


      // short myShortToInt = 32000;

      // int intFromShort = myShortToInt;
      // System.Console.WriteLine(intFromShort);




  

      Console.Title = "Lesson 1";

      // Console.ForegroundColor = ConsoleColor.Green;
      // Console.BackgroundColor = ConsoleColor.Red;
          
      System.Console.WriteLine("Hello World");

      String name = "Dias";

      System.Console.WriteLine("Hello, " + name);

      System.Console.WriteLine($"Hello, {name}");

      System.Console.WriteLine("Hello {0}{1} ", name, 18);

      Console.ReadKey();

      System.Console.WriteLine("Enter the name ?");

      string userName = Console.ReadLine();
      int userAge = Convert.ToInt32(Console.ReadLine());


      System.Console.WriteLine($"Hello, your name is {userName}\nAge is {userAge}");

      


    }
  }
}