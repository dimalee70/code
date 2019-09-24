using System;
namespace lesson9
{
    public class Student
    {
        public Student(string name, int course)
        {
            this.name = name;
            this.course = course;
        }
        public string name;
        public int course;

        public string getName()
        {
            return name;
        }

        public int getCourse()
        {
            return course;
        }

        public void printStudent(Student [] student, int course)
        {
            foreach (Student s in student)
            {
                if(s.course == course)
                    System.Console.WriteLine(s.name);
            }
        }
    }
}