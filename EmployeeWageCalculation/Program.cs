using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        /// <summary>
        /// Saving Total employee wage by Company. 
        /// passing arguments company name, rate per hour, working days and Maximum
        /// hours per month.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to Employee wage Calculation ");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("Reliance", 20, 10, 10);
            empWageBuilder.AddCompanyEmpWage("Infosys", 20, 10, 10);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine($"Total wage for Reliance Company : {empWageBuilder.getTotalWage("Reliance")}");
        }
    }
}
