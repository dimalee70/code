using System;
using abstracts.models;
namespace abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee [] arr = new Employee[]
            {
                new Employee("Dima", 22),
                new Employee("Islam", 18)
            };

            AbsAction abs = new ActionRepo(arr);
            
            ActionRepo action = new ActionRepo(arr);

            abs = action;

            action.Add(new Employee("Test", 18));

            action.Hello();

            // action.Delete(2);

            // action.Hello();

            
        }
    }
}
