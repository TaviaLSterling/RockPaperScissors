using System;
using System.Collections.Generic;
// using rockGame.Models;

namespace rockGame
{
    class Program
    {
        static void Main(string[] args)
        {
             bool playing = true;
            List<string> choices = new List<string>();
            choices.Add("rock");
            choices.Add("paper");
            choices.Add("scissors");
            while(playing){
                Console.Clear();
                Console.WriteLine("Choose rock, paper, or scissors");
                string pick = Console.ReadLine();
                Console.WriteLine("You picked " + pick);
                 Random choice = new Random();
                 int computer = choice.Next(0,3);

                 if (computer == 0)
                {
                    if (pick == "rock")
                    {
                        Console.WriteLine("The computer picked rock");
                        Console.WriteLine("tie ");                     
                    }
                    else if (pick == "paper")
                    {
                        Console.WriteLine("The computer picked paper");
                        Console.WriteLine("tie ");

                    }
                    else if (pick == "scissors")
                    {
                        Console.WriteLine("The computer picked scissors");
                        Console.WriteLine("tie ");
                    }
                    else
                    {
                        Console.WriteLine("Pick rock, paper, or scissors");

                    }

                }

                else if (computer == 1)
                {
                    if (pick == "rock")
                    {
                        Console.WriteLine("The computer picked paper");
                        Console.WriteLine("You Lose");

                    }
                    else if (pick == "paper")
                    {
                        Console.WriteLine("The computer picked scissors");
                        Console.WriteLine("You Lose ");

                    }
                    else if (pick == "scissors")
                    {
                        Console.WriteLine("The computer picked rock");
                        Console.WriteLine("You Lose");                       
                    }
                    else
                    {
                        Console.WriteLine("Pick rock, paper, or scissors");        
                    }
                }
                else if (computer == 2)
                {
                    if (pick == "rock")
                    {
                        Console.WriteLine("The computer picked scissors");
                        Console.WriteLine("You Win!");

                    }
                    else if (pick == "paper")
                    {
                        Console.WriteLine("The computer picked rock");
                        Console.WriteLine("You win!");

                    }
                    else if (pick == "scissors")
                    {
                        Console.WriteLine("The computer picked paper");
                        Console.WriteLine("You win!");

                    }
                    else
                    {
                        Console.WriteLine("Pick rock, paper, or scissors");

                    }

                }

            Console.WriteLine("Would you like to play again? (Y/N)");
             string response = Console.ReadLine();
            if(response.ToUpper() != "Y")
            {
                playing = false;
            }
        }
    }
}

            }
           