using System;
using System.Collections.Generic;
namespace lesson12_2
{
    // Создадим обобщенный класс имеющий параметр типа T
    class MyObj<T>
    {
        T obj;
        // List

        // Dictionary
        public MyObj(T obj)
        {
            this.obj = obj;
        }

        public void objectType()
        {
            Console.WriteLine("Тип объекта: " + typeof(T));
        }
    }

    // Обобщенный класс с несколькими параметрами
    class MyObjects<T, V, E>
    {
        T obj1;
        V obj2;
        E obj3;

        public MyObjects(T obj1, V obj2, E obj3)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
            this.obj3 = obj3;
        }

        public void objectsType()
        {
            Console.WriteLine("\nТип объекта 1: " + typeof(T)+
                "\nТип объекта 2: " + typeof(V) +
                "\nТип объекта 3: " + typeof(E));
        }
    }

    class Program
    {
        static void Main()
        {
            // Создадим экземпляр обобщенного класса типа int
            MyObj<int> obj1 = new MyObj<int>(25);
            obj1.objectType();

            MyObjects<string, byte, decimal> obj2 = new MyObjects<string, byte, decimal>("Alex",26,12.333m);
            obj2.objectsType();
            Library library = new Library("Tolstoy",1298);
            Library library2 = new Library("Tolstoy2",1298);
            Library library3 = new Library("Tolstoy3",1298);
            Library library4 = new Library("Tolstoy4",1298);
            MyLibrary<Library> myLibrary = new MyLibrary<Library>();
            myLibrary.myAdd(library);
            myLibrary.myAdd(library2);
            myLibrary.myAdd(library3);
            myLibrary.myAdd(library4);

            System.Console.WriteLine(myLibrary);
            // Console.ReadLine();


            MyLibrary<Int32?> myLibrary2 = new MyLibrary<Int32?>();
            Int32 num1 = 1;
            Int32 num2 = 2;
            Int32 num3 = 3;
            Int32 num4 = 4;
            System.Console.WriteLine(num1.ToString());
            myLibrary2.myAdd(num1);
            myLibrary2.myAdd(num2);
            myLibrary2.myAdd(num3);
            myLibrary2.myAdd(num4);

            System.Console.WriteLine(myLibrary2);

        }
    }
}