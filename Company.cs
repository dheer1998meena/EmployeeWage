using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Company
    {

        internal string companyName;
        internal int empRatePerHour;
        internal int maxWorkingDays = 0;
        internal int maxWorkingHours;
        internal int totalEmpWage;
        public int workingDay;
        public Dictionary<int, int> dailyWage = new Dictionary<int, int>();


        public Company(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.empRatePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
            this.workingDay = 1;

        }

        public void saveDailyWage(int dailyWage)
        {

            this.dailyWage.Add(workingDay, dailyWage);
            workingDay++;

        }


        public void saveTotalWage(int totalWage)
        {
            totalEmpWage = totalWage;
        }

    }
}

