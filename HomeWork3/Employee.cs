namespace HomeWork3
{
    public class Employee:Person
    {

        public Employee(){}//пустой конструктор

//конструктор который реализует конструктор с класса Person
        public Employee(string name, string surname, Gender gender):base(name,surname,gender)
        {
        }

        //конструктор который реализует конструктор с класса person и добавляет личные переменные
        public Employee(string name,string surname, Gender gender, int salary, string position, int skill, int money):base(name,surname,gender)
        {
            this.salary = salary;
            this.position = position;
            this.skill = skill;
            this.money = money;
        }
        private int salary;// переменная зарплаты
        private string position;//ппеременная должности
        protected int skill;//переменна опыта
        private int money;//перменная денег

        public int getSalary()//метода который возращает зарплату
        {
            return salary;
        }
        public void setSalary(int salary)//метода который присваивает зарплату
        {
            this.salary = salary;
        }
        public string getPosition()//метода который возвращает позицию
        {
            return position;
        }
        public void setSkill(string position)//метод который присваивает позицию
        {
            this.position = position;
        }

        public int getSkill()// метода который получает опыт
        {
            return skill;
        }
        public void setSkill(int skill)//метода который присваивает опыт
        {
            this.skill = skill;
        }

        public int getMoney()//метода который получает деньги
        {
            return money;
        }
        public void setMoney(int money)//метоа который присваивает деньги
        {
            this.money = money;
        }

        public int SpendMoney(int money)//метод который онимает сумму от общей суммы денег
        {
            this.money-=money;
            return this.money;
        }
        public void CurrentMoney()//метода который выводит сумму денег
        {
            System.Console.WriteLine($"You have {getMoney()}$ in your account");
        }
        public double SaveMoney(int saveMoney, int moneyInMonth)//метод который расчитывает сколько времни нужно чтобы скопить сумму
        {
            return (double)saveMoney/moneyInMonth;
        }
        
    }
}