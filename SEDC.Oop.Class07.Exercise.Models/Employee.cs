using SEDC.Oop.Class07.Exercise.Models.Emums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} Salary : {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
        public Employee()
        {
            Console.WriteLine("Default");
        }
        public Employee(string fName, string lName, Role role, double Salary)
        {
            FirstName = fName;
            LastName = lName;
            Role = role;
            Salary = Salary;
        }
        public Employee(double salary, Role role)
        {
            Salary = salary;
            Role = role;
        }
    }
}
