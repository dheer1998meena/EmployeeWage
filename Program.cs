using System;

namespace EmployeeWage
{
    class Program
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        public static float wageCalculation(string companyName, int employeeRatePerHour, int workingDays, int maxHours)
        {
            int empHour = 0, totalEmpHour = 0, totalWorkDay = 0;

            while (totalEmpHour < maxHours && totalWorkDay < workingDays)
            {
                Random ran = new Random();
                int empAttendance = ran.Next(0, 3);
                if (empAttendance != 0)
                {
                    totalWorkDay++;
                }

                switch (empAttendance)
                {
                    case PART_TIME:
                        empHour = 4;
                        break;
                    case FULL_TIME:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }

                totalEmpHour += empHour;
                Console.WriteLine("Number of Days = {0}, Employee Hours ={1}", totalWorkDay, totalEmpHour);
            }

            int totalEmployeeWage = totalEmpHour * employeeRatePerHour;
            Console.WriteLine("Total Wage of an Employee for company = {0} is {1}", companyName, totalEmployeeWage);
            return totalEmployeeWage;
        }
        static void Main(string[] args)
        {
            wageCalculation("Samsung", 20, 10, 100);
            wageCalculation("Reliance", 100, 50, 200);
        }
    }
}
