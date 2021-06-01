using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{/// <summary>
/// adding oops concept by making it a abstract class
/// </summary>
    public abstract class AttendenceCheck
    {
      public abstract  void Attendence();
    }
    class Employee : AttendenceCheck
    {
        public override void Attendence()
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
