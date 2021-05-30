using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    class Employee
    {
        public void ComputeEmpWage(string company, int wagePerHour, int numWorkingDays, int maxHoursPerMonth)
        {
            //constants
            //const int WAGE_PER_HR = 20;
            //const int WORKING_DAYS = 20;
            const int IS_FULL_TIME=8;
            const int IS_PART_TIME = 4;
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            //variables
            int dailyWage = 0;
            int days, isPresent;
            int totalWage = 0;
            int totalHours=0;
            //random number generation
            Random rand = new Random();
            //calculating for month
            for(days =1; days <=numWorkingDays; days++) // calculating for 20 working days
            {  
                 isPresent = rand.Next(0, 3);
                //using switch case
                switch (isPresent)
                {
                    case FULL_TIME: // Employee is present full time
                        {
                            dailyWage = wagePerHour * IS_FULL_TIME;
                           // Console.WriteLine($"Daily wage is {dailyWage}");  // daily wage is 160
                            break;
                        }
                    case PART_TIME: //employee is present for part time
                        {
                            dailyWage = wagePerHour * IS_PART_TIME;
                         //   Console.WriteLine($"Daily wage is {dailyWage}");  // daily wage is 80
                            break;
                        }
                    default: // employee is absent
                        {
                            //Console.WriteLine($"Daily wage is {dailyWage}"); // daily wage is 0
                            break;
                        }   
                }
                //checking total number of hours
                totalHours += dailyWage / 20; //calculate total hours worked
                totalWage += dailyWage; // calculating montly wage
                if (totalHours >= maxHoursPerMonth) //maximum total hours 
                    break;
            }
            //Console.WriteLine($"Montly wage is {totalWage} and working hours is {totalHours}"); // output 
            Console.WriteLine();
            Console.WriteLine($"Company Name :{company}");
            Console.WriteLine($"No. of hours worked :{totalHours}");
            Console.WriteLine($"Wage Per hour :{wagePerHour}");
            Console.WriteLine($"Monthly wage :{totalWage}");
            Console.WriteLine();
        }
    }
}
