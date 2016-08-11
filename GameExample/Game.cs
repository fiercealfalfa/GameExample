using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        int round;
        int numberOfRounds;

        public Game()
        {
            this.numberOfRounds = 7;
            this.round = 1;
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to my awesome and totally fair game");
            SetUpPlayers();
            while (this.round < this.numberOfRounds)
            {
                Console.WriteLine("Welcome to Turn {0}", this.round);
                Console.WriteLine("It is your turn {0}", this.playerOne.GetName());
                Turn playerOneTurn = new Turn(this.playerOne);
                playerOneTurn.TakeTurn();
                Console.WriteLine("Good Job {0}", this.playerOne.GetName());
                Console.WriteLine("It is your turn {0}", this.playerTwo.GetName());
                Turn playerTwoTurn = new Turn(this.playerTwo);
                playerTwoTurn.TakeTurn();
                Console.WriteLine(("Good Job {0}"), this.playerTwo.GetName());
                this.round++;

            }

        }

        private void SetUpPlayers()
        {
            Console.WriteLine("How many human players would you like? 1 or 2");
            string numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers == "1")
            {
                playerOne = CreateHumanPlayer();
                playerTwo = CreateAIPlayer();
            }
            else if (numberOfPlayers == "2")
            {
                playerOne = CreateHumanPlayer();
                playerTwo = CreateHumanPlayer();
            }
            else
            {
                Console.WriteLine("Please pick either 1 or 2 players");
                SetUpPlayers();
            }
        }

        private Player CreateAIPlayer()
        {
            AI computerPlayer = new AI();
            computerPlayer.SetName();
            return computerPlayer;
        }

        private Human CreateHumanPlayer()
        {
            Human humanPlayer;
            humanPlayer = new Human();
            humanPlayer.SetName();
            return humanPlayer;

        }
    }
}
