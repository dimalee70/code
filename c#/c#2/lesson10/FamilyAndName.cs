using System;
namespace lesson10
{
    public class FamilyAndName : Name
    {
        public string myFamily;
        public FamilyAndName(string myFamily,string Name)
        {
            this.myFamily = myFamily;
            this.myName = Name;
        }
        
    }
}