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

            //Console.WriteLine(die1);
            //die1.DrawRoll();
            //die1.RollDie();
            //Console.WriteLine(die1);
            //die1.DrawRoll();
            //die1.RollDie();

            //Console.WriteLine(die2);
            //die2.DrawRoll();
            //die2.RollDie();
            //Console.WriteLine(die2);
            //die2.DrawRoll();
            //die2.RollDie();


            //Assignment:


            while (true)
            {
                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("Both die are the same-You got a Double!");
                }

                else 
                {
                    Console.WriteLine("These are not Doubles."); 
                }

                if (die1.Roll + die2.Roll == 7)
                {
                    Console.WriteLine("Both die add up to 7!");
                }

                else 
                {
                    Console.WriteLine();
                }

                if (die1.Roll + die2.Roll == 2)
                {
                    Console.WriteLine("Snake Eyes.");
                }

                else 
                {
                    Console.WriteLine();
                }

                if (die1.Roll + die2.Roll % 2 == 0) //Uses long division to detect which numbers are even 
                {
                    Console.WriteLine("That's an even sum!");
                }

                else 
                {
                    Console.WriteLine("");
                }

                if (die2.Roll - die1.Roll == 1)
                {
                    Console.WriteLine("Ha! They're sequential");
                }

                else 
                {
                    Console.WriteLine("");
                }

                if (die1.Roll > die2.Roll)
                {
                    Console.WriteLine("Die 1 is larger than Die 2!");
                }

                else if (die1.Roll < die2.Roll)
                {
                    Console.WriteLine("Die 2 is larger than Die 1!");
                }

                else 
                {
                    Console.WriteLine("");
                }






                    die1.DrawRoll();
                die1.RollDie();
                die2.DrawRoll();
                die2.RollDie();
                Console.ReadLine();
                Console.Clear();
            }







        }
    }
}
