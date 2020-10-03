using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            const int EMP_FULL_TIME = 1;
            const int EMP_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empWage = 0;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case EMP_FULL_TIME:
                    empHrs = 8;
                    break;
                case EMP_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWage : " + empWage);
        }
    }
}
