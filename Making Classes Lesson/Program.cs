using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Die die1 = new Die();
            Die die2 = new Die();
            
            Console.WriteLine(die1);
            die1.DrawRoll();
            die1.RollDie();
            Console.WriteLine(die1);
            die1.DrawRoll();
            die1.RollDie();


            //Assignment:

            if (die1 == die1) 
            {
                Console.WriteLine("Both die are the same-You got a Double!"); 
            }
            







        }
    }
}
