using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
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
                string playerOneTurn= Player.ChooseGesture;
                Player.ChooseGesture;

            }
        }

        public string GestureFilter(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == "rock" && playerTwoGesture == "scissors")
            {
                Game.WriteLine("Player One beats Player Two");
                return playerOneScore++;
            }
            else if (playerOneGesture == "scissors" && playerTwoGesture == "paper")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "paper" && playerTwoGesture == "rock")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "rock" && playerTwoGesture == "lizard")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "lizard" && playerTwoGesture == "spock")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "spock" && playerTwoGesture == "scissors")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "scissors" && playerTwoGesture == "lizard")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "lizard" && playerTwoGesture == "paper")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "paper" && playerTwoGesture == "spock")
            {
                Game.WriteLine("Player One beats Player Two");
            }
            else if (playerOneGesture == "spock" && playerTwoGesture == "rock")
            {
                Game.WriteLine("Player One beats Player Two");
            }

            else if (playerTwoGesture == "rock" && playerOneGesture == "scissors")
            {
                Game.WriteLine("Player Two Beats Player One");
            }

            else if (playerTwoGesture == "scissors" && playerOneGesture == "paper")
            {
                Game.WriteLine("Player Two Beats Player One");
            }

            else if (playerTwoGesture == "paper" && playerOneGesture == "rock")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else if (playerTwoGesture == "rock" && playerOneGesture == "lizard")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else if (playerTwoGesture == "lizard" && playerOneGesture == "spock")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else if (playerTwoGesture == "spock" && playerOneGesture == "scissors")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else if (playerTwoGesture == "scissors" && playerOneGesture == "lizard")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else if (playerTwoGesture == "lizard" && playerOneGesture == "paper")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else if (playerTwoGesture == "paper" && playerOneGesture == "spock")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else if (playerTwoGesture == "spock" && playerOneGesture == "rock")
            {
                Game.WriteLine("Player Two Beats Player One");
            }
            else
            {
                Game.WriteLine("Its a draw! You both choose the same");
            }
        }
    }
}
