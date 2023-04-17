using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the c# basic logical programs");
            Console.WriteLine("Choose the program option from below options");
            Console.WriteLine("1.Fibonacci Series\n2.PrimeNumber\n3.ReverseANumber\n4.CouponNumber\n5.Stopwatch");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    Console.WriteLine("Enter the range of series");
                    int num = Convert.ToInt32(Console.ReadLine());
                    fibonacciSeries.FindFibonacciSerries(num);
                    break;
                case 2:
                    Console.WriteLine("Enter a integer number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.FindPrimeNumber(num1);
                    break;
                case 3:
                    Console.WriteLine("Enter a integer number");
                    int num2= Convert.ToInt32(Console.ReadLine());
                    ReverseANumber.ReverseNumber(num2);
                    break;
                case 4:
                    //call a method
                    CouponNumber.FindCouponNumbers();
                    break;
                case 5:
                    StopwatchSimulation.FindElapsedTime();
                    break;
                default:
                    Console.WriteLine("Please enter valid option.");
                    break;
            }
        }
    }
}
