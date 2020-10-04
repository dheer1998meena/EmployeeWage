using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWageCalculators
    {
        List<Company> companyList = new List<Company>();
        Dictionary<string, Company> searchByCompany = new Dictionary<string, Company>();
        
        // Adds the company details.
        public void AddCompanyDetails(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            Company newCompany = new Company(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
            companyList.Add(newCompany);
            searchByCompany.Add(companyName, newCompany);
        }

        // Calculates the total emp wage.
        
        public void CalculateTotalEmpWage()
        {
            foreach (Company company in companyList)
            {
                company.saveTotalWage(CalculateTotalEmpWage(company));
                Console.WriteLine("The total monthly wage of {0} company is {1}\n", company.companyName, company.totalEmpWage);
            }
        }
        //Method to calculate daily work hours of employee
        private int CalculateDailyEmpHours() 
        {
            // constants
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            //variables
            int empHours = 0;
            Random random = new Random();
            int workType = random.Next(0, 3);
            switch (workType)
            {
                case IS_FULL_TIME:

                    empHours = 8;       
                    break;

                case IS_PART_TIME:

                    empHours = 4;     
                    break;

                default:

                    empHours = 0;
                    break;
            }
            return empHours;
        }
        //Method to calculate total wage
        private int CalculateTotalEmpWage(Company company) 
        {

            //variables
            int dailyWage = 0;
            int dailyEmpHours = 0;
            int day = 0;
            int totalEmpWorkHours = 0;
            int totalMonthlyWage;

            while (totalEmpWorkHours < company.maxWorkingHours && day < company.maxWorkingDays)
            {
                day++;                                       // Calculates No of working days till now in month
                dailyEmpHours = CalculateDailyEmpHours();    // Calculates No of working hours daily
                dailyWage = dailyEmpHours * company.empRatePerHour;
                company.saveDailyWage(dailyWage);

                if (totalEmpWorkHours + dailyEmpHours <= company.maxWorkingHours)
                    totalEmpWorkHours += dailyEmpHours;
                else
                    totalEmpWorkHours = company.maxWorkingHours;
            }

            totalMonthlyWage = totalEmpWorkHours * company.empRatePerHour;
            return totalMonthlyWage;
        }

        internal void GetWagesOfCompany(string companyName)
        {
            Console.WriteLine("The wages of the company {0} queried are as below:", companyName);
            Company company = searchByCompany[companyName];

            foreach (KeyValuePair<int, int> dailyWage in company.dailyWage)
                Console.WriteLine("The daily wage of employee for day {0} is {1}", dailyWage.Key, dailyWage.Value);

            Console.WriteLine("\nThe total monthly wage of {0} company is {1}", companyName, company.totalEmpWage);

        }
    }


}

