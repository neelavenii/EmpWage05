using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class MaxDays
    {
       public static void Max()
        { 
        int empWage = 0, empHrs = 0, totalEmpWage = 0;
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        const int NUM_OF_WORKING_DAYS = 20;
        const int EMP_RATE_PER_HR = 20;
        const int MAX_WORKING_HRS = 100;
            int workingHrs = 0;
            int day = 1;
            Random random = new Random();

            while (day<= NUM_OF_WORKING_DAYS && workingHrs<= MAX_WORKING_HRS)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                        // Console.WriteLine("FullTime employee is present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        // Console.WriteLine("PartTime employee is present");
                        empHrs = 4;
                        break;
                    default:
                        // Console.WriteLine(" employee is absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Daily Wage{0} ", empWage);
                totalEmpWage += empWage;
                workingHrs += empHrs;
                day++;

            }
            Console.WriteLine("Total wage for {0} days and working hrs:{1} and wage is :{2}", day,workingHrs, totalEmpWage);
            Console.ReadLine();
        }











    }
}
