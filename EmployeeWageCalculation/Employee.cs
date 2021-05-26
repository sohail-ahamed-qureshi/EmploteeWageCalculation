using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    class Employee
    {
        public void AttendenceCheck()
        {
            //constants
            const int WAGE_PER_HR = 20;
            const int WORKING_DAYS = 20;
            const int IS_FULL_TIME=8;
            const int IS_PART_TIME = 4;

            //variables
            int dailyWage = 0;
            int days = 0;
            int isPresent;
            int totalWage = 0;
            //random number generation
            Random rand = new Random();
            //calculating for month
            for(days =1; days <=WORKING_DAYS; days++)
            {
                 isPresent = rand.Next(0, 3);

                //using switch case
                switch (isPresent)
                {
                    case 1:
                        {
                            dailyWage = WAGE_PER_HR * IS_FULL_TIME;
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                    case 2:
                        {
                            dailyWage = WAGE_PER_HR * IS_PART_TIME;
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                }
                totalWage += dailyWage;
            }
            Console.WriteLine($"Montly wage is {totalWage}");



        }
    }

}
