using System;

namespace lesson2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                // MyFormatException myFormatException = 
                // new MyFormatException("Divide by zero");

                try
                {
                    int answer = a/b;
                }catch(DivideByZeroException)
                {
                    System.Console.WriteLine("error division");
                }
             


                // if(b == 0)
                // throw new MyFormatException("throw ex");
                // throw myFormatException;
                // else
                // {
                    System.Console.WriteLine
                    ("a divide by b is equal " + a/b);
                // }
            }
          
            catch(OverflowException e)
            {
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine("efe");
            }

            catch(Exception d)
            {
                // d.PrintMessage();
                System.Console.WriteLine(d.StackTrace);
                // throw new MyFormatException("error").PrintMessage();
            }

            finally
            {
                System.Console.WriteLine("Finally");
            }
            System.Console.WriteLine("Out of try");

    

        // catch()
        




            













            // try
            // {
            //     System.Console.WriteLine("Enter the number");
            //     int age = Convert.ToInt32(Console.ReadLine());
            //     int answer = age/2;
            //     int [] arr = new int[4];
            //     arr [2] = 23;
            //     System.Console.WriteLine("Hello");

            //     // arr[6] = 4;

            //     System.Console.WriteLine("End");

            // }
            // catch(FormatException e)
            // {
            //     // MyFormatException fr = new MyFormatException("My Error Format Exception");

            //     // fr.PrintMessage();


            //     // System.Console.WriteLine(f.Message);
            //     // f.PrintMessage();


            //     // Console.BackgroundColor = ConsoleColor.Yellow;
            //     // Console.ForegroundColor = ConsoleColor.Red;
            //     // System.Console.WriteLine(fr.StackTrace);
            //     // System.Console.WriteLine("Error with format");
            // }
            // catch(DivideByZeroException d)
            // {
            //     System.Console.WriteLine("Error division");
            // }
            // catch(IndexOutOfRangeException t )
            // {
            //     System.Console.WriteLine("Index");
            // }
            // catch(Exception ex)
            // {
            //     System.Console.WriteLine("Error");
            // }
            // finally
            // {
            //     System.Console.WriteLine("Final");
            // }
       
         
        }
    }
}
