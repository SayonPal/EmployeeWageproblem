using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class EmployeeAttendence

    {
        public void Presence()
        {

            int Present = 1;
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random Random = new Random();
            int empCheck = Random.Next(0, 2);
            if (empCheck == Present)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}