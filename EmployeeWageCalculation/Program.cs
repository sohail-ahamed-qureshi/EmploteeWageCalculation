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
            //calculate employee Wage
            EmpWageBuilderObject Reliance = new EmpWageBuilderObject("Reliance" , 30 , 25, 100);
            EmpWageBuilderObject Infosys = new EmpWageBuilderObject("Infosys" , 40 , 35, 100);
            Reliance.ComputeEmpWage();
            Console.WriteLine(Reliance.ToString());
            Infosys.ComputeEmpWage();
            Console.WriteLine(Infosys.ToString());
        }
    }
}
