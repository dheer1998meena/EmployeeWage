using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            const int PART_TIME = 2;
            const int FULL_TIME = 1;
            const int empWagePerHour = 20;
            int numberOfWorkingDaysInMonth = 20;
            int workingDays = 0;
            int empHours = 0;
            int totalWagePerDay = 0;
            int totalWagePerMonth = 0;
            int MAX_HRS_IN_MONTH = 100;
            int totalEmpHours = 0;

            while (totalEmpHours < MAX_HRS_IN_MONTH && workingDays < numberOfWorkingDaysInMonth)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        empHours = 8;
                        workingDays++;
                        break;
                    case PART_TIME:
                        empHours = 4;
                        workingDays++;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHours = empHours + totalEmpHours;
                totalWagePerDay = empHours * empWagePerHour;
                totalWagePerMonth += totalWagePerDay;
                Console.WriteLine("Total Wage per Day.. " + totalWagePerDay);
            }
            Console.WriteLine("Total Wage per month: " + totalWagePerMonth);
            Console.ReadKey();
        }
    }
}
