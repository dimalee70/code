using System;
namespace lesson12
{
   public abstract class MyAbstarctClass
   {
       protected string Tag{get;set;}
       public MyAbstarctClass(String Tag)
       {
           this.Tag = Tag;
       }
        public void printHello()
        {
            System.Console.WriteLine("Hello");
        }  

        public abstract String getInfo(); 
   }
}