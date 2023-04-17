using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class StopwatchSimulation
    {
       public static void FindElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //start the stopwatch
            int sum = 0;
            //perform some operatio to check how much time it takes to perform
            for (int i=0; i<=100; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum is: "+sum);
            stopwatch.Stop(); //stop stopwatch
            Console.WriteLine("The time spent on operation is:{0} ", stopwatch.Elapsed);
        }
    }
}
