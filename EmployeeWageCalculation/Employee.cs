using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    class Employee
    {
        public void AttendenceCheck()
        {
            //random number generation
            Random rand = new Random();
            int isPresent = rand.Next(2);

            if (isPresent == 1)
                Console.WriteLine("Employee is Present.");
            if (isPresent == 0)
                Console.WriteLine("Employee is Absent");
        }
    }
}
