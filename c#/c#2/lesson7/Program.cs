using System.Linq;
using System.Collections.Generic;
namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Teacher> myListT =new  List<Teacher>{
                new Teacher("DimaT","Almaty"),
                new Teacher ("NurtilekT","Chimkent"),
                new Teacher ("AruzhanT","Almaty")
                // new Student("Dima2","Almaty")
            };
            List <Student> myList =new  List<Student>{
                new Student("Dima","Almaty",20),
                new Student ("Nurtilek","Chimkent",20),
                new Student ("Aruzhan","Almaty",19),
                new Student("Dima2","Almaty",15),
                new Student ("Nurtilek2","Chimkent",16),
                new Student ("Aruzhan2","Almaty",17),
                new Student("Dima3","Almaty",43),
                new Student ("Nurtilek3","Chimkent",30),
                new Student ("Aruzhan3","Almaty",19),
                new Student("Dima4","Almaty",27),
                new Student ("Nurtilek4","Chimkent",50),
                new Student ("Aruzhan4","Almaty",17)
            };
            int [] numbers = {1,2,3,4,5,6,7,8,9};
            int [] numbers2 = {2,3,4,5,100};



            var stAndT = 
                from st in myList
                join  t in myListT on st.cityOfSt equals t.cityOfT
                where st.cityOfSt == t.cityOfT 
                // group st , t by st.cityOfSt, t. into st
                select new {Student = st, Teacher =  t};
            foreach(var n in stAndT)
            {
                System.Console.WriteLine(n.Student.cityOfSt + " " + n.Student.nameOfSt);
                System.Console.WriteLine(n.Teacher.cityOfT + " " + n.Teacher.nameOfT);
                // foreach(var t in n)
                // {
                //     System.Console.WriteLine("    "+t.nameOfSt);
                // }
            }

            

            // var stQuery = 
            //     from st in myList
            //     where //st.cityOfSt == "Almaty" 
            //     // &&
            //     st.ageOfSt >=18 
            //     &&
            //     st.ageOfSt < 28
            //     group st by st.cityOfSt into st
            //     select st;
            // System.Console.WriteLine(stQuery.GetType());
            // foreach(var s in stQuery)
            // {
            //     System.Console.WriteLine(s);

            //     System.Console.WriteLine(s.Key);
                
            //     foreach(Student st in s)
            //     {
            //         System.Console.WriteLine("   " +st.nameOfSt + " " + st.ageOfSt);
            //     }
            // }
            var myQuery = 
                from num in numbers
                group num by num into num
                select num;

            // foreach(var n in myQuery)
            // {
            //     System.Console.WriteLine($"frfr{n.Key}");
            // }



            foreach(int n in numbers.Except(numbers2))
            {
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine(numbers.Except(numbers2));
            var numQuery = 
                from num in numbers
                where (num%2) == 0
                orderby num 
                select num ;
            
            System.Console.WriteLine(numQuery.ToArray().GetType());
            foreach(int n in numQuery.ToArray())
            {
                System.Console.Write(n + " ");
            }
            System.Console.WriteLine();
            foreach(int n in numbers.Except(numQuery))
            {
                System.Console.Write(n + " ");
            }
            System.Console.WriteLine();
            foreach(int n in numQuery.Intersect(numbers))
            {
                System.Console.Write(n +" ");
            }
            System.Console.WriteLine();




            // System.Console.WriteLine(numQuery.Count());
            // System.Console.WriteLine(numQuery.Max());
            // System.Console.WriteLine(numQuery.First());
            // System.Console.WriteLine(numQuery.Average());
            // System.Console.WriteLine(numQuery.GetType());

        }
    }
}
// LINQ
// получение источника данных;
// создание запроса;
// выполнение запроса.

// Count, Max, Average и First

//  ToList или ToArray.

// Сортировка данных
// orderby ascending/descending

// Disting 

// Except

// Intersect

// group
