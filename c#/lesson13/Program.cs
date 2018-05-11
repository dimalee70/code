using System;

namespace lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int b = 5;
            int c = 6;
            System.Console.WriteLine(-5 | 6);
            string n = "edfsdf";
            MyPoint mp1 = new MyPoint(-1,-2,-3);
            MyPoint mp2 = new MyPoint(4,5,6);
            MyPoint mp3 = mp1 + mp2;
            System.Console.WriteLine("X " + mp3.myX);
            System.Console.WriteLine("Y " + mp3.myY);
            System.Console.WriteLine("Z " + mp3.myZ);
            System.Console.WriteLine(b + n);
            
            
            
            ++mp1;
            System.Console.WriteLine("X " + mp1.myX);
            System.Console.WriteLine("Y " + mp1.myY);
            System.Console.WriteLine("Z " + mp1.myZ);

            if(mp1){
                System.Console.WriteLine("Все положительные");
            }else{
                System.Console.WriteLine("Какой то отрицательный");
            }
            //Перегрузка бинарных операторов
            //Перегрузка унарных операторов
            //++
            //Перегрузка операторов отношения
            //!=   ==	
            //<    >
            //<=   >=
            //Перегрузка логических операторов
            // &, |, !, && и ||

            if(mp1 > mp2){
                System.Console.WriteLine("Mp1 bigger");
            }else{
                System.Console.WriteLine("Mp1 less or equal");
            }
            if(mp1 < mp2){
                System.Console.WriteLine("Mp1 less or equal");
            }else{
                System.Console.WriteLine("Mp1 bigger");
            }

            if(mp1 | mp2){
                System.Console.WriteLine("Have -");
            }
            else{
                System.Console.WriteLine("Not have -");
            }

            
            if(mp1 & mp2){
                System.Console.WriteLine("All -");
            }
            else{
                System.Console.WriteLine("Have +");
            }
            System.Console.WriteLine(mp1);

            foreach(int t in (int []) mp1){
                System.Console.WriteLine(t);
            }


            //оператором преобразования.
            //явное
            //explicit operator

            //неявное
            //implicit operator

        }
    }
}
