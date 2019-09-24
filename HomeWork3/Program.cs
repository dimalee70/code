using System;
using HomeWork3;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.setName("Bill");
            person.setSurName ("Gates");
            person.PrintSurname();
            string returnSurname = person.getSurname();
            person.gender = Gender.Male;
            person.SayHI();


            
            Employee employee = new Employee(person.getName(),person.getSurname(), person.gender,50000,"IT Developer",2,10000);
            Employee [] employees = {employee, new Employee("John","Vashington",Gender.Male)};
            Boss boss = new Boss(employee.getName(),employee.getSurname(),employee.gender,employee.getSalary(),
            employee.getPosition(),employee.getSkill(),employee.getMoney(),150,employees);

            employee.PrintSurname();

            boss.PrintSurname();
            boss.SayHI();

        }
    }
}
