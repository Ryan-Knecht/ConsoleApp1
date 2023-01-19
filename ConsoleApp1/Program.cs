using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRolls = 0;
            int[] rollTotals = new int[12];

            //Prompt the user for the numrolls
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            numRolls = int.Parse(Console.ReadLine());

            Random r = new Random();

            //Simulate the roll of the die
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = r.Next(6);
                int roll2 = r.Next(6);

                int total = roll1 + roll2;

                rollTotals[total]++;
            }


            // Print results from the array\
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \nEach asterisk represents 1 % of the total number of rolls. \nTotal number of rolls = " + numRolls + ".\n");

            for (int i = 1; i < 12; i++)
            {
                double percent = ((double)rollTotals[i-1] / numRolls) * 100;
                string numStar = " ";

                //Add a star for each percent in that index space for the array
                for (int j = 0; j < percent; j++)
                {
                    numStar += "*";
                }

                Console.WriteLine((i + 1) + ":\t" + numStar);
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}


