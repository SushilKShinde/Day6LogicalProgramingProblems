using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class ReverseANumber
    {       
        public static void ReverseNumber(int num)
        {
            int reverse = 1; // 567
            Console.WriteLine("Before reversing: {0}", num);
            while (num>0)
            {
                num = num % 10;
                reverse = (reverse * 10) + num;
                num = num / 10;
            }
        }
    }
}
