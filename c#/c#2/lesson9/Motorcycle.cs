using System;
using System.Diagnostics;

namespace lesson9
{
    class Motorcycle
    {
        [Conditional("Use")]

        public void UseMotorcycle()
        {
                // System.Console.WriteLine("safddfds");
            Console.WriteLine("Доступен");
        }

        [Conditional("NoUse")]
        public void NoUseMotorcycle()
        {
            Console.WriteLine("Не доступен");
        }
    }
}
    