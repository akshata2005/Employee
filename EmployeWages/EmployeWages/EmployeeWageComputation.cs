using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWages
{
    public class EmployeeWageComputation
    {
        static void Main(string[] args)
        {
            //UC1 Program
            //constants
            //uc2 Calculate totalwage of employee
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int totalWage = 0;
            int empHrs = 0;
            int empRatePerHr = 20;

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            totalWage = empRatePerHr * empHrs;
            Console.WriteLine("Total Wage:" + totalWage);

        }
    }
}
