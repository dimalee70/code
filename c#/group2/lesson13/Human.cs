using System;

namespace lesson13
{
    class Human
    {

        public Human(){}
        public Human(string sex, string race)
        {
            this.race = race;
            this.sex = sex;
        }
        public string sex{set; get;}
        public string race {get; set;}

        public void print()
        {
            System.Console.WriteLine(race);
            System.Console.WriteLine(sex);
        }

    }
}
