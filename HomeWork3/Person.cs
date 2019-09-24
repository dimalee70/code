namespace HomeWork3
{
    public enum Gender { Male, Female};//енум для пола
    public class Person
    {

        public Person(string name,string surName)//конструктор который присвает переменные класса
        {
            this.name = name;
            this.surName = surName;
        }
        public Person(string name, string surName, Gender gender)//конструктор который присваивает переменные класса
        {
            this.name = name;
            this.surName = surName;
            this.gender = gender;
        }
        public Person ()//пустой конструктор
        {
        }
       
        protected string name;//перменная класса
        private string surName;//переменная классса

        public void setName(string name)//метод который присваивает имя
        {
            this.name = name;
        }
        public string getName()//метод который получает имя
        {
            return name;
        }
        public void setSurName(string surname)//метод который присваивает фамилию
        {
            this.surName = surname;
        }

        public Gender gender;//перменная класса

        public void PrintSurname()//метод который печатает фамилию
        {
            System.Console.WriteLine(getSurname());
        }
        public string getSurname()//меод который возвращает фамилию
        {
            return surName;
        }
        public void SayHI()//метода который выводит приветсвие
        {
            System.Console.WriteLine($"Здравствуйте, меня зовут {getName()} {getSurname()}");
        }
        public int YearOfWork(int age)//метод который возвращает сколько лет оставлось до пенсии
        {
            if (gender == Gender.Male)
            {
                return 58 - age;
            }
            return 63 - age;
        }
    }   
}
