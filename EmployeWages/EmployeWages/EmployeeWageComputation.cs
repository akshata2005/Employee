using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWages
{
    public class EmployeeWageComputation
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
            //UC1 Program
            //constants
           
            //variables
            int totalWage = 0;
            int empHrs = 0;
            Random random = new Random();

            int randomInput = random.Next(0, 3);
            switch (randomInput)
            {
                case  IS_FULL_TIME:
                     Console.WriteLine("Fulltime Employee is Present");
                     empHrs = 8;
                     break;

                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Parttime Employee is Present");
                    
                    break;

                default:
                     Console.WriteLine("Employee is Absent");
                     empHrs = 0;
                    break;
            }
            //calculation of salary
            totalWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Total Wage:" + totalWage);

        }
    }
}
