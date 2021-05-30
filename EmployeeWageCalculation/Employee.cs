using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    public class EmpWageBuilderObject
    {
        //properties 
         private string company;
         private int wagePerHour;
         private int numWorkingDays;
         private int maxHoursPerMonth;
        private int totalWage;

        public EmpWageBuilderObject(string company, int wagePerHour, int numWorkingDays, int maxHoursPerMonth)
        { 
            //Constructors
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.numWorkingDays = numWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            //constants
            const int IS_FULL_TIME = 8;
            const int IS_PART_TIME = 4;
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            //variables
            int dailyWage = 0;
            int days, isPresent;
            // int totalWage = 0;
            int totalHours = 0;
            //random number generation
            Random rand = new Random();
            //calculating for month
            for (days = 1; days <= this.numWorkingDays; days++) // calculating for 20 working days
            {
                isPresent = rand.Next(0, 3);
                //using switch case
                switch (isPresent)
                {
                    case FULL_TIME: // Employee is present full time
                        {
                            dailyWage = this.wagePerHour * IS_FULL_TIME;
                            break;
                        }
                    case PART_TIME: //employee is present for part time
                        {
                            dailyWage = this.wagePerHour * IS_PART_TIME;
                            break;
                        }
                    default: // employee is absent
                        {
                            dailyWage = isPresent;
                            break;
                        }
                }
                //checking total number of hours
                totalHours += dailyWage / 20; //calculate total hours worked
                totalWage += dailyWage; // calculating montly wage
                if (totalHours >= this.maxHoursPerMonth) //maximum total hours 
                    break;
            }
            //Console.WriteLine($"Montly wage is {totalWage} and working hours is {totalHours}"); // output 
            Console.WriteLine();
            Console.WriteLine($"Company Name :{this.company}");
            Console.WriteLine($"No. of hours worked :{totalHours}");
            Console.WriteLine($"Wage Per hour :{this.wagePerHour}");
            Console.WriteLine($"Monthly wage :{this.totalWage}");
        }
    }
}
