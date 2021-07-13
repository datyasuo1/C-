using System;
using System.Collections.Generic;
using System.Text;

namespace task8.ex4
{
    class TechnicalEmployee : Employee
    {
        public int sucessfulCheckIns = 5;
        public TechnicalEmployee(String name) : base(name, 75000)
        {
        }
        public override string employeeStatus()
        {
            return this.toString() + "has" + this.sucessfulCheckIns + "sucessfil ins";
        }
    }
}
