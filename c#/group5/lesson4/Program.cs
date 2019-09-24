using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // //1
            // System.Console.WriteLine("1!!");
            // int a = Convert.ToInt32(Console.ReadLine());
            // int b = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine(a+b);
            // System.Console.WriteLine(a-b);
            // System.Console.WriteLine(a/b);
            // System.Console.WriteLine(+ a*b);

            // //2
            // System.Console.WriteLine("2!!");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // bool check = (n1>n2);
            // System.Console.WriteLine(check.ToString());

            // //3
            // System.Console.WriteLine("3!!");
            // int x = Convert.ToInt32(Console.ReadLine());
            // bool check2 = (x%2==0);
            // System.Console.WriteLine(check);

            // //4
            // System.Console.WriteLine("4!!");
            // int q1 = Convert.ToInt32(Console.ReadLine());
            // int q2 = Convert.ToInt32(Console.ReadLine());
            // int q3 = Convert.ToInt32(Console.ReadLine());
            // int q4 = Convert.ToInt32(Console.ReadLine());
            // int q5 = Convert.ToInt32(Console.ReadLine());
            // Console.BackgroundColor = ConsoleColor.Green;
            // Console.ForegroundColor = ConsoleColor.Red;
            // System.Console.WriteLine("sum= "+ (q1+q2+q3+q4+q5));
            // Console.BackgroundColor = ConsoleColor.White;
            // Console.ForegroundColor = ConsoleColor.Black;

            // //5
            // System.Console.WriteLine("5!!");
            // int t1 = Convert.ToInt32(Console.ReadLine());
            // int t2 = Convert.ToInt32(Console.ReadLine());
            // int t3 = Convert.ToInt32(Console.ReadLine());
            // int res = t1>t2?(t1>t3?t1:t3):(t2>t3?t2:t3);
            // System.Console.WriteLine(res);
            // //6
            // System.Console.WriteLine("6!!");
            // string name = Console.ReadLine();
            // string sname = Console.ReadLine();
            // System.Console.WriteLine("Привет! Ваше имя " +name +
            //                         "\t Ваша фамилия " +sname);

            //1
            // System.Console.WriteLine("1!!");
            // int z = Convert.ToInt32(Console.ReadLine());
            // if(z%2==0) System.Console.WriteLine(z +"is even");
            // if(z%2!=0) System.Console.WriteLine(z +"is odd");

            // //2
            // System.Console.WriteLine("2!!");
            // int z2 = Convert.ToInt32(Console.ReadLine());
            // if(z2>10000 && z2< 99999) System.Console.WriteLine("5");
            // else if(z2>1000 && z2< 9999) System.Console.WriteLine("4");
            // else if(z2>100 && z2< 999) System.Console.WriteLine("3");
            // else if(z2>10 && z2< 99) System.Console.WriteLine("2");
            // else if(z2>0 && z2< 9) System.Console.WriteLine("1");
            // else System.Console.WriteLine("Error");

            // //3
            // System.Console.WriteLine("3!!");
            // char c = (char)Console.Read();
            // Console.ReadLine();

            // // Console.Read()

            // if(c>=65 && c<=90 ){
            //     c = Convert.ToChar(Convert.ToInt32(c)+ 32);
            //     System.Console.WriteLine(c);
            // }
            // else{
            //     c = Convert.ToChar(Convert.ToInt32(c)- 32);
            //     System.Console.WriteLine(c);
            // }
            // // // System.Console.WriteLine();


            // //4
            // System.Console.WriteLine("4");

            // // System.Console.WriteLine(Console.ReadLine());
            // int month = Convert.ToInt32(Console.ReadLine());
            // if(month>=3 && month<=5) System.Console.WriteLine("Spring");
            // else if(month>=6 && month<=8) System.Console.WriteLine("Summer");
            // else if(month>=3 && month<=5) System.Console.WriteLine("Autumn");
            // else if(month == 1 ||month==2 || month==12 ) System.Console.WriteLine("Winter");
            // else System.Console.WriteLine("Error");

            // //5
            // System.Console.WriteLine("5!!");
            // int p = Convert.ToInt32(Console.ReadLine());
            // switch(p){
            //     case 1: System.Console.WriteLine("Большой");
            //     break;
            //     case 2: System.Console.WriteLine("Указательный");
            //     break;
            //     case 3: System.Console.WriteLine("Средний");
            //     break;
            //     case 4: System.Console.WriteLine("Безымянный");
            //     break;
            //     case 5: System.Console.WriteLine("Мизинец");
            //     break;
            //     default: System.Console.WriteLine("Error");
            //     break;
            // }

            // //6 
            // System.Console.WriteLine("6!!");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // int r = n1*n2;
            // System.Console.WriteLine("Enter result:");
            // int rcheck =Convert.ToInt32(Console.ReadLine());
            // if(rcheck == r) System.Console.WriteLine("true");
            // else System.Console.WriteLine( r);

            // //7
            // System.Console.WriteLine("7!!");
            // int x1 =Convert.ToInt32(Console.ReadLine());
            // int x2 =Convert.ToInt32(Console.ReadLine());
            // int x3 =Convert.ToInt32(Console.ReadLine());

            // if(x1==x2 || x1==x3|| x2==x3){
            //     x1+=5;
            //     x2+=5;
            //     x3+=5;
            //     System.Console.WriteLine((x1)+", "+(x2)+", "+(x3));
            // }



            //1.a
            System.Console.WriteLine("1.a!!");
            int n= 0;
            while(n!=5){
               n = Convert.ToInt32(Console.ReadLine()); 
               for(int i=0; i<n; i++ ){
                   if(i%2!=0)
                   System.Console.WriteLine(i);
               }
            }

            //1.b
            System.Console.WriteLine("1.b!!");
            int n2= 0;
            int sum1=0;
            int sum2=0;
            while(n2!=5){
               n2 = Convert.ToInt32(Console.ReadLine()); 
               for(int i=0; i<n2; i++ ){
                   if(i%2!=0) sum1+=i;
                   else sum2+=i;
               }
               System.Console.WriteLine("Сумма четных"+(sum2));
               System.Console.WriteLine("Сумма нечетных"+(sum1));
               sum1=sum2=0;
            }

            //1.c
            System.Console.WriteLine("1.c!!");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine()); 
            while(n!=5){
               n = Convert.ToInt32(Console.ReadLine()); 
               for(int i=0; i<n; i++ ){
                   if(i%2!=0)
                   System.Console.WriteLine(i);
               }
            }

        }
    }
}


