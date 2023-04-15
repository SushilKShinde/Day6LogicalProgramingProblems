using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class PrimeNumber
    {
       public static void FindPrimeNumber(int num)
        {
            int factors = 1;
            
            for(int i=2; i<=num/2; i++)
            {
                if(num%i==0)
                {
                   // Console.WriteLine("");
                    factors = 0;
                }
            }

            if (factors == 1)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }
    }
}
