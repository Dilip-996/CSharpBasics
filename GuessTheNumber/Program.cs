using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
//If the user guesses the number, display “You won"; otherwise, display “You lost".
//(To make sure the program is behaving correctly, you can display the secret number on the console first.)
namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine("Shush...\nThe Secret Number is {0}", number);
            Console.WriteLine("\n\n\n\nLets Beging the game \nYou have 4 chances to get it right");

            for (int i = 0; i < 4; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == number)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost");
                }
                if (i==3)
                {
                    Console.WriteLine("Game Over");
                }
            }
        }
    }
}
