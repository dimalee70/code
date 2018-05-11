using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Цикл for
            // for (инициализатор; условие; итератор)
            // {
            //     оператор (операторы);
            //     }
            // for(int i = 0; i < 5;i++){
            //     int t = 10;
            // }

            // Применение нескольких переменных управления циклом
            // for (byte i = 0, j = 20; i < j; i += 5, j -= 5)
            //     Console.WriteLine("i = {0}, j = {1} {2} {0} {2} {1} ",i,j,"htrt");
            // Console.WriteLine();

            // Использование условного выражения в цикле
            // bool b = false;
            // for (byte i = 1, j = 100; !b; i++, j--)
            //     if (i < Math.Sqrt(j))
            //         Console.WriteLine("Число {0} меньше квадратного корня из {1}", i, j);
            //     else 
            //         b = true;

            //Отсутствие части цикла
            // int k = 0;
            // for (;k < 10; )
            // {
            //     k++;
            //     Console.Write(k);
            // }
            // Console.WriteLine("\n");

            // Цикл без тела
            // int sum = 0;
            // for (int i = 0; i <= 5; ++i){
            //     sum += i;
            // }
            // System.Console.WriteLine(sum);
            // for (int i = 1; i <= 5; sum += ++i);
            
            // Console.WriteLine("Значение суммы: {0}",sum);
            // Console.WriteLine("Hello World!");


            // 2.Цикл while
        //  while(условие)
        //     {
        //      оператор (операторы);
        //     };

            // byte l = 2, i = 0;
            // int result = 1;

            // while (i < 10)
            // {
            //     i++;
            //     result *= l;
            //     Console.WriteLine("{0} в степени {1} равно {2}",l,i,result);
            // }


            //3.Цикл do. . . while
            // do {
            //     операторы;
            // } while (условие);
            // int i, result = 1, num = 1;

            // Console.WriteLine("Введите число:");
            // i = int.Parse(Console.ReadLine());

            // Console.Write("\n\nФакториал {0} = ", i);
            // do
            // {
            //     result *= num;
            //     num++;
            // } while (num <= i);

            // Console.Write(result);

            // 4.Цикл foreach
            // foreach (тип имя_переменной_цикла in коллекция){
            //         оператор;
            //     }
            // string name = "Dmitriy";
            // foreach(char c in name){
            //     Console.Write(c + " ");
            // }

            // break
            // int r;
            // for(int y = 1; y < 100; y++){
            //     if(y % 5==0){
            //         r= y;
            //         System.Console.WriteLine(r);
            //         break;
            //     }
            // }

            //continue
            // for (int i = 0; i <=10 ; i++){
            //     if(i %2 == 0){
            //         continue;
            //     }
            //     System.Console.WriteLine($"{i} ");
            // }

            //goto
                   
 
            // label1: //creating label with colon(:)
            //     Console.WriteLine("Enter your name: ");
            //     string name = Console.ReadLine();
            //     if(name == "E"){
            //         goto exit;
            //     }
            //     Console.WriteLine("Welcome {0}", name);
            //     Console.WriteLine("Press Ctrl + C for Exit\n");
            //     goto label1; 
            // exit:
            //     System.Console.WriteLine("Exit");
            // for (int i = 0; i < 5; i++){
            //     for (int j = 0; j < 5 ;j++){
            //         System.Console.Write(j);
            //     }
            //     System.Console.WriteLine("Name");
            // }
        }
    }
}
