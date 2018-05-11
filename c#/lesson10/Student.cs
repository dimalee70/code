using System;
namespace lesson10{
    public class Student : Human{
        private int studentId;
        public int StudentID{
            get{return studentId;}
            set{studentId = value;}
        }
        public override void sayHello(){
            System.Console.WriteLine("Good By");
        }
        public sealed override int Age(int n){
            System.Console.WriteLine($"{n} tgrtgrtgtr");
            return n;
        }
    }
}