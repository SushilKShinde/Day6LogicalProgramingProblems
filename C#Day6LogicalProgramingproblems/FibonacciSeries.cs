using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class FibonacciSeries
    {
        // In Fibonacci Series next number is sum of previous two numbers
        public void FindFibonacciSerries(int num)
        {   
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.Write("The fibonacci series is: {0} {1} ", n1, n2);

            for (int i = 0; i <=num; i++)
            {
                n3 = n1 + n2; 
                Console.Write(n3 + " ");    
                n1 = n2; 
                n2 = n3; 
            }
        }
    }
}
