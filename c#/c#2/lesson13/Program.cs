using System;
using System.Threading;

namespace lesson13
{
    class Program
    {
        public delegate void ThreadStart();
        static void Main(string[] args)
        {

            // Thread mythread = new Thread(fornewthread);
            // mythread.Start();
            // Console.WriteLine("Hello World!");





            // Thread t = new Thread(Go);     // Go – статический метод
            // t.Start();
            // t.Join(); // Ожидаем завершения потока
            // Thread t = new Thread(delegate() { Console.WriteLine("Hello!"); });
            // t.Start();
            // Go();
            // Thread t = new Thread(WriteY);
            // t.Start();            // Выполнить WriteY в новом потоке
            // while (true)
            //     Console.Write("x");
            
            // Thread mythread = new Thread(mythread1);

            int result = 0;
            // ParameterizedThreadStart parameterized += Add();
            for(int i =0;i< 10;i++){
                Thread mythread1 = new Thread(()=> Add(3,4,ref result)); 
                mythread1.Start();  
            }
            // Thread mythread1 = new Thread(()=> Add(3,4,ref result)); 
            // mythread1.Start();

            // mythread.Start();
            // mythread.IsBackground = true;
            
            Console.ReadKey();
            

            // Thread thread1 = new Thread(mythread1);
            // Thread thread2 = new Thread(mythread2);
            // Thread thread3 = new Thread(mythread3);
            // thread1.Priority = ThreadPriority.Highest;
            // thread2.Priority = ThreadPriority.AboveNormal;
            // thread3.Priority = ThreadPriority.Lowest;

 
            // thread1.Start();
            // thread2.Start();
            // thread3.Start();
 
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Поток 3 выводит " + i);
            // }
            
        }
        static void fornewthread()
        {
            System.Console.WriteLine("Hello from thread");
        }

        static void Add(int y,int z,ref int result){
            result += y+z;
            System.Console.WriteLine(result);
        }
        static void WriteY() 
        {
            while (true){
                Console.Write("y");
                // Thread.Sleep(TimeSpan.FromSeconds(30));
            } // Все время печатать 'y'
        }
        static void Go() 
        {
        // Определяем и используем локальную переменную 'cycles'
        for (int cycles = 0; cycles < 5; cycles++)
            Console.Write('?');
        }
        static void mythread1()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);
            }

        }
        static void mythread2()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
            }

        }
        static void mythread3()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine(i);
            }

        }
 

        // static void mythread2()
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine("Поток 2 выводит " + i);
        //     }
        // }
    }
}

// ThreadPriority.Highest
// ThreadPriority.AboveNormal;
// ThreadPriority.Lowest;

//В среде .NET Framework определены две разновидности потоков: приоритетный и фоновый