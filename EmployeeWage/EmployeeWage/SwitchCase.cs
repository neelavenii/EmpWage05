using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeSwitch
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empRatePerHr = 20;
        public static void EmployeeSwitch1()
        {
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case isFullTime:
                    Console.WriteLine("FullTime employee is present");
                    empHrs = 4;
                    break;
                case isPartTime:
                    Console.WriteLine("PartTime employee is present");
                    empHrs = 8;
                    break;
                default:
                    Console.WriteLine(" employee is absent");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("empWage:" + empWage);

        }

    }
}
    

