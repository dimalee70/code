using System;
namespace lesson10Class
{
    public class GroupA : User
    {
        public double GPA{get;set;}
        public GroupA(string Name, int Age, int schoolClass,
         double GPA): 
            base(Name, Age, schoolClass)
        {
            this.GPA = GPA;
        }

        public override int addToClassSchool()
        {
            return --schoolClass;
        }

        public override string ToString()
        {
              return "name " + Name + "\tAge "
               + Age + "\tGPA " + GPA;
        }
    }
}