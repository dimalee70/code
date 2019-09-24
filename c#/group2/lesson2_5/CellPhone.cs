using System;
namespace lesson2_5
{
    public class CellPhone
    {

        public CellPhone()
        {
        }
        public string model{get;set;}

        public CellPhone(string model)
        {
            this.model = model;
            
        }

        public override string ToString()
        {
            return model;
        }

        public void addString(string name)
        {
            model += name;
        }
    }
}
