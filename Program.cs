/* Program for calculating Scrabble word scores. Takes user input, converts to lowercase and checks against 
switch cases for letter values. Presents score to user, asks if another word score is desired otherwise exits.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleConsole
{
    class ScrabbleCalc
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("Welcome to the Scrabble Score Calculator! Please input your word:\n");
                string userInput = Console.ReadLine().ToLower();
                int scrabbleScore = 0;
                
                //for every letter in userInput, check against cases and increase score value
                foreach (char letter in userInput)
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
                            scrabbleScore += 1;
                            break;
                        case 'd':
                        case 'g':
                            scrabbleScore += 2;
                            break;
                        case 'b':
                        case 'c':
                        case 'm':
                        case 'p':
                            scrabbleScore += 3;
                            break;
                        case 'f':
                        case 'h':
                        case 'v':
                        case 'w':
                        case 'y':
                            scrabbleScore += 4;
                            break;
                        case 'k':
                            scrabbleScore += 5;
                            break;
                        case 'j':
                        case 'x':
                            scrabbleScore += 8;
                            break;
                        case 'q':
                        case 'z':
                            scrabbleScore += 10;
                            break;

                    }
                }
                Console.WriteLine("\nYour word is: " + userInput);
                Console.WriteLine("Your Scrabble score is: " + scrabbleScore);
                Console.WriteLine("\nWould you like to score another word? Y/N");
                answer = Console.ReadLine();
            } while (answer == "Y" || answer == "y");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
}
    }

