using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Console
    {

        public void RunGame()
        {
            this.DisplayWelcome();
            this.StartGame();

        }
        public void DisplayWelcome()
        {
            System.Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            System.Console.WriteLine("Do you want to play someone or Computer? Enter human or computer");
        }

        public void StartGame()
        {
           
            string gameMode= System.Console.ReadLine();

            if (gameMode == "human")
            {
                this.TwoPlayerGameMode();
            }
            else if (gameMode == "computer")
            {
                this.HumanVsAIGameMode();
            }
            else
            {
                this.StartGame();
            }

        }

        public void HumanVsAIGameMode()
        {
            string playerOneName = System.Console.ReadLine();
            Human playerOne = new(playerOneName);
            AI robot = new();
        }

        public void TwoPlayerGameMode()
        {
           
            string playerOneName = System.Console.ReadLine();
            Human playerOne = new (playerOneName);
            string playerTwoName = System.Console.ReadLine();
            Human playerTwo = new (playerTwoName);

            int playerOneScore = 0;
            int playerTwoScore = 0;

            while (playerOneScore == 0 || playerTwoScore == 0)
            {
                string playerOneTurn= playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

            }
        }

        public string GestureFilter(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == "rock" && playerTwoGesture == "scissors")
            {
                Console.WriteLine("Player One beats Player Two");
            }
        else if (playerOneGesture == "scissors" && playerTwoGesture == "paper")
             {
                Console.WriteLine("Player One beats Player Two")
             }
        else if (playerOneGesture == "paper" && playerTwoGesture == "rock")
             Console.WriteLine("Player One beats Player Two")
             return playerOneGesture
        else if playerOneGesture == "rock" && playerTwoGesture== "lizard":
            Console.WriteLine("Player One beats Player Two")
            return playerOneGesture
        else if playerOneGesture == "lizard" && playerTwoGesture== "spock":
            Console.WriteLine("Player One beats Player Two")
            return playerOneGesture
        else if playerOneGesture == "spock" && playerTwoGesture== "scissors":
            Console.WriteLine("Player One beats Player Two")
            return playerOneGesture
        else if playerOneGesture == "scissors" && playerTwoGesture== "lizard":
            Console.WriteLine("Player One beats Player Two")
            return playerOneGesture
        else if playerOneGesture == "lizard" && playerTwoGesture== "paper":
            Console.WriteLine("Player One beats Player Two")
            return playerOneGesture
        else if playerOneGesture == "paper" && playerTwoGesture== "spock":
            Console.WriteLine("Player One beats Player Two")
            return playerOneGesture
        else if playerOneGesture == "spock" && playerTwoGesture== "rock":
            Console.WriteLine("Player One beats Player Two")
            return playerOneGesture
        else if playerTwoGesture == "rock" && playerOneGesture == "scissors":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "scissors" && playerOneGesture== "paper":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "paper" && playerOneGesture== "rock":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "rock" && playerOneGesture== "lizard":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "lizard" && playerOneGesture== "spock":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "spock" && playerOneGesture== "scissors":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "scissors" && playerOneGesture== "lizard":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "lizard" && playerOneGesture== "paper":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "paper" && playerOneGesture== "spock":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else if playerTwoGesture == "spock" && playerOneGesture== "rock":
            Console.WriteLine(f"{playerTwoGesture} beats {playerOneGesture}")
            return playerTwoGesture
        else:
            Console.WriteLine(f"Its a draw! You both choose {playerOneGesture}")
        }
    }
}
