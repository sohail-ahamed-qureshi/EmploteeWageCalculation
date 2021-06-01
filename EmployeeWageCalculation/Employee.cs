﻿using System;
using System.Collections.Generic;// linkedlists
using System.Text;

namespace EmployeeWageCalculation
{/// <summary>
/// UC13- Storing Daily wages into list 
/// instead of array using array list
/// advantage of using arraylist is that it has dynamic memory allocation.
/// we dont have to define particular array size here.
/// </summary>
    interface IEmployeeWage
    {
        void ComputeEmpWage();
        void AddCompanyEmpWage(string company, int wagePerHour, int numWorkingDays, int maxHoursPerMonth);
    }

   
    public class EmpWageBuilderArray : IEmployeeWage
    {
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilderArray()
        {
            
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string company, int wagePerHour, int numWorkingDays, int maxHoursPerMonth)
        {
            
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, wagePerHour, numWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.Result());           
            }
        }

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalWage;
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
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
            for (days = 1; days <=companyEmpWage.numWorkingDays; days++) // calculating for 20 working days
            {
                isPresent = rand.Next(0, 3);
                //using switch case
                switch (isPresent)
                {
                    case FULL_TIME: // Employee is present full time
                        {
                            dailyWage =companyEmpWage.wagePerHour * IS_FULL_TIME;
                            break;
                        }
                    case PART_TIME: //employee is present for part time
                        {
                            dailyWage = companyEmpWage.wagePerHour * IS_PART_TIME;
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
                companyEmpWage.totalWage += dailyWage; // calculating montly wage
                if (totalHours >= companyEmpWage.maxHoursPerMonth) //maximum total hours 
                    break;
                Console.WriteLine(" Day#: " + days + " Emp Hrs : "+totalHours);
            }
            return totalHours * companyEmpWage.wagePerHour;
        } 
    }
}
