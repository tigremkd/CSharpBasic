using SEDC.Oop.Class07.Exercise.Models;
using System;

namespace SEDC.Oop.Class07.Exercise.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson igor = new SalesPerson("Igor", "Nikoloski");

            igor.AddSuccessRevenue(2500);
            Console.WriteLine(igor.GetSalary());
            igor.PrintInfo();

            Menager trajan = new Menager("Trajan", "Stevkovski", Models.Emums.Role.Manager, 500);
            trajan.AddBonus(500);
            trajan.GetSalary();
        }
    }
}
