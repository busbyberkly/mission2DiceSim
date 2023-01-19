using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2DiceSim
{
    class DiceRoll
    {
        public void DiceTotal(int dicethrows)
        {
            //I made the array bigger than 12 so that it would display correctly.
            int[] rolls = new int[13];

            //intializing the varibles
            int dtotal = 0;
            int die1 = 0;
            int die2 = 0;
            int rollnum = 0;
            double displaynum = 0;
            
            //generate the random number like a dice throw
            Random rnd = new Random();

            //"throw the dice" as many times as the user wants.
            for(int i = 0; i< dicethrows; i++)
            {
                //rolling die 1 and 2, and then adding them up. putting the sum of the dice into the array.
                die1 = rnd.Next(1, 7);
                die2 = rnd.Next(1, 7);             
                dtotal = die1 + die2;  
                rolls[dtotal]++;
            }
            
            //print results
            for (int i = 2; i < rolls.Length; i++)
            {
                //list of * characters to display
                List<char> aterisklist = new List<char>();
                
                rollnum = rolls[i];
                //converting the amount of times a number was rolled into a percentage.
                displaynum = ((double)rollnum / (double)dicethrows) * 100;
                displaynum = Math.Round(displaynum);
                
                //populating the list to have the right amount of aterisks
                for (int j =0; j < displaynum; j++)
                { 
                    aterisklist.Add('*');
                  
                }

                //display the results using the string.Join method.
                Console.WriteLine(i + " : {0}" , string.Join("", aterisklist));
            }

        }
        
    }
}
