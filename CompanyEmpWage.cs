using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfworkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfworkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string ToStringing()
        {
            return "Total Emp Wage for company" + this.company + " is: " + this.totalEmpWage;
        }
    }
}
