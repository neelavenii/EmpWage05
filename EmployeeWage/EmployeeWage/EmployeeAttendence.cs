using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeAttendence
    {
        //defines the entry point of the application
        public static void Employee()
        {
            //uc1
            int isPresent = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);

            //selection statement
            if (isPresent == empInput)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }
    }
}
