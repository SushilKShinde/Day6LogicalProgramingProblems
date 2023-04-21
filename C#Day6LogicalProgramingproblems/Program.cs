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
            Console.WriteLine("1.Fibonacci Series\n2.PrimeNumber\n3.ReverseANumber\n4.CouponNumber\n5.Stopwatch" +
                "\n6.PerfectNumber\n7.DayOfWeek\n8.TemperatureConversion\n9.MonthlyPayment\n10.BinaryToDecimalConversion" +
                "\n11.SquareRootOfPositiveInteger\n12.Vending Machine");
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
                case 6:
                    Console.WriteLine("Enter a integer number");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber.CheckForPerfectNumber(num3);
                    break;
                case 7:
                    Console.WriteLine("Please enter the date in format DD/MM/YYYY");
                    Console.WriteLine("Enter a date");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a month");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    DayOfWeek.FindDayOfweek(day, month, year);
                    break;
                case 8:                
                    TemperatureConversion.ConvertCelsiusTofahrenheit();
                    TemperatureConversion.ConvertFahrenheitToCelcius();
                    break;
                case 9:
                    MonthlyPayment.CalculateMonthlyPayment();
                    break;
                case 10:
                    Console.WriteLine("Enter a integer number");
                    num = Convert.ToInt32(Console.ReadLine());
                    DecimalToBinary.ConvertNumberToBinary(num);
                    break;
                case 11:
                    Console.WriteLine("Enter a integer number");
                    num = Convert.ToInt32(Console.ReadLine());
                    SquareRoot.FindSquareRoot(num);
                    break;
                case 12:
                    Console.WriteLine("Please enter the amount");
                    int amount = Convert.ToInt32(Console.ReadLine());   
                    VendingMachine.GetMinimumNumbersOfNotes(amount);
                    break;
                default:
                    Console.WriteLine("Please enter valid option.");
                    break;
            }
        }
    }
}
