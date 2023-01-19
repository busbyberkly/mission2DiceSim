using System;
//author : Busbyberkly 1/18/23
namespace mission2DiceSim
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoll dr = new DiceRoll();
            int userthrow = 0;
            
            Console.WriteLine("Welcome to the dice throwing simulator!!");
            Console.WriteLine("How many times would you like to throw the dice?");
            userthrow = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Dice Totals: ");

            dr.DiceTotal(userthrow);
            Console.WriteLine("Thanks for playing!!");
        }
    }
}
