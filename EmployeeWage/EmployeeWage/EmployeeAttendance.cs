using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    //UC3- Add part time EmployeeWage. 
  public class EmployeeAttendance
    {
        public static void EmployeeWage()
        {
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int emp_Hrs = 0;
            int emp_Wage = 0;
            //random function
            Random random = new Random();
            int empCheck = random.Next(0,3);

            if (empCheck == IS_PART_TIME)

            {
                emp_Hrs = 4;

            }
            else if (empCheck == IS_FULL_TIME)
            {
                emp_Hrs = 8;
            }
            else 
            {
                emp_Hrs = 0;
            }
            emp_Wage = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage:" +emp_Wage);
        }
    }
}
