using System;
namespace classes
{
    class Human
    {
        public int age;
        public string name;

        public Human()
        {
            age = 10;
        }

        public Human(int age, string name)
        {
            this.age = age;
            this.name = name; 
        }


        public void printHuman()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(age);
        }

        public void printHumanByAge(Human [] human, int age)
        {
            for(int i = 0; i < human.Length; i++)
            {
                if(human[i].age == age)
                {
                    System.Console.WriteLine(human[i].name);
                }
            }
        }


    }
}
