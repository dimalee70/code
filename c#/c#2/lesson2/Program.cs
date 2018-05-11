using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            DateTime yearOfBirth;

            System.Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            System.Console.WriteLine("Enter you data of birth");
            yearOfBirth = DateTime.Parse(Console.ReadLine());
            User us = new User(name,yearOfBirth);
            System.Console.WriteLine(us);
            // Console.WriteLine("Hello World!");
            // MyClass mc = new MyClass(3);
            // Random r = new Random();
            // for (int i = 0; i < mc.Length; i++)
            // {
            //     mc[i] = r.Next(1,100);
            //     Console.Write("{0}\t", mc[i]);
            // }



            // IndexClass ic = new IndexClass(3);
            // IndexClass ic2 = new IndexClass(2);


            // IndexClass [] arrIc = new IndexClass[2];
            // arrIc[0] = ic;
            // arrIc [1] = ic2;

            // string name = "Hands";
            // int size = name.Length;
            // ic [0] = "Hello";
            // ic [1] = "My";
            // ic [2] = "Name";
            // for (int i = 0; i < ic.length;i++){
            //     System.Console.WriteLine(ic[i]);
            // }
            // System.Console.WriteLine(ic["My"]);
            // System.Console.WriteLine(ic[0]);


            // User us = new User(3);
            // us[0] = "Music";
            // us[1] = "Drawing";
            // us[2] = "Dancing";
            // User us2 = new User(2);
            // us2[0] = "Alcogol";
            // us2[1] = "Smoking";
            // User [] arrUser = new User[2];
            // arrUser[0] = us;
            // arrUser[1] = us2;
            // int number = 1;
            // foreach (User u in arrUser){
            //     System.Console.WriteLine($"Hobbies {number} User");
            //     for(int i = 0; i < u.length;i++)
            //     {
            //         System.Console.Write(u[i]+ " ");
            //     }
            //     System.Console.WriteLine();
            //     number++;
            // }
        }
    }
}
// Одномерные индексаторы
// тип_элемента this[int индекс] {
// // Аксессор для получения данных,
// get {
// // Возврат значения, которое определяет индекс.
// }
// // Аксессор для установки данных,
// set {
// // Установка значения, которое определяет индекс.
// }}
//  нельзя передовать ref или out
// Перегрузка индексаторов
// свойство