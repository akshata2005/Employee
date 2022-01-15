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
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            //UC1 Program
            //constants
           
            //variables
            int totalEmpHrs = 0;
            int empHrs = 0;
            int totalWorkingDays = 0;
            while(totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays <MAX_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
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
           
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#" + totalWorkingDays + "Emp Hrs" + empHrs);
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total emp wage :",  + totalEmpWage);
            Console.ReadLine();
        }
    }
}
