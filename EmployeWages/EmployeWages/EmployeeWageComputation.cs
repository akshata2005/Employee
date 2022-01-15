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
        public const int MAX_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
            //UC1 Program
            //constants
           
            //variables
            int totalWage = 0;
            int empHrs = 0;
            int empWage = 0;
            int day;
            Random random = new Random();
            for ( day = 1; day <= MAX_WORKING_DAYS; day++)
            {

                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case IS_FULL_TIME:
                       // Console.WriteLine("Fulltime Employee is Present");
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        empHrs = 4;
                       // Console.WriteLine("Parttime Employee is Present");

                        break;

                    default:
                       // Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
            }
            //calculation of salary
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wages for day{0} is {1}", day, empWage);
            totalWage += empWage;
            //totalwage=totalwage+empwage
            Console.WriteLine();
            Console.WriteLine("Total wages for {0}Day is {1}", MAX_WORKING_DAYS, totalWage);
            Console.ReadLine();
        }
    }
}
