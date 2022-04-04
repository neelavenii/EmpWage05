using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation ");
            EmployeeAttendence.Employee();
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Empwage();


            Console.ReadLine();
        }
    }
}
