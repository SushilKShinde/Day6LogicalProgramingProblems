using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class PerfectNumber
    {
        public static void CheckForPerfectNumber(int num)
        {
            //int[] array;
            int sum = 0;
            int temp = num;
            Console.Write("Factors of {0}: ",num );
            for (int i=1;i<num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(" "+i+" ");
                    sum += i;
                }               
            }
            if (sum == temp)
            {
                Console.WriteLine("\n{0} is perfect number", temp);
            }
            else
            {
                Console.WriteLine("\n{0} is not a perfect number", temp);
            }
        }
    }
}
