using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Making_Classes_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Die die1 = new Die();
            Thread.Sleep(1);     //Adds a 1-millisecond delay, causing both randoms to generate seperetly, resulting in different numbers (mostly, unless you DO ge a double).
            Die die2 = new Die();
            
            die1.Color = ConsoleColor.Cyan;
            die2.Color = ConsoleColor.Blue;

            Console.WriteLine(die1);
            die1.DrawRoll();
            die1.RollDie();
            //Console.WriteLine(die1);
            //die1.DrawRoll();
            //die1.RollDie();

            Console.WriteLine(die2);
            die2.DrawRoll();
            die2.RollDie();
            //Console.WriteLine(die2);
            //die2.DrawRoll();
            //die2.RollDie();


            //Assignment:

            if (die1 == die2) 
            {
                Console.WriteLine("Both die are the same-You got a Double!"); 
            }
            







        }
    }
}
