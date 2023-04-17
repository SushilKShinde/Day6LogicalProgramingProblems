using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class CouponNumber
    {
        public static void FindCouponNumbers()
        {
            Console.WriteLine("Enter the range ");
            int range = Convert.ToInt32(Console.ReadLine());
            int[] coupons = new int[range];
            Random random = new Random();
            //int n = 10;
            int index = 0;
            for (int i=0; i<range; i++)
            { 
                int number = random.Next(1, 11);
                if (coupons.Contains(number)==false)
                {
                    coupons[index] = number;
                    index++;
                }
            }
            //printing coupon numbers
            Console.WriteLine("The coupon numbers are: ");
            for (int i=0; i<=coupons.Length;i++)
            {
                Console.Write(" "+coupons[i]);
            }
        }
    }
}
