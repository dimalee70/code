using System;
using lesson2_1.interfaces;
namespace lesson2_1
{
    public  class PersonRepository:BasePerson, Test
    {
        private Person[] persons;

        public PersonRepository(Person[] persons)
        {
            this.persons = persons;
        }
        public void PrinPersons()
        {
            foreach(Person p in persons)
            {
                System.Console.WriteLine(p);
            }
        }
        public void add(Person person)
        {
            Person [] p = new Person[persons.Length + 1]; 
            Array.Copy(persons, p, persons.Length);
            p[p.Length - 1] = person;
            TestAdd(persons,p);
            persons = p;
        }
        public void TestAdd(Person [] oldPersons, Person[] newPersons)
         {
    
            if (oldPersons.Length < newPersons.Length)
                System.Console.WriteLine("Ok");
            else System.Console.WriteLine("error");
         }
        public void delete(int idx)
        {
            Person [] p = new Person[persons.Length - 1];
            for(int i = 0, j = 0 ; i < persons.Length; i++)
            {
                if(i == idx)
                    continue;
                p[j]  = persons[i]; 
                j++;
            }
            persons = p;
        }
        public void TestDelite()
        {

        }

        // Person edit (int i);
        public void SayHello()
        {
            System.Console.WriteLine("Hello");
        }
    }
}