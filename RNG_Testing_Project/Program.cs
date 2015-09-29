using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNG_Testing_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> randomNumbers = new List<int>();
            Dictionary<int, UInt64> tallyCount = new Dictionary<int, UInt64>();
            //Key is 1-100 and value is number of times it appears
            for (int i = 1; i < 101; i++)
            {
                tallyCount.Add(i, 0);
            }

            UInt64 totalNumbers;
            
            Console.WriteLine("How many numbers do you require?");
            totalNumbers = Convert.ToUInt64(Console.ReadLine());    
            
            for (UInt64 i = 0; i < totalNumbers; i++)
            {
                int randomNumber = rng.Next(1, 101);
                tallyCount[randomNumber] += 1;
            }

            foreach(KeyValuePair<int,ulong> kvp in tallyCount)
            {
                double percentageOfTotal = (double)kvp.Value / (double)totalNumbers;
                Console.WriteLine("{0}: {1} --> Percentage: {2}", kvp.Key.ToString(), kvp.Value.ToString(), percentageOfTotal.ToString("P4"));
            }

            Console.ReadLine();
        }
    }

}
