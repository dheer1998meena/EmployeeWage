using System;

namespace EmployeeWage
{
    class Program
    {
        public const int EMP_FULL_TIME = 1;
        public const int EMP_PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static int computeWage()
        {
            int empHrs = 0; int totalEmpHrs = 0; int totalEmpWage = 0; int totalEmpWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalEmpWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalEmpWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days :" + totalEmpWorkingDays + "Emp Hrs :" + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeWage();
        }
    }
}
