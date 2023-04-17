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
            for (int i=0; i<range; i++)
            {
                coupons[i] = random.Next(1, 11);
            }

            Console.WriteLine("The coupon numbers are: ");
            for (int i=0; i<=coupons.Length;i++)
            {
                Console.WriteLine(coupons[i]);
            }
        }
    }
}
