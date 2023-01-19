using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDiceMice
{
    public class Program
    {
        public static void Main(string[] args)
        {
                DiceRoller();
        }

        private static void DiceRoller()
        {
            int numRolls = 0;
            Console.WriteLine("How many dice rolls would you like to simulate?");
            numRolls = Int32.Parse(Console.ReadLine());

            Random r = new Random();
            int[] rollResults = new int[12];

            // Add two random dice being "thrown" and place them in array (actually 0-11 with 11 being impossible)
            for (int i = 0; i < numRolls; i++)
            {
                int numOne = r.Next(6);
                int numTwo = r.Next(6);
                int totalRoll = numOne + numTwo;
                rollResults[totalRoll]++;
            }

            // Print the results with * indicating number of rolls (for now)
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \" * \"  " +
                "represents 1% of the total number of rolls.\nTotal number of rolls = " + numRolls.ToString() + ".\n\n");
            // Only iterating 0-10 because an '11' in this case can never be rolled
            for (int i = 0; i < 11; i++)
            {
                decimal numAst = Math.Round((Convert.ToDecimal(rollResults[i]) / Convert.ToDecimal(numRolls)) * 100, 0);
                Console.Write((i + 2).ToString() + ": ");
                // Sub for-loop prints the asteriks representing each percent 
                for (int j = 0; j < numAst; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
