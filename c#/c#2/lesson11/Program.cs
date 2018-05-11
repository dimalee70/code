using System;

namespace lesson11
{
    delegate int Sum(int number);
    delegate void UI();
    // Создадим несколько делегатов имитирующих 
    // простейшую форму регистрации
    delegate void Captha(string s1, string s2);
    delegate int LengthLogin(string s);
    delegate bool BoolPassword(string s1, string s2);

    class Program
    {
        static Sum SomeVar()
        {
            int result = 0;
            System.Console.WriteLine(result);
            // Вызов анонимного метода
            Sum del = delegate (int number)
            {
                for (int i = 0; i <= number; i++)
                    result += i;
                    // System.Console.WriteLine(result);
                return result;
            };
            return del;
        }

        static void Main()
        {
        //     // if(args [0] != null){
        //     //     if (args [0] == "hello")
        //     //         System.Console.WriteLine("Your argument hello");
        //     // }
        //     // else{
        //     //     System.Console.WriteLine("njj");
        //     // }
        //     Sum del1 = SomeVar();

        //     for (int i = 1; i <= 5; i++)
        //     {
        //         Console.WriteLine("Cумма {0} равна: {1}",i,del1(i));
        //     }
        //     System.Console.WriteLine(del1(2));

        //     SetLogin();

        //     Console.Write("Введите пароль: ");
        //     string password1 = Console.ReadLine();
        //     Console.Write("Повторите пароль: ");
        //     string password2 = Console.ReadLine();

        //     // Используем лямбда выражение
        //     BoolPassword bp = (s1, s2) =>s1 == s2;

        //     if (bp(password1, password2))
        //         Console.WriteLine("Регистрация удалась!");
        //     else
        //         Console.WriteLine("Регистрация провалилась. Пароли не совпадают");

        //     // Console.ReadLine();
        //                 // SetLogin();

        //     // Console.Write("Введите пароль: ");
        //     // string password1 = Console.ReadLine();
        //     // Console.Write("Повторите пароль: ");
        //     // string password2 = Console.ReadLine();

        //     // Используем лямбда выражение
        // //     BoolPassword bp = (s1, s2) => s1 == s2;

        //     if (bp(password1, password2))
        //     {
        //         Random ran = new Random();
        //         string resCaptha = "";
        //         for (int i = 0; i < 10; i++)
        //             // resCaptha += i;
        //             resCaptha += (char)ran.Next(0, 100);
        //         Console.WriteLine("Введите код xD: " + resCaptha);
        //         string resCode = Console.ReadLine();

        //         // Реализуем блочное лямбда-выражение
        //         Captha cp = (s1, s2) =>
        //         {
        //             if (s1 == s2)
        //                 Console.WriteLine("Регистрация удалась!");
        //             else
        //                 Console.WriteLine("Не переживай, в следующий раз получится :)");
        //             // return;
        //         };
        //         cp(resCaptha, resCode);
        //     }
        //     else
        //         Console.WriteLine("Регистрация провалилась. Пароли не совпадают");
        // }
        // private static void SetLogin()
        // {
        //     Console.Write("Введите логин: ");
        //     string login = Console.ReadLine();

        //     // Используем лямбда-выражение
        //     LengthLogin lengthLoginDelegate = s => s.Length;

        //     int lengthLogin = lengthLoginDelegate(login);
        //     if (lengthLogin > 25)
        //     {
        //         Console.WriteLine("Слишком длинное имя\n");

        //         // Рекурсия на этот же метод, чтобы ввести заново логин
        //         SetLogin();



        //     }
        //     else{
        //         System.Console.WriteLine("Все хорошо");
        //     }
            UserInfo userInfo = new UserInfo("Dima","Li",26);
            // userInfo.UserInfoHandler();
            // MyEvent myEvent = new MyEvent();
            PrintHelper print = new PrintHelper();
            // print.beforePrintEvent+=
        //subscribe to beforePrintEvent event
        
            print.PrintMoney(100);
        }
    }
    public class PrintHelper
{
    // declare delegate 
    public delegate void BeforePrint();
    
    //declare event of type delegate
    public event BeforePrint beforePrintEvent;
      
    void printHelper_beforePrintEvent()
    {
        Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
    }


    public PrintHelper()
    {
        beforePrintEvent += printHelper_beforePrintEvent;
        

    }

    public void PrintNumber(int num)
    {
    //call delegate method before going to print
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Number: {0,-12:N0}", num);
    }

    public void PrintDecimal(int dec)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
    
        Console.WriteLine("Decimal: {0:G}", dec);
    }

    public void PrintMoney(int money)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Money: {0:C}", money);
    }

    public void PrintTemperature(int num)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Temperature: {0,4:N1} F", num);
    }
    public void PrintHexadecimal(int dec)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Hexadecimal: {0:X}", dec);
    }
}
        class MyEvent
        {
        // Объявляем событие
            public event UI UserEvent;

        // Используем метод для запуска события
            public void OnUserEvent()
            {
                UserEvent();
            }
    }

    class UserInfo
    {
        string uiName, uiFamily;
        int uiAge;

        public UserInfo(string Name, string Family, int Age)
        {
            MyEvent myEvent = new MyEvent();
            myEvent.UserEvent+= UserInfoHandler;
            this.Name = Name;
            this.Family = Family;
            this.Age = Age;
            myEvent.OnUserEvent();
            
            
        }
        

        public string Name { set { uiName = value; } get { return uiName; } }
        public string Family { set { uiFamily = value; } get { return uiFamily; } }
        public int Age { set { uiAge = value; } get { return uiAge; } }

        // Обработчик события
        public void UserInfoHandler()
        {
            Console.WriteLine("Событие вызвано!\n");
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}",Name,Family,Age);
        }
    }

}
// Одиночные лямбда-выражения
// Блочные лямбда-выражения
// события


