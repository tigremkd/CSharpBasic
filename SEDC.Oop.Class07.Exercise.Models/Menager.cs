using SEDC.Oop.Class07.Exercise.Models.Emums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class Menager : Employee
    {
        private double Bonus { get; set; }

        public Menager(string fName, string lName, Role role, double salary)
            : base(fName, lName, role, salary)
        {
            
        }
        public double AddBonus(double bonus)
        {
            return Bonus = bonus;
        }

        public override double GetSalary()
        {
            double bonus = AddBonus(Bonus);
            return GetSalary()  +  AddBonus(bonus);   
        }

    }
}
