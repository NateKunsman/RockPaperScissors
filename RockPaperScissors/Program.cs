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
            string youWin = String.Format("____    ____  ______    __    __     ____    __    ____  __  .__   __.\n" +
                @"\   \  /   / /  __  \  |  |  |  |    \   \  /  \  /   / |  | |  \ |  |" + "\n" +
                @" \   \/   / |  |  |  | |  |  |  |     \   \/    \/   /  |  | |   \|  |" + "\n" +
                @"  \_    _/  |  |  |  | |  |  |  |      \            /   |  | |  . `  |" + "\n" +
                @"    |  |    |  `--'  | |  `--'  |       \    /\    /    |  | |  |\   |" + "\n" +
                @"    |__|     \______/   \______/         \__/  \__/     |__| |__| \__|" , ConsoleColor.Green);
            string youLose = String.Format("____    ____  ______    __    __      __        ______        _______. _______ \n" +
                @"\   \  /   / /  __  \  |  |  |  |    |  |      /  __  \      /       ||   ____|" + "\n" +
                @" \   \/   / |  |  |  | |  |  |  |    |  |     |  |  |  |    |   (----`|  |__   " + "\n" +
                @"  \_    _/  |  |  |  | |  |  |  |    |  |     |  |  |  |     \   \    |   __|  " + "\n" +
                @"    |  |    |  `--'  | |  `--'  |    |  `----.|  `--'  | .----)   |   |  |____ " + "\n" +
                @"    |__|     \______/   \______/     |_______| \______/  |_______/    |_______|" , ConsoleColor.Red);
            string tie = String.Format
                ("         |&|    __" + "\n" +
                "         | |   /&/" + "\n" +
                "         |&|  /&/" + "\n" +
                "        _|_|_|_|_ " + "\n" +
                @"       / _______ \" + "\n" +
                @"       \ |&| |&| /" + "\n" +
                @"        \| | | |/" + "\n" +
                @"         /&/ \&\" + "\n" +
                @"        / /| |\ \" + "\n" +
                @"       /&/ |_| \&\" + "\n" +
                @"       \_| |&| |_/" + "\n" +
                @"         | | | |" + "\n" +
                @"         | |  \ \" + "\n" +
                @"         | |   \_\" + "\n" +
                "         | |");
            bool game = true;
            int userWin = 0;
            int computerWin = 0;
            while (game)
            {
                
                Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock\n"+
                    "Rules:\n" +
                    "Scissors cut paper. Paper covers rock. Rock crushes lizard.\n" +
                    "Lizard poisons Spock. Spock smashes scissors. Scissors\n " +
                    "decapitates lizard. Lizard eats paper. Paper disproves Spock.\n " +
                    "Spock vaporizes rock. Rock crushes scissors.\n\n" +
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
                            Console.WriteLine("\nYou chose rock\n" +
                                "computer chose rock\n" +
                                "You tied!");
                            Console.WriteLine(tie);
                        }
                        else if(userChoice == 2)
                        {
                            Console.WriteLine("\nYou chose paper\n" +
                                "computer chose rock\n" +
                                "Paper beat Rock");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if(userChoice == 3)
                        {
                            Console.WriteLine("\nYou chose scissors\n" +
                                "computer chose rock\n" +
                                "Rock smashes scissors");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if(userChoice == 4)
                        {
                            Console.WriteLine("\nYou chose lizard\n" +
                                "computer chose rock\n" +
                                "Rock crushes lizard");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if(userChoice == 5)
                        {
                            Console.WriteLine("\nYou chose spock\n" +
                                "computer chose rock\n" +
                                "Spock vaporizes rock");
                            Console.WriteLine(youWin);
                            userWin++;
                        }

                        Console.WriteLine("\n\nYour score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    case 2:
                        //If the computer chooses 2
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nYou chose rock\n" +
                                "computer chose paper\n" +
                                "Paper beats rock");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nYou chose paper\n" +
                                "computer chose paper\n" +
                                "You tied!");
                            Console.WriteLine(tie);
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nYou chose scissors\n" +
                                "computer chose paper\n" +
                                "Scissor beats paper");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nYou chose lizard\n" +
                                "computer chose paper\n" +
                                "Lizard eats paper");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nYou chose spock\n" +
                                "computer chose paper\n" +
                                "Paper disproves Spock");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        Console.WriteLine("\n\nYour score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    case 3:
                        //If the computer chooses 3
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nYou chose rock\n" +
                                "computer chose scissors\n" +
                                "Rock beats scissors");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nYou chose paper\n" +
                                "computer chose scissors\n" +
                                "Scissor beats paper");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nYou chose scissors\n" +
                                "computer chose scissors\n" +
                                "You tied!");
                            Console.WriteLine(tie);
                        }
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nYou chose lizard\n" +
                                "computer chose scissors\n" +
                                "scissors decapitate lizard");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nYou chose spock\n" +
                                "computer chose scissors\n" +
                                "spock smashes scissors");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        Console.WriteLine("\n\nYour score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin+ "\n\n");
                        break;
                    case 4:
                        //If the computer chooses 4
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nYou chose rock\n" +
                                "computer chose lizard\n" +
                                "Rock crushes lizard");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nYou chose paper\n" +
                                "computer chose lizard\n" +
                                "Lizard eats paper");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nYou chose scissors\n" +
                                "computer chose lizard\n" +
                                "Scissors decapitate lizard");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nYou chose lizard\n" +
                                "computer chose lizard\n" +
                                "You tied!");
                            Console.WriteLine(tie);
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nYou chose spock\n" +
                                "computer chose lizard\n" +
                                "Lizard poisons Spock");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        Console.WriteLine("\n\nYour score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    case 5:
                        //If the computer chooses 5
                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nYou chose rock\n" +
                                "computer chose spock\n" +
                                "Spock vaporizes rock");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nYou chose paper\n" +
                                "computer chose spock\n" +
                                "Paper disproves Spock");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nYou chose scissors\n" +
                                "computer chose spock\n" +
                                "Spock smashes scissors");
                            Console.WriteLine(youLose);
                            computerWin++;
                        }
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("\nYou chose lizard\n" +
                                "computer chose spock\n" +
                                "Lizard poisons spock");
                            Console.WriteLine(youWin);
                            userWin++;
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("\nYou chose spock\n" +
                                "computer chose spock\n" +
                                "You tied!");
                            Console.WriteLine(tie);
                        }
                        Console.WriteLine("\n\nYour score is " + userWin);
                        Console.WriteLine("Computer score is " + computerWin + "\n\n");
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
