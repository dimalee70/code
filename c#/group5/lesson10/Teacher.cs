using System;

namespace lesson10
{
    public class Teacher : Human
    {
        public int Skill{get; set;}

        public Teacher(int Skill)
        {
            this.Skill = Skill;
        }

        public Teacher(string Name, int Age, int Skill) : base(Name, Age)
        {
            this.Skill = Skill;
        }

        public void printInfo()
        {
            System.Console.WriteLine("Name " + Name +"\tAge " + Age + "\tSkill "  +Skill);
        }

        public void printInfoFromParent()
        {
            base.printInfo();
        }

        // public Teacher(string Name, int Age, int Skill)
        // {
        //     this.Name = Name;
        //     this.Age = Age;
        //     this.Skill = Skill;
        // }
    }
}