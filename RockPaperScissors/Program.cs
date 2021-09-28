using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            int userWin = 0;
            int computerWin = 0;
            while (game)
            {
                
                Console.WriteLine("Rock, Paper, Scissors\n" +
                    "Please use a number to select your choice\n" +
                    "1.Rock\n" +
                    "2.Paper\n" +
                    "3.Scissors\n" +
                    "4.Lizard\n" +
                    "5.Spock\n" +
                    "6.Exit Game\n");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int computerChoice = rnd.Next(1, 4);
                Console.Clear();
                if (userChoice == 4)
                {
                    game = false;
                }
                //lizard poisons Spock
                //rock crushes lizard
                //spock smashes scissors
                //scissors decapitate lizard
                //lizard eats paper
                //paper disproves Spock
                //Spock vaporizes rock
                switch (computerChoice)
                {
                    case 1:
                        //If the computer chooses 1 
                        if(userChoice == 1)
                        {
                            Console.WriteLine("\nUser chose rock\n" +
                                "computer chose rock\n" +
                                "You tied!");
                        }
                        else if(userChoice == 2)
                        {
                            Console.WriteLine("\nUser chose paper\n" +
                                "computer chose rock\n" +
                                "Paper beat Rock: YOU WIN!");
                            userWin++;
                        }
                        else if(userChoice == 3)
                        {
                            Console.WriteLine("\nUser chose scissors\n" +
                                "computer chose rock\n" +
                                "Rock beats scissors: Sorry... You lose :(( ");
                            computerWin++;
                        }
                        Console.WriteLine("\n\nUser score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    case 2:
                        //If the computer chooses 2
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nUser chose rock\n" +
                                "computer chose paper\n" +
                                "Paper beats rock: Sorry... You lose :(( ");
                            computerWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nUser chose paper\n" +
                                "computer chose paper\n" +
                                "You tied!");
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nUser chose scissors\n" +
                                "computer chose paper\n" +
                                "Scissor beats paper: YOU WIN!");
                            userWin++;
                        }
                        Console.WriteLine("\n\nUser score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    case 3:
                        //If the computer chooses 3
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nUser chose rock\n" +
                                "computer chose scissors\n" +
                                "Rock beats scissors: YOU WIN!");
                            userWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nUser chose paper\n" +
                                "computer chose scissors\n" +
                                "Scissor beats paper: Sorry... You lose :(( ");
                            computerWin++;
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nUser chose scissors\n" +
                                "computer chose scissors\n" +
                                "You tied!");
                        }
                        Console.WriteLine("\n\nUser score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin+ "\n\n");
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
