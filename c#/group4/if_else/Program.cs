using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {


            // Console.WriteLine("Hello World!");
            // int t = 4, t2 = 5;
            // int s = t+t2, m = t - t2, mult = t * t2;
            // double d = (double)t/t2;

            // System.Console.WriteLine
            // ($"summ = {s} \nminus = {m}\nmultiply = {mult}\ndiv = {d}");

            // bool m1 = t%2==1;
            // System.Console.WriteLine(m1);


            // int t = 30;
  
            // if(t % 2 == 1)
            // {
            //     System.Console.WriteLine("odd");
            // }
            // if(t == 30)
            // {
            //     System.Console.WriteLine("t equal 30");
            // }
            // else if (t >20)
            // {
            //     System.Console.WriteLine("bigger then 20");
            // }
            // else if (t < 100)
            // {
            //     System.Console.WriteLine("t less then 100");
            // }
            // else
            //     System.Console.WriteLine("even");

            // System.Console.WriteLine("Exit");

            // int t = Convert.ToInt32(Console.ReadLine());

            // if(t  > 100)
            // {
            //     System.Console.WriteLine("t > 100");
            //     if(t < 1000)
            //     {
            //         System.Console.WriteLine("t < 1000");
            //     }
            //     else 
            //     {
            //         System.Console.WriteLine("T > 100 and > 1000 ");
            //     }
            // }
            // else if(t < 100)
            // {
            //     System.Console.WriteLine("t < 100");
            //     if(t < 10)
            //     {
            //         System.Console.WriteLine("t < 10");
            //     }
            //     else 
            //     {
            //         System.Console.WriteLine("T < 100 and > 10 ");
            //     }
            // }

            // int y = 5;
            // bool Or = y == 5 || y < 5; 

            // if(Or)
            //     System.Console.WriteLine("y == 5 or y < 5");

            // else if((y  > 5 && y < 10))  
            //     System.Console.WriteLine("y > 5 and y < 10 ");


            // int temp = 1;
            // switch(temp)
            // {
            //     case 1:
            //         System.Console.WriteLine("Jan");
            //         break;
            //     case 2:
            //         System.Console.WriteLine("Feb");
            //         break;
            //     case 3:
            //     case 4:
            //     case 5:
            //         System.Console.WriteLine("Spring");
            //         break;
            //     default:
            //         System.Console.WriteLine("No");
            //         break;
            // }
            // System.Console.WriteLine("Exit");

            // string t = Console.ReadLine();
            // int r = Convert.ToInt32(Console.ReadLine());
            // int y = Convert.ToInt32("1234");
            // System.Console.WriteLine(t);


            // int t = Convert.ToInt32(Console.ReadLine());

            // if(t >= 100)
            //     System.Console.WriteLine("A");
            // else
            // {

            //     switch(t/5)
            //     {
            //         case 19:
            //             System.Console.WriteLine("A");
            //             break;
            //         case 18:
            //             System.Console.WriteLine("A-");
            //             break;
            //         case 17:
            //             System.Console.WriteLine("B+");
            //             break;
            //         case 16:
            //             System.Console.WriteLine("B");
            //             break;
            //         case 15:
            //             System.Console.WriteLine("B-");
            //             break;
            //         case 14:
            //             System.Console.WriteLine("C+");
            //             break;
            //         case 13:
            //             System.Console.WriteLine("C");
            //             break;
            //         case 12:
            //             System.Console.WriteLine("C-");
            //             break;
            //         case 11:
            //             System.Console.WriteLine("D+");
            //             break;
            //         case 10:
            //             System.Console.WriteLine("D");
            //             break;
            //         default:
            //             System.Console.WriteLine("F");
            //             break;
            //     }
            // }


            // int i;
            // for(i = 0 ;i < 5; i++)
            // {
            //     System.Console.WriteLine("Hello Wolrd");
            // }

            // System.Console.WriteLine(i);


            // for(;;)
            // {
            //     System.Console.WriteLine("Hello world");
            // }
            

            // for(int i = 0, j = 10; i <= j; i++, j--)
            // {
            //     System.Console.WriteLine($"i = {i}\nj= {j}");
            // }


            // int num = 5;
            // int sum = 0;
            // for(int i = 0; i < num; sum += ++i);
            // System.Console.WriteLine(sum);

            // int z = 0;
            // while(z < 10)
            // {
            //     System.Console.WriteLine(z);
            //     z++;
            // }

            int r = 0;
            do
            {
                System.Console.WriteLine(r);
                r++;
            }
            while(r < 0);

            // while(true){}
           

            // mylabelFor:
            //     int y = 0;
            //     for(;;y++)
            //     {
            //         System.Console.WriteLine(y);
            //         if(y == 10)
            //             goto myLabel;

            //     }
            
            // myLabel:
            //     // goto mylabelFor;
            //     System.Console.WriteLine("Exit");
            // System.Console.WriteLine("CSSCCSC");

            int u = 10;

            // for(int i =0; i <= u; i++)
            // {
            //     if(i % 2 == 1)
            //         continue;
            //     System.Console.WriteLine(i);
                
            // }

            // for(int i =0; i <= u; i++)
            // {
            //     if(i % 2 == 1)
            //         break;
            //     System.Console.WriteLine(i);
                
            // }

            int t = 0;
            while(t < 10)
            {
                if(t % 2 == 1)
                {
                    t++;
                    continue;
                }
              
                System.Console.WriteLine(t++);
            }

        

        }
    }
}

// 95 - 100	A	4	Excellent
// 90 - 94	A-	3.67
// 85 - 89	B+	3.33	Good
// 80 - 84	B	3
// 75 - 79	B-	2.67
// 70 - 74	C+	2.33
// 65 - 69	C	2	Satisfactory
// 60 - 64	C-	1.67
// 55 - 59	D+	1.33
// 50 - 54	D	1	Unsatisfactory
// 0 - 49	F	0
