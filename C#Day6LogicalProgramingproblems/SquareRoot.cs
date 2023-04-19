using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class SquareRoot
    {
        public static void FindSquareRoot(int n)
        {
            double root = 1;
            int i = 0;
            while(n>0)
            {
                i++;
                root = (n / root + root) / 2;
                if (i > n)
                { break; }
            }
            Console.WriteLine("Number of iterations: " + i);
            Console.WriteLine("SquareRoot Root of {0} is {1}",n,root );
        }
    }
}
