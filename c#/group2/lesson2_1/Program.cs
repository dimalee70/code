using System;

namespace lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Person[]persons = new
                Person[]
                {new Person("Dima", "12344"),
                new Person("Islam", "343554"),
                new Person("Mish", "12344")};

            PersonRepository personRepository =
            new PersonRepository(persons);

            personRepository.PrinPersons();
            System.Console.WriteLine();

            personRepository.add(new Person("Stas", "989787"));

            personRepository.PrinPersons();
            System.Console.WriteLine();

            personRepository.delete(0);
            personRepository.PrinPersons();
            // System.Console.WriteLine();
            // personRepository.TestAdd()

            int n = 15;
            int m = 19;
            sum(n,m);




        }

        static int sum(int a, int b)
        {
            return a+b;
        }
    }
}
