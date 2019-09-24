namespace HomeWork3
{
    public class Accountant:Employee
    {
        public Accountant(){}//пустой конструктор
        public Accountant(string name, string surname, Gender gender):base(name,surname,gender){}//конструктор который наследует родительский конструктор


        //конструктор который наследует конструктор и добавляет личные переменный
        public Accountant(string name,string surname, Gender gender, int salary, string position, int skill, int money):base(name,surname,gender){}

        public void sentSalaryToEmployee(int salary, Employee employee)// метод который отправляет зарплату сотруднику
        {
            employee.setMoney(employee.getMoney()+salary);
        }
        public void sentSalaryToEmployees(int salary, Employee[]employees)// метод который отправляет зарплату всем сотрудникам
        {
            foreach(Employee e in employees)
            {
                e.setMoney(e.getMoney() + salary);
            }
        }
        
    }
}