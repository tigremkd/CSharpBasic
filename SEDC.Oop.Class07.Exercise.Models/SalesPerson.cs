using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class SalesPerson : Employee
    {
        private double SucssesSaleRevenue { get; set; }

        public SalesPerson()
        {
            Salary = 500;
            Role = Emums.Role.Sales;
        }
        public SalesPerson(string fName, string lName, Emums.Role role, double salary)
            :base (salary, role)
        {
            FirstName = fName;
            LastName = lName;
           
        }
        public SalesPerson (string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            Salary = 500;
            Role = Emums.Role.Sales;
        }
        public void AddSuccessRevenue(double number)
        {
            SucssesSaleRevenue = number;
        }

        public override double GetSalary()
        {
            double bonus = 0;
            if(SucssesSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if(SucssesSaleRevenue > 2000 && SucssesSaleRevenue <= 5000)
            {
                bonus = 1000;
            }else if(SucssesSaleRevenue > 5000)
            {
                bonus = 1500;
            }
            return base.GetSalary() + bonus;
        }
    }
}
