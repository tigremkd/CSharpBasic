using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class Menager : Employee
    {
        private double Bonus { get; set; }

        public Employee()
            :base(fName, lName, role, salary)
        {

        }
    }
}
