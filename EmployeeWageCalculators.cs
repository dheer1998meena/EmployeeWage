using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWageCalculators
    {
		List<Company> companies = new List<Company>();
		int numOfCompany = 0;
		int totalNumOfCompanies= 0;

		//Add the company details.
		public void AddCompanyDetails(string companyName, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
		{
			Company newCompany = new Company(companyName, empRatePerHour, maxWorkingDays, maxWorkingHours);
			companies.Add(newCompany);
			numOfCompany++;
			totalNumOfCompanies = numOfCompany;
		}

		// calculate the total emp wage.

		public void CalculateTotalEmpWage()
		{
			foreach ( Company company in companies)
			{
				int totalWage = CalculateTotalEmpWage(company);
				company.SaveTotalWage(totalWage);
				Console.WriteLine("The total monthly wage of {0} company is {1}", company.companyName, totalWage);
			}
		}

		//Method to calculate daily work hours of employee
		private int CalculateDailyEmpHours()
		{
			const int IS_FULL_TIME = 1;
			const int IS_PART_TIME = 2;

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
			int dailyWage = 0;
			int dailyEmpHours = 0;
			int day = 0;
			int totalEmpWorkHours = 0;
			int totalMonthlyWage;
			while (totalEmpWorkHours < company.maxWorkingHours && day < company.maxWorkingDays)
			{
				day++;                                       // Calculates No of working days till now in month
				dailyEmpHours = CalculateDailyEmpHours();    // Calculates No of working hours daily

				if (totalEmpWorkHours + dailyEmpHours <= company.maxWorkingHours)
					totalEmpWorkHours += dailyEmpHours;
				else
					totalEmpWorkHours = company.maxWorkingHours;
			}
			totalMonthlyWage = totalEmpWorkHours * company.empRatePerHour;
			return totalMonthlyWage;
		}

	}
}

