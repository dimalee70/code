namespace HomeWork3
{
    public class Programmer: Employee
    {

        public Programmer(){}//пустой конструктор

        public Programmer(string programmingLanguage)//конструтокр который присваивает переменную класса
        {
            this.programmingLanguage = programmingLanguage;
        }

        //конструктор который наследует родительский конструктор
        public Programmer(string name,string surname, Gender gender, int salary, string position, int skill, int money, string programmingLanguage):base(name,surname,gender,salary,
        position,skill,money)
        {
            this.programmingLanguage = programmingLanguage;
        }
        private string programmingLanguage;//переменная класса

        public string getProgrammingLanguage()//метод который получает перменную класса
        {
            return programmingLanguage;
        }
        public void setProgrammingLanguage(string programmingLanguage)//метод который присваивает переменную класса
        {
            this.programmingLanguage = programmingLanguage;
        }
    }
}