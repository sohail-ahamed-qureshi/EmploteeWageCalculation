using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        /// <summary>
        /// employee wage computation for multiple companies
        /// passing arguments company name, rate per hour, working days and Maximum
        /// hours per month.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to Employee wage Calculation ");
            //calculate employee Wage
            Employee employee = new Employee();
            employee.ComputeEmpWage("Reliance", 30, 30, 50);
            employee.ComputeEmpWage("Infosys", 35, 25, 100);
        }
    }
}
