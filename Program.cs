﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage !");

            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart",20,2,20); 
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance",10,4,20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToStringing());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToStringing());
        }
    }
}
