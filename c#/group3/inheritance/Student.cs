using System;
namespace inheritance
{
    class Student
    {
        public string name{get;set;}
        public int course{get;set;}

        public Student(string name, int course)
        {
            this.name =name;
            this.course = course;
        }

        // int [] t = {1,2,3,4}
        // foreach(int i in t )
        // {
        //     if(i == 2)

        // }


        public void printStudents(Student [] students, int course)
        {
            foreach(Student s in students)
            {
                if(s.course == course)
                {
                    System.Console.WriteLine(s.name);
                }
            }
        }
    }
}