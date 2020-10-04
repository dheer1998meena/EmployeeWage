using System;
using System.Collections;

namespace EmployeeWage
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeWageCalculators empWageCalculator = new EmployeeWageCalculators();

            empWageCalculator.AddCompanyDetails("Reliance", 60, 20, 100);
            empWageCalculator.AddCompanyDetails("Amazon", 40, 20, 80);

            // Calculate the employee wage of all the companyList
            empWageCalculator.CalculateTotalEmpWage();

            empWageCalculator.GetWagesOfCompany("Amazon");

        }
    }
}


