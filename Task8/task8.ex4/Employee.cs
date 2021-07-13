using System;
using System.Collections.Generic;
using System.Text;

namespace task8.ex4
{
    abstract class Employee
    {
        private static int employeeCount = 1;
        private string employeeName;
        private double employeeBaseSalary;
        private int emloyeeId;

        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int Id
        {
            get
            {
                return emloyeeId;
            }
            set
            {
                emloyeeId = value;
            }
        }
        public Employee(String name ,double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Id = employeeCount++;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.Id;
        }
        public String toString()
        {
            return this.Id + "" + this.Name;
        }
        public abstract String employeeStatus();
    
    }
}
