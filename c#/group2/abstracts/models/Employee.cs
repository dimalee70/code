namespace abstracts.models
{
    public class Employee
    {
        public string name{get;set;}
        public int age{get;set;}

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return "Name " + name + "\tage " + age; 
        }
    }
}