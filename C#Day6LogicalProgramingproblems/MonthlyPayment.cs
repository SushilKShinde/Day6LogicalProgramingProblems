using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class MonthlyPayment
    {
        public static void CalculateMonthlyPayment()
        { 
            Console.WriteLine("Enter the principal loan amount.");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the percentage of interest.");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the period in years.");
            double Y = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("The total monthly payable amount is {0}", payment);
        }
    }
}
