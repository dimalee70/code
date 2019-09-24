using System;

namespace lesson2_1
{
    public class MyStack:IMyCollection
    {
        public int [] arr{get;set;}
        private int index = 0;
         
        public MyStack(int size)
        {
            arr = new int [size];
        }
        public void push(int num)
        {
            if(index == arr.Length)
            {
                System.Console.WriteLine("Arr is Full");
                return;
            }
            arr[index++] = num;
        }

        public void printArr()
        {
            for(int i = 0; i < index; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
            // foreach(int i in arr)
            // {
            //     System.Console.Write(i + " ");
            // }
            System.Console.WriteLine();
        }

        public int pop()
        {
            if(index == 0)
            {
                return -1;
            }
            return arr[--index];
        }

        public int peek()
        {
            // --index;
            // index - 1;
            return arr[index - 1];
        }

        public int getSize()
        {
            return index;
        }
    }    
}