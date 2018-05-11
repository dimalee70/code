using System;
using System.Collections.Generic;

namespace lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> st = new Stack<int>();
            // Console.WriteLine("Hello World!");
            // MyStack s = new MyStack(3);
            // s.push(5);
            // s.push(2);
            // s.push(3);
            // //s.push(4);//The stack is full
            // Console.WriteLine(s.peek());//3

            // // s.pop();
            // // s.pop();
            // Console.WriteLine(s.peek());//2
            // // s.pop();
            // Console.WriteLine(s.isEmpty());//false
            // Console.WriteLine(s.isFull());//false

            MyQueue q = new MyQueue(2);
            q.enqueue(5);
            q.enqueue(2);
            //q.enqueue(3);//The queue is full
            Console.WriteLine(q.peek());//5
            q.dequeue();
            Console.WriteLine(q.peek());//2
            q.dequeue();
            Console.WriteLine(q.isEmpty());//false
            Console.WriteLine(q.isFull());//false
        }
    }
}
