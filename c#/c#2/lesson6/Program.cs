using System;
using System.IO;
using System.Text;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            // int y;
            // int t = 9;
            // y = 0;
            // if(y == 0){
            //       throw new DivideByZeroException("Вы тупой!");
            // }
            

          
            try

            {
                int y;
                int t = 9;
                y = 0;
                System.Console.WriteLine(t/y);
                FileInfo file = new FileInfo("/home/dmitriy/lesson.txt");
                // file.OpenWrite();
                // StreamWriter fs = file.CreateText();
                using (StreamWriter sw = file.CreateText()) 
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
                using (FileStream stream = File.Open("/home/lesson.txt", FileMode.Open));
            }
            catch(DivideByZeroException ex)
            {
                System.Console.WriteLine("Error to open file");
                System.Console.WriteLine(ex.StackTrace);

            }
            catch(FileNotFoundException ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                //hahahav
                System.Console.WriteLine("End");
                
            }
            Console.WriteLine("Hello World!");
        }
    }
}
