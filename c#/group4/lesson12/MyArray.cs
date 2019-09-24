using System;
namespace lesson12
{
    public class MyArray : AbstractArray
    {
        public MyArray(int[] arr) : base(arr)
        {
        }



        public String returnName()
        {
            return "MyArray";
        }
        public override void print()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i]+ " ");
            }
            System.Console.WriteLine();
        }
    }
}