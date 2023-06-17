using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    //UC2- Calculate Employee Wage.
  public class EmployeeAttendance
    {
        public static void EmployeeWage()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int emp_Hrs =0;
            int emp_Wages =0;


            //random function
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)

            {
                emp_Hrs = 8;
            }
            else
            {
                emp_Hrs = 0;
            }
            emp_Wages = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is:"+emp_Wages);
        }
    }
}
