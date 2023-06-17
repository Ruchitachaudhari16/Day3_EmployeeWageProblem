using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    //UC4- Solve using Switch case Statement. 
  public class EmployeeAttendance
    {
        public  const int IS_PART_TIME = 1;
        public const  int IS_FULL_TIME = 2;

       public const  int EMP_RATE_PER_HOUR = 20;

        public static void EmployeeWagesCalculation()
        {   //Variables
            int emp_Hrs = 0;
         int emp_Wage = 0;

        //random function
        Random random = new Random();
            int empCheck = random.Next(0,3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    emp_Hrs = 4;
                    break;
                case IS_FULL_TIME:
                    emp_Hrs = 8;
                    break;
                default:
                    emp_Hrs = 0;
                    break;
            }
            emp_Wage = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage:" +emp_Wage);
        }
    }
}
