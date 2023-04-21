using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class VendingMachine
    {
        public static void GetMinimumNumbersOfNotes(int amount)
        {
            //declare an array which stores notes available
            int[] notes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            //declare another array to store the minimum number of notes required 
            int[] change = new int[notes.Length];
            int i = 0;
            int temp = amount;
            while (amount>0)
            {
                if (amount >= notes[i])
                {
                    int remainingAmount = amount % notes[i];
                    change[i] = amount / notes[i]; //number of notes 
                    amount = remainingAmount;
                }
                i++;
            }
            for (int j = 0; j < notes.Length; j++)
            {
                if (change[j] != 0)
                    Console.WriteLine(change[j]+" Notes of " +" Rs " +notes[j] );
            }
        }
    }
}
