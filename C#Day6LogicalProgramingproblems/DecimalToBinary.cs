using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class DecimalToBinary
    {
        public static void ConvertNumberToBinary(int num)
        {
            string binary = " ";           
            int n;

            while (num>0)
            {
                n = num % 2;
                binary = Convert.ToString(n) + binary;
                num = num / 2;
            }
            Console.WriteLine("Binary Conversion: "+ binary);
        }
    } 
}
