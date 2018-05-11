using System;
namespace lesson10{
    public class Human{
        private string name;
        public string NameOfHuman{
            get{return name;}
            set{name = value;}
        }
        public virtual void sayHello(){
            System.Console.WriteLine("Hello");
        }
        public virtual int Age(int n){
            System.Console.WriteLine(n);
            return n;
        }
    }
}