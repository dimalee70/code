using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.Основные операторы
            
            //Доступ к членам
            
            // string name = "Dmitriy";
            // int length = name.Length;
            
            // Console.WriteLine(length);
            
            //Условный доступ к членам
            // string s = null;
            // // int? t = null;//Nullable
            // //s?.Length;
            // int? length = s?.Length; // если длины строки будет null, то length = null;
            // Console.WriteLine(length);

            // //Вызов метода и делегата
            // Console.WriteLine("Di");
            // Console.WriteLine("ma");
            // string s = "egeg";
            // s.Clone();

            //Доступ к массиву и индексатору
            // string name = "Steve Jobs";
            // Console.WriteLine(name[0]);

            //Условный доступ к массиву и индексатору
            // string name = null;
            // Console.WriteLine(name?[3]);

            //Постфиксный инкремент
            // int x = 5;
            // Console.WriteLine(x++);
            // System.Console.WriteLine(x);

            // //Постфиксный декремент
            // int y = 5;
            // Console.WriteLine(--y);
            // Console.WriteLine(y);

            //Создание объекта и делегата
            // int t = new int();
            // t = 10;
            // Console.WriteLine(t);

            //Получение объекта System.Type
            // double z =0;
            // Type type= typeof(int);
            // Console.WriteLine(type);
            // if (z.GetType() == typeof(char)){
            //    Console.WriteLine("Int");     
            // }
            // else if (z.GetType() == typeof(double)){
            //     Console.WriteLine(typeof(double));
            // }
           
            

            // // //Вычисление выражения в проверенном контексте
            // Console.WriteLine(" ");
            // checked{
                // unchecked{}
            //     int ten = 10;
            //     int i2 = 2147483647 + ten;
            //     Console.WriteLine(i2);
            // }

            //Вычисление выражения в непроверенном контексте
            // const int int1 = 2000000 + 10;
            // unchecked
            // {
            //     Console.WriteLine(int1);
            // }
            // Console.WriteLine(checked (int1));

            // //Получение значения по умолчанию для типа 
            // var v = default(int);
            // Console.WriteLine(v.GetType());

            // //Анонимная функция (анонимный метод)

            // 2.Унарные операторы
            
            // int r = -5;
            // Console.WriteLine(+r);  
            // Console.WriteLine(-r);

            //Поразрядное отрицание
            // ushort q = 0x0000FFFF;
            //              //ffff0000
            //             //  ~
            // Console.WriteLine($"{~q:x8}");
            
            //Явное преобразование x в тип T
           // char c = 'A';
            // int   k = (int)c;
            // Console.WriteLine((char)k);

            // 3.Мультипликативные операторы
            // *	Умножение
            // /	Деление
            // %	Остаток
            // System.Console.WriteLine(3%5);


            // // 4. Аддитивные операторы
            //x + y	Сложение, объединение строк, объединение делегатов
            //x - y	Вычитание, удаление делегатов
            // int t = 5;
            // int t2 = 6;
            // System.Console.WriteLine(t+t2);

            // System.Console.WriteLine();
            // string x = "6";
            // string y = "10";
            // Console.WriteLine((t2+t) + x);
             
            // // // 5.Операторы сдвига
            // int x2 = 0x00AA;  //0000 0000 1010 1010
            //                   //0000 0000 0010 1010  - сдвиг вправо на 2
            //                   //01010 1010 0000 0000 - сдвиг влево на 7 елементов
            // System.Console.WriteLine($"{x2:x8}");
            // int y2 = 0x5500;  

  
            // int z2 = ( x2 << 7 ); 
            // Console.WriteLine(Convert.ToString(z2,2)); 

            // 6.Относительные операторы и операторы типов
            // x < y	Меньше
            // x > y	Больше
            // x <= y	Меньше или равно
            // x >= y	Больше или равно

            // bool isBigger = 10>20;//Если 10 больше 20 = True, Если не больше = False
            // System.Console.WriteLine(isBigger);

            // 7.Операторы равенства
            // x == y	Равно
            // x != y	Не равно
            // bool isEqual = (10 == 10);
            // bool notEqual = (10 != 10);
            // System.Console.WriteLine(isEqual);
            // System.Console.WriteLine(notEqual);

            // //8.Логические, условные операторы и NULL-операторы
                // Console.WriteLine(true & false); //false
                // Console.WriteLine(true & true); //true
                
                // Console.WriteLine(true ^ false); //true
                // Console.WriteLine(true ^ true); //false

                // Console.WriteLine(true | false); //true
                // Console.WriteLine(true | true); //true

                // // // 	x && y	
                // // // x || y
                // bool isEqual = (10 >= 10) &&(20 >30);//false
                // bool notEqual = (25 == 20) || (12 != 20);//true
                // bool orAndEqual = ((25 >= 12) || (24 == 24)) && (5 == 5);//true
                // System.Console.WriteLine(isEqual);
                // System.Console.WriteLine(notEqual);
                // System.Console.WriteLine(orAndEqual);
                
                // int? o = null;
                // int? p = 16;
                // int? a = o??p;// если о будет нулл то а = р. А если о не нулл, то а = о
                // Console.WriteLine(a);


            //  x ? y : z	Равно y, если x имеет значение true, и z, если x имеет значение false
            // int x = (10 < 15)?5 : 10;
            // Console.WriteLine(x);
                //9.Операторы присваивания и анонимные операторы
                // =	Назначение
                // +=, -=, *=, /=, %=, &=, |=, !=, <<=, >>= Составное присваивание. Поддерживает следующие операторы: 
            int p = 31; // p = 00011111


            p += 10; // p = 00101001
                        //  00001001
                        //  00001001

            // System.Console.WriteLine(p);
            // p = p + 10;
            p &= 9;// 00001001
            //        00000110
                //    00001111
            Console.WriteLine(p);
            p |= 6; //00001111
            // bool t = p!=5;
            Console.WriteLine(p);
            p *= 7; // 105
                    // 0000 0000 0110 1001
                    // 0110 1001 0000 0000
            p <<= 8;//26880
            System.Console.WriteLine(p);

            //$ - это формат для строки где через {} мы пробрасываем 
            // пременую и мы получаем значение переменной в строку

            // логический OR - | (+)
            // логический AND - & (*)
            // логический XOR - ^
            // условный AND - &&
            // условный OR - ||  
        

         
        }
    }
}
