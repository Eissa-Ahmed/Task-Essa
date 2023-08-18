using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal interface PersonAll
    {
        int id { get; set; }
        string name { get; set; }
        string address { get; set; }
    }
    internal interface PersonM_E
    {
        decimal salary { get; set; }

        public decimal getSalary(double baseSalary, double deduction, double bouns);


        public void absense();
        public void display();
        public void attendance(string name);
    }
}
