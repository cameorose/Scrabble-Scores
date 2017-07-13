/// Program for calculating Scrabble word scores
/// as per the rules given by Hooroo Academy.
/// Author: Cameo Langford
/// Created on: 04/07/2017


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScrabbleConsole
{
    public class Scrabble
    {
        string word;
        int score;

        public Scrabble(string word)
        {
            this.word = word;
        }

        /// <summary>
        /// Validates user input to ensure only letters are entered
        /// Advises user if characters other than letters are entered
        /// </summary>
        /// <param name="word"></param>
        public void Validate(string word)
        {
            bool result = word.All(Char.IsLetter);
            if (result == true)
            {
                this.Calculate(word);
            }
            else
            {
                Console.WriteLine("Please input letters only.\n");
            }
        }

        /// <summary>
        /// Calculates user's scrabble score
        /// </summary>
        /// <param name="word"></param>
        public void Calculate(string word)
        {
            foreach (char letter in word)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'l':
                    case 'n':
                    case 'r':
                    case 's':
                    case 't':
                        score += 1;
                        break;
                    case 'd':
                    case 'g':
                        score += 2;
                        break;
                    case 'b':
                    case 'c':
                    case 'm':
                    case 'p':
                        score += 3;
                        break;
                    case 'f':
                    case 'h':
                    case 'v':
                    case 'w':
                    case 'y':
                        score += 4;
                        break;
                    case 'k':
                        score += 5;
                        break;
                    case 'j':
                    case 'x':
                        score += 8;
                        break;
                    case 'q':
                    case 'z':
                        score += 10;
                        break;

                }
            }

            Console.WriteLine("Your word is: " + word + "\nYour score is: " + score);
        }

        /// <summary>
        /// Main function
        /// -- Takes user input
        /// -- Runs Validate function against user input
        /// -- If valid input runs Calculate function
        /// -- Outputs user scrabble score
        /// -- Asks user if they want to calculate another score
        /// -- Loops until user exits
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Welcome to the Scrabble Score Calculator! Please input your word:\n");
                string word = Console.ReadLine().ToString();
                Scrabble scrabble = new Scrabble(word);
                scrabble.Validate(word);
                Console.WriteLine("\nWould you like to score another word? Y/N");
                answer = Console.ReadLine();
            }
            while ((answer == "y" || answer == "Y") ? true : (answer == "n" || answer == "N") ? false : true);
        }
    }
}
