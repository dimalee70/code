namespace HomeWork3
{
    public class Boss: Employee
    {

        public Boss(){}//пустой конструктор
        public Boss(int weight, Employee[]employees)//конструктор который присваивает личные переменный классу
        {
            this.employees = employees;
            this.weight = weight;
        }

        //конструктор которые наследует конструктор из класса Employee и присваивает личные пременные 
        public Boss(string name,string surname, Gender gender, int salary, string position, int skill, int money, int weight, Employee[] employees)
        :base(name,surname,gender,salary,position,skill,money)
        {
            this.weight = weight;
            this.employees = employees;
        }
        protected int weight; // переменная веса
        
        private Employee[] employees;//масссив из сотрудников

        public void setEmployees(Employee [] employees)//присвает массив из сотрудников
        {
            this.employees = employees;
        }
        public Employee[] getEmployees()//получает массив из сотрудников
        {
            return employees;
        }
        public int  getWeight()//получает вес
        {
            return weight;
        }
        public void setWeight(int weight)//присваивает вес
        {
            this.weight = weight;
        }

        public void Dismissal(int index)//удааляет сотрудника по индексу  с массива
        {
            Employee [] e = new Employee[employees.Length-1];
            int idx = 0;
            for(int i = 0; i < employees.Length; i++)
            {
                if(i != index){
                    e[idx] = employees[i];
                    idx++;
                }
            }
            this.employees = e;
        }
        public void Accept(Employee employee)//метода который добавляет сотрудника
        {
            Employee [] e = new Employee[employees.Length + 1];
            for(int i =0; i < employees.Length; i ++)
            {
                e[i] = employees[i];
            }
            e[e.Length-1] = employee;
            employees = e;
        }
        
        public void printEmployees()//метод который печатает сотрудников
        {
            foreach(Employee e in employees)
            {
                System.Console.WriteLine(e.getName()+ " " + e.getSurname());
            }

        }
        public void helloFromEmployees()// метода которые пишет приветствие ото всех сотрудников
        {
            foreach(Employee e in employees)
            {
                System.Console.WriteLine($"Hello from {e.getName()} {e.getSurname()}");
            }
        }

    }
}