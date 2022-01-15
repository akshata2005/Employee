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
           
            int IS_PART_TIME = 1;
            int IS_FULL_TIME=2;
            int EMP_RATE_PER_HR = 20;
            //variables
            int totalWage = 0;
            int empHrs = 0;
            Random random = new Random();

            int randomInput = random.Next(0, 3);
            if (randomInput == IS_FULL_TIME)
            {
                Console.WriteLine("Fulltime Employee is Present");
                empHrs = 8;
            }
            else if (randomInput == IS_PART_TIME)
            {
                Console.WriteLine("Parttime Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            //calculation of salary
            totalWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Total Wage:" + totalWage);

        }
    }
}
