using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{

    public class Company
    {
        public string companyName;
        public int empRatePerHour;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public int totalEmpWage;

        public Company(string companyName, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void SaveTotalWage(int totalWage)
        {
            totalEmpWage = totalWage;
        }

    }


}

	