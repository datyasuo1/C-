using System;
using System.Collections.Generic;
using System.Text;

namespace task8.ex4
{
    class BusinessEmployee:Employee
    {
        public BusinessEmployee(String name):base(name,50000)
        {

        }
        public double bonusBudget = 1000;
        public override string employeeStatus()
        {
            return toString() + "with a budget of" + this.bonusBudget;
        }
    }
}
