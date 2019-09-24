using System;
namespace classes
{
    class Human
    {   
        public string name{get; set;}

        // public Human()
        // {
        //     this.name = "NoName";
        // }
        public Human(string name)
        {
            this.name = name;
        }

        public void hello()
        {
            System.Console.WriteLine("Hello " + name);
        }
        public virtual void prinInfo()
        {
            System.Console.WriteLine(name);
        }

    }
    

}