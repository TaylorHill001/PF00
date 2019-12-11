using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish var's
            string inputUser, inputCPU;

            int randomInt;

            bool playAgain = true;


            //Welcome and receive a name for the player
            Console.WriteLine("Hey user, whats your name?");
            string userName = Console.ReadLine();
            // this if loop initiates the game
            if (playAgain == false){
                Console.WriteLine("its false");
            }
            //this while loop continues the game
            while (playAgain == true)
            {
                int userScore = 0;
                int cpuScore = 0;
                

                // this while loop ends the game when one reaches a score of three
                while (userScore < 3 && cpuScore < 3)
                {


                    //here we have the player initate a round
                    Console.WriteLine(userName + " choose Rock, Paper, or Scissors");
                    inputUser = Console.ReadLine().ToLower();

                    //we use rnd to have the pc choose a num
                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);


                    //we use switch to assign the rnd num to rock paper scisors and to determin who wins
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("Computer chose rock");
                            if (inputUser == "rock")
                            {
                                Console.WriteLine("its a draw!\n\n");
                            }
                            else if (inputUser == "paper")
                            {
                                Console.WriteLine("You Win!\n\n");
                                userScore++;
                            }
                            else if (inputUser == "scissors")
                            {
                                Console.WriteLine("You Lose!\n\n");
                                cpuScore++;
                            }
                            else
                            {
                                Console.WriteLine("You no choose right thing");
                            }
                            break;
                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("Computer chose paper");
                            if (inputUser == "rock")
                            {
                                Console.WriteLine("You Lose!\n\n");
                                cpuScore++;
                            }
                            else if (inputUser == "paper")
                            {
                                Console.WriteLine("Its a Draw!\n\n");
                                                            }
                            else if (inputUser == "scissors")
                            {
                                Console.WriteLine("You Win!\n\n");
                                userScore++;
                            }
                            else
                            {
                                Console.WriteLine("You no choose right thing");
                            }
                            break;

                        case 3:
                            inputCPU = "scissors";
                            Console.WriteLine("Computer chose scissors");
                            if (inputUser == "rock")
                            {
                                Console.WriteLine("You Win!\n\n");
                                userScore++;
                            }
                            else if (inputUser == "paper")
                            {
                                Console.WriteLine("You Lose!\n\n");
                                cpuScore++;
                            }
                            else if (inputUser == "scissors")
                            {
                                Console.WriteLine("Its a Draw!\n\n");
                            }
                            else
                            {
                                Console.WriteLine("You no choose right thing");
                            }
                            break;
                        default:
                            break;

                    }
                    Console.WriteLine("user " + userScore + " cpu " + cpuScore);

                    if (userScore == 3)
                    {
                        Console.WriteLine(userName + " has won the tourny!");
                    }
                    else if (cpuScore == 3)
                    {
                        Console.WriteLine("CPU beat you!");
                    }
                    else
                    {
                      
                    }
                    /*
                    Console.WriteLine("Do you want to play again? [y/n]");

                    string loopMe = Console.ReadLine().ToLower();
                    if (loopMe == "y")
                    {
                        playAgain = true;
                    }
                    else if (loopMe == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {

                    }
                    */
                }
                Console.WriteLine("Do you want to play again? [y/n]");

                string loopMe = Console.ReadLine().ToLower();
                if (loopMe == "y")
                {
                    playAgain = true;
                }
                else if (loopMe == "n")
                {
                    playAgain = false;
                }
                else
                {
                    playAgain = false;

                }
            }







        }
    }
}
