using System;
namespace lesson10
{
    public class Student : Human
    {
        public string StudentId{get;set;}
        public Student(string name, int age, string studentId):base(name, age)
        {
            this.StudentId = studentId;
        }
    }
}