using System;
namespace classes2
{
    public class Test : Student
    {
        public string title{get;set;}

        public Test(){}
        public Test(string name, int age, string id, string title)
        : base(name, age, id)
        {
            this.title = title;
        }


        public String printStudent()
        {
           return "Hello";
        }

        public String printStudent2()
        {
            printStudent();
            return base.printStudent();
        }
    } 
}