//Jessica Holt 
// Date 1/18/22
// Assignment - Mission #2
// Description - This program simulates the rolling of two 6-sided dice.
//               It uses an Array to keep track of the number of times that each
//               total number is thrown.  In other words, it keeps track of how
//               many times the combination of the two simulated dice is 2,
//               how many times the combination is 3, and so on, all the way up through 12. 
using System;

namespace JessMission2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sRolls;
            int iRolls;
            int die1;
            int die2;
            int sum;
            int iCounter2 = 0;
            int iCounter3 = 0;
            int iCounter4 = 0;
            int iCounter5 = 0;
            int iCounter6 = 0;
            int iCounter7 = 0;
            int iCounter8 = 0;
            int iCounter9 = 0;
            int iCounter10 = 0;
            int iCounter11 = 0;
            int iCounter12 = 0;
            int[] iCounterArray = new int[11];
            int[] percentageArray = new int[11];

            Console.WriteLine();
            Console.WriteLine("Welcome to the dice throwing simulator! ");

            Console.WriteLine();
            Console.Write("How many dice rolls would you like to simulate? ");
            sRolls = Console.ReadLine();
            iRolls = Convert.ToInt32(sRolls);

            // Write a program that simulates the rolling of two 6-sided dice. 
            for (int iCount = 0; iCount < iRolls; iCount++)
            {
                sum = 0;
                die1 = new Random().Next(1, 7); // Generates a number between 1 to 6
                die2 = new Random().Next(1, 7); // Generates a number between 1 to 6
                sum = (die1 + die2);


                /* Use an Array to keep track of the
            number of times that each total number is thrown. In other words, keep track of how many times
            the combination of the two simulated dice is 2, how many times the combination is 3, and so on,
            all the way up through 12. */


                if (sum == 2)
                {
                    iCounter2++;
                }

                if (sum == 3)
                {
                    iCounter3++;
                }

                if (sum == 4)
                {
                    iCounter4++;
                }

                if (sum == 5)
                {
                    iCounter5++;
                }

                if (sum == 6)
                {
                    iCounter6++;
                }

                if (sum == 7)
                {
                    iCounter7++;
                }

                if (sum == 8)
                {
                    iCounter8++;
                }

                if (sum == 9)
                {
                    iCounter9++;
                }

                if (sum == 10)
                {
                    iCounter10++;
                }

                if (sum == 11)
                {
                    iCounter11++;
                }

                if (sum == 12)
                {
                    iCounter12++;
                }

            }
            //Give each position in an array a value to simulate the number of dice it represents.

            iCounterArray[0] = iCounter2;
            iCounterArray[1] = iCounter3;
            iCounterArray[2] = iCounter4;
            iCounterArray[3] = iCounter5;
            iCounterArray[4] = iCounter6;
            iCounterArray[5] = iCounter7;
            iCounterArray[6] = iCounter8;
            iCounterArray[7] = iCounter9;
            iCounterArray[8] = iCounter10;
            iCounterArray[9] = iCounter11;
            iCounterArray[10] = iCounter12;

            //Display the titles and results

            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine();
            Console.WriteLine("Each \" * \" represents 1 % of the total number of rolls.");
            Console.WriteLine();
            Console.WriteLine("Total number of rolls = " + iRolls);
            Console.WriteLine();

            //Loops to populate the array with the percentage that each number from the die is rolled 
            for (int iCount = 0; iCount < iCounterArray.Length; iCount++)
            {
               percentageArray[iCount] = ((iCounterArray[iCount] * 100) / iRolls);
            }

            //loop to make the histogram using the calculated percentage and the astrics that represent each one.
            for (int iCount = 0; iCount < iCounterArray.Length; iCount++)
            {
                Console.Write((iCount +2) + ": ");
                    
                for (int iCount1 = 0; iCount1 < percentageArray[iCount]; iCount1++)
                {
                    Console.Write("*");
                  
                }

                Console.WriteLine();
            }

            //create good spacing and print farewell message. If you go to the house afterwards, there will be refreshments;)
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            Console.WriteLine();
            
        }
    }
}
