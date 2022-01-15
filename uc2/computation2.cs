using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   public class Computation
    {
        public void ComputeEmpWagwe()
        {
            int FULLTIME = 1;
            int EMP_PER_HR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random Random = new Random();
            int empCheck = Random.Next(0, 2);
            if (empCheck == FULLTIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_PER_HR;
            Console.WriteLine("Daily Employee Wage is" + empwage);
            Console.Read();
        }
    }

}