using System;
namespace lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int [] arr = {1,2,3,4};
                System.Console.WriteLine("Enter the number");
                int t = Convert.ToInt32(Console.ReadLine());

                // System.Console.WriteLine(t/0);
                int i = 7;
                // if(i >= arr.Length)
                // {
                //     IndexOutOfRangeException error = new IndexOutOfRangeException("Error of index");
                //     error.HelpLink = "https://docs.google.com/document/d/1BX9JMwSngrF266V2LyGstx8nohAj89Y_gnG_nqt3lLg/edit";
                //     throw error;
                // }
                System.Console.WriteLine(arr[6]);
            }
    
            catch(IndexOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                    IndexOutOfRangeException error = new IndexOutOfRangeException("Error of index");
                    error.HelpLink = "https://docs.google.com/document/d/1BX9JMwSngrF266V2LyGstx8nohAj89Y_gnG_nqt3lLg/edit";
                    error.Source = "Ошибка из за того что вышел из индекса";
                    System.Console.WriteLine(error.Message);
                    System.Console.WriteLine(error.Source);
                    System.Console.WriteLine(error.HelpLink);
                Console.ForegroundColor = ConsoleColor.Black;
            }
        
            catch(FormatException fr)
            {
                System.Console.WriteLine(fr.StackTrace);

            }
            catch(DivideByZeroException ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
            // catch(Exception ex)
            // {
            //     System.Console.WriteLine(ex.HResult);
            //     System.Console.WriteLine("Stop");
            // }

            finally
            {
                System.Console.WriteLine("Final");
            }
            


            // Console.WriteLine("Hello World!");
            // Days day = Days.Thurday;
            // ClassDays classDays = new ClassDays(day);

            // Days [] days = (Days[])Enum.GetValues( typeof( Days ) );


            // string [] daysString = Enum.GetNames(typeof(Days));
            // System.Console.WriteLine(string.Join(" ", daysString));

            // foreach(Days d in days)
            // {
            //     System.Console.WriteLine(d + " " + (int) d);
            // }

            // classDays.printDay();

            // classDays.checkDay();
        }
    }
}
