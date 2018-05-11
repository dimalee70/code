using System;

namespace lesson10
{
    delegate Name UI (FamilyAndName obj);
    delegate int Operation(int x, int y);
    class Program
    {
        
        
        static void Main(string[] args)
        {
            // присваивание адреса метода через контруктор
            Operation del;
            del = Multiply;
            del += Add; // делегат указывает на метод Add
            
            Console.WriteLine(del(4,5));
    
            // del = Multiply; // теперь делегат указывает на метод Multiply
            // result = del(4, 5);
            // Console.WriteLine(result);
    


            // создаем банковский счет
            Account account = new Account(200);
            // Добавляем в делегат ссылку на метод Show_Message
            // а сам делегат передается в качестве параметра метода RegisterHandler
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            account.RegisterHandler(new Account.AccountStateHandler(Color_Message));
            // Два раза подряд пытаемся снять деньги
            account.Withdraw(100);
            account.Withdraw(150);

            int[] myArr = new int[6] { 2, -4, 10, 5, -6, 9 };

            // Структуируем делегаты
            OpStroke Del;
            OpStroke Del2;
            OpStroke Wr = ArrOperation.WriteArray;
            OpStroke OnSortArr = ArrOperation.IncSort;
            OpStroke OffSortArr = ArrOperation.DecSort;
            OpStroke ChArr = ArrOperation.ChetArr;
            OpStroke NeChArr = ArrOperation.NeChetArr;

            // Групповая адресация
            // int t += t ;
            // t + t
            Del = Wr;
            Del += OnSortArr;
            Del += ChArr;
            Del += OffSortArr;
            Del += NeChArr;

        //     // Выполняем делегат
            Del(ref myArr);
            // Del2 = ArrOperation.WriteArray;
            // Del2(ref myArr);
            
            myArr = new int[6] { 2, -4, 10, 5, -6, 9 };
            
            Del -= OnSortArr;
            Del -= ChArr;
            Del -= OffSortArr;
            Del -= NeChArr;
            Del(ref myArr);

        //     // Console.ReadLine();
        //     // Console.Read();
        //             // Групповая адресация


        // // Ковариантность и контравариантность делегатов
        // // Пример ковариантности
        // // Можно использовать метод, возвращаемым типом параметра которого 
        // //  является производный класс
        FamilyAndName familyAndName = new FamilyAndName("Jobs","Steve");
        UI user1 = UserInfo.UIFamilyName;
        user1(familyAndName);
        System.Console.WriteLine(familyAndName.myFamily);

        // // Пример контравариантности
        // // Можно использовать метод, аргументом которого является
        // // базовый класс
        user1 += UserInfo.UIName;
        user1(familyAndName);
        System.Console.WriteLine(familyAndName.myFamily);
        System.Console.WriteLine(familyAndName.myName);
        // user1(Name,FamilyAndName);
        }
        private static int Add(int x, int y)
        {
            return x+y;
        }
        private static int Multiply (int x, int y)
        {
            return x * y;
        }
        
        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
        private static void Color_Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }

        
    }
}
