using System;

namespace lesson9Class
{
    public class Student : Human
    {
        public string StudentId{get;set;}
        
        public Student():base(){} 

        public Student(string Name, int Age): base(Name, Age){}

        public Student(string Name, int Age, string StudentId)
        :base(Name, Age)
        {
            this.StudentId = StudentId;
        }

        public void showStudent()
        {
            printInfo();
            System.Console.WriteLine("StudentId " +  StudentId);
        }


    }
}