using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC8:- Compute Employee Wage for multiple companies -Note: Each Company has its own
            

            EmployeeAttendance.ComputeEmpWage("Dmart", 20, 2, 10);
            EmployeeAttendance.ComputeEmpWage("Reliance", 10, 4, 20);
            Console.ReadLine();
        }
    }
}
