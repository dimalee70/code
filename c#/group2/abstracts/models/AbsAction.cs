using System;
using abstracts.interfaces;
using abstracts.models;
namespace abstracts
{
    abstract class AbsAction : Actions
    {
        public Employee[] employess{get;set;}

        public AbsAction ()
                {
                    this.employess = null;
                }
        public AbsAction (Employee [] employees)
        {
            this.employess = employees;
        }
        public void Add(Employee employee)
        {
            Employee [] e = new Employee[employess.Length + 1];
            Array.Copy(employess, e, employess.Length);
            e[e.Length - 1] = employee;
            employess = e;
        }

        public int getLength()
        {
            return employess.Length;
        }

        public abstract void Delete(int index);
    }
}