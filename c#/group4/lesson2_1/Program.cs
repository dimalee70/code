using System;

namespace lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyStack myStack = new MyStack(5);
            myStack.push(5);
            myStack.printArr();
            myStack.push(7);
            myStack.printArr();
            myStack.push(10);
            myStack.printArr();
            myStack.push(20);
            myStack.printArr();
            myStack.push(20);
            myStack.printArr();
            myStack.push(20);
            myStack.printArr();

            System.Console.WriteLine(myStack.pop());
             myStack.printArr();
             System.Console.WriteLine(myStack.pop());
             System.Console.WriteLine(myStack.pop());
             myStack.printArr();
                System.Console.WriteLine(myStack.pop());
             System.Console.WriteLine(myStack.pop());
                System.Console.WriteLine(myStack.pop());
             System.Console.WriteLine(myStack.pop());

        }
    }
}
