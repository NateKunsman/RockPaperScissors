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
                
                Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock\n" +
                    "Please use a number to select your choice\n" +
                    "1.Rock\n" +
                    "2.Paper\n" +
                    "3.Scissors\n" +
                    "4.Lizard\n" +
                    "5.Spock\n" +
                    "6.Exit Game\n");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int computerChoice = rnd.Next(1, 6);
                Console.Clear();
                if (userChoice == 6)
                {
                    game = false;
                }
                //Rock crushes scissors
                //Paper covers rock
                //Scissor cuts paper
                //Lizard poisons Spock
                //Rock crushes lizard
                //Spock smashes scissors
                //Scissors decapitate lizard
                //Lizard eats paper
                //Paper disproves Spock
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
                                "Rock smashes scissors: Sorry... You lose :(( ");
                            computerWin++;
                        }
                        else if(userChoice == 4)
                        {
                            Console.WriteLine("\nUser chose lizard\n" +
                                "computer chose rock\n" +
                                "Rock crushes lizard: Sorry... You lose :(( ");
                            computerWin++;
                        }
                        else if(userChoice == 5)
                        {
                            Console.WriteLine("\nUser chose spock\n" +
                                "computer chose rock\n" +
                                "Spock vaporizes rock: YOU WIN!");
                            userWin++;
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
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nUser chose lizard\n" +
                                "computer chose paper\n" +
                                "Lizard eats paper: YOU WIN!");
                            userWin++;
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nUser chose spock\n" +
                                "computer chose paper\n" +
                                "Paper disproves Spock: Sorry... You lose :((");
                            computerWin++;
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
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nUser chose lizard\n" +
                                "computer chose scissors\n" +
                                "scissors decapitate lizard: Sorry... You lose :(( ");
                            computerWin++;
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nUser chose spock\n" +
                                "computer chose scissors\n" +
                                "spock smashes scissors: YOU WIN!");
                            userWin++;
                        }
                        Console.WriteLine("\n\nUser score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin+ "\n\n");
                        break;
                    case 4:
                        //If the computer chooses 4
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nUser chose rock\n" +
                                "computer chose lizard\n" +
                                "Rock crushes lizard: YOU WIN!");
                            userWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nUser chose paper\n" +
                                "computer chose lizard\n" +
                                "Lizard eats paper: Sorry... You lose :(( ");
                            computerWin++;
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nUser chose scissors\n" +
                                "computer chose lizard\n" +
                                "Scissors decapitate lizard: YOU WIN!");
                            userWin++;
                        }
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nUser chose lizard\n" +
                                "computer chose lizard\n" +
                                "You tied!");
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nUser chose spock\n" +
                                "computer chose lizard\n" +
                                "Lizard poisons Spock: sorry... you lose :((");
                            computerWin++;
                        }
                        Console.WriteLine("\n\nUser score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    case 5:
                        //If the computer chooses 5
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nUser chose rock\n" +
                                "computer chose spock\n" +
                                "Spock vaporizes rock: Sorry you... You lose :((");
                            computerWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nUser chose paper\n" +
                                "computer chose spock\n" +
                                "Paper disproves Spock: YOU WIN! ");
                            userWin++;
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nUser chose scissors\n" +
                                "computer chose spock\n" +
                                "Spock smashes scissors: Sorry you... You lose :((");
                            computerWin++;
                        }
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nUser chose lizard\n" +
                                "computer chose spock\n" +
                                "Lizard poisons spock: YOU WIN!");
                            userWin++;
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nUser chose spock\n" +
                                "computer chose spock\n" +
                                "You tied!");
                        }
                        Console.WriteLine("\n\nUser score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
