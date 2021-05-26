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
            const int IS_FULL_TIME=8;
            //variables
            int dailyWage = 0;

            //random number generation
            Random rand = new Random();
            int isPresent = rand.Next(2);

            if (isPresent == 1)
            {
                dailyWage = WAGE_PER_HR * IS_FULL_TIME;
                Console.WriteLine($"Daily wage is {dailyWage}");

            }
           else
            {
                Console.WriteLine($"Daily wage is {dailyWage}");
            }
                
        }
    }

}
