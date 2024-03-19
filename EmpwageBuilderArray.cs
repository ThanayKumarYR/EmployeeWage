using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpwageBuilderArray
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numofCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpwageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfworkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numofCompany] = new CompanyEmpWage(company, empRatePerHour, numOfworkingDays, maxHoursPerMonth);
            numofCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToStringing());
            }

        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, tootalEmpHrs = 0, totalWorkingDays = 0;

            while (tootalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfworkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0,3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4; 
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8; 
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                tootalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return tootalEmpHrs * companyEmpWage.empRatePerHour
        }   
    }
}

