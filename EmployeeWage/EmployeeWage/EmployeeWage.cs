using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        public void Empwage()
        {
            int isFullTime = 1, empRatePerHr = 20, empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            //selection statement
            if (empCheck == isFullTime)
            {

                empHrs = 8;
            }
            else
            {

                empHrs = 0;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("empWage:" + empWage);

        }
    }
}
    

