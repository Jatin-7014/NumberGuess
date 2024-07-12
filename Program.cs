using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Random rnd = new Random();
            int generatedNumber= Convert.ToInt32(rnd.Next(0,9));
            int attempts= 1;
            int guessedNumber;
            bool flag = false;

            while (attempts<4 || flag)
            {
            
                Console.WriteLine("Please enter you guesses number : ");
                guessedNumber = Convert.ToInt32(Console.ReadLine());

                if(guessedNumber>generatedNumber)
                {
                    Console.WriteLine("Hint:Your guessed number is larger\n");
                    attempts++;
                }
                else if(guessedNumber<generatedNumber){
                    Console.WriteLine("Hint:Your guessed number is smaller\n");
                    attempts++;
                }
                if (guessedNumber == generatedNumber)
                {
                    Console.WriteLine("Congratulations!Your guessed number is right");
                    Console.WriteLine("You guessed in " + attempts + " attempts");
                    flag= true;
                    goto end;
                }
            }
            Console.WriteLine("Attempts exhausted!,You lost the game my friend\n");
        end:
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("If you want to continue press 0 else 1");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
                goto start;
            else
                return;
        }
    }
}
