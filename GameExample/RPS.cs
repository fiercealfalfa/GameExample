using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class RPS
    {
        public RPS()
        {

        }
        public string getPlayerChoice()
        {
            Console.WriteLine("Please choose Rock, Paper, or Scissors");
            string playerChoice = Console.ReadLine();
            //call to function to validate user entry
            return playerChoice;
        }
        public void runTurn()
        {
            string playerOneChoice = getPlayerChoice();
            string playerTwoChoice = getPlayerChoice();
            determineWinner(playerOneChoice, playerTwoChoice);


        }
        public void determineWinner(string playerOneChoice, string playerTwoChoice)
        {
            //logic for winning or not.
        }
    }
}
