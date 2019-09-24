using System;
using abstracts.models;

namespace abstracts
{
    class ActionRepo: AbsAction
    {

        public void Hello()
        {
            foreach(Employee e in employess)
            {
                System.Console.WriteLine(e);
            }
        }

        public  void Add(Employee e)
        {
            System.Console.WriteLine("My Metod");
        }
        public ActionRepo(Employee [] employees): base (employees){}

        // public override string ToString()
        // {
        //     for
        // } 

        
        public override void Delete(int index)
        {
            Employee [] e = new Employee[employess.Length - 1];
            for(int i = 0, j = 0; i < employess.Length; i++)
            {
                if(i != index)
                {
                    e[j++] = employess[i];
                }

            }

            employess = e;
            // Array.Copy(employess, e )
        }
    }
}