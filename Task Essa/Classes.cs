using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Employee : PersonAll, PersonM_E
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public decimal salary { get; set; }

        public void absense()
        {
            throw new NotImplementedException();
        }

        public void attendance(string name)
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            throw new NotImplementedException();
        }

        public decimal getSalary(double baseSalary, double deduction, double bouns)
        {
            throw new NotImplementedException();
        }
    }


    internal class NotEmployee : PersonAll
    {
        public int id { get ; set ; }
        public string name { get; set; }
        public string address { get; set; }

        public void eat() { }
        public void drink() { }
    }

    internal class Manager : PersonAll, PersonM_E
    {

        decimal bouns { get; set; }
        public decimal salary { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public void hire() { }
        public void fire() { }

        public decimal getSalary(double baseSalary, double deduction, double bouns)
        {
            throw new NotImplementedException();
        }

        public void absense()
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            throw new NotImplementedException();
        }

        public void attendance(string name)
        {
            throw new NotImplementedException();
        }
    }
}
