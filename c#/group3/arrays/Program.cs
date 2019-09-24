using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <=  n/2; i++)
            {
                for(int j = 0; j < (n/2) - i; j++)
                {
                    System.Console.Write(" ");
                }
                for(int j = (n/2)-i; j <=(n/2) + i; j++)
                {

                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
