using System;
namespace classes2 
{
    public class Student : Human
    {

        public Student(){}

        public int t {get; set;}

        public int pluss(Student st)
        {
            return this.t + st.t;
        }
        public string ID{get; set;}

        public Student(string name, int age, string ID): base(name, age)
        {
            this.ID = ID;
        }
        public Student(string id) : base("Hello", 21)
        {
            ID = id;
            // System.Console.WriteLine(printStudent());
        }

        public String printStudent()
        {
            return Name + "  " + getAge() + " " +ID;
        }

    
    }
}