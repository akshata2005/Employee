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
            //uc1 programs
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
