﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWages;

        public EmpWageBuilderObject(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)

        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + "emp Hrs : " + empHrs);

            }
            totalEmpWages = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is : " + totalEmpWages);
        }

        public string ToStringing()
        {
            return "Total Emp Wage for Company : " + this.company + " is: " + this.totalEmpWages;
        }
    }


}
