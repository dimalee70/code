using System;
namespace lesson2_4
{
    public class ClassDays
    {
        public Days day{get;set;}
        public ClassDays(Days day)
        {
            this.day = day;
        }

        public void printDay()
        {
            try
            {
                System.Console.WriteLine($"Day {day} index = {(int) day} ");
            }
            catch(Exception e){}
            
        }

        public void checkDay()
        {
            if(day == Days.Sunday || day == Days.Satuday)
                System.Console.WriteLine("Holiday");
            else
                System.Console.WriteLine("WorkDay");
        }
    }
}