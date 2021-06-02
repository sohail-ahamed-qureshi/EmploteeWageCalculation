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
     public abstract void DailyWage(int attendence);

    }
    class Employee : AttendenceCheck
    {
        public override void Attendence()
        {
            //random number generation
            Random rand = new Random();
            int isPresent = rand.Next(2);

            DailyWage(isPresent);
        }

        public override void DailyWage(int isPresent)
        {
            //constants
            const int WAGE_PER_HR = 20;
            const int IS_FULL_TIME_HOURS = 8;
            const int FULL_TIME = 1;
            const int IS_ABSENT = 0;
            //variables
            int dailyWage = 0;
            if (isPresent == FULL_TIME)
            {
                dailyWage = WAGE_PER_HR * IS_FULL_TIME_HOURS;
                Console.WriteLine($"Daily wage is {dailyWage}");
            }
            if (isPresent == IS_ABSENT)
            {
                Console.WriteLine($"Daily wage is {dailyWage}");
            }
        }
    }

}
