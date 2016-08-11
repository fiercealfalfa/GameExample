using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Turn
    {
        Player player;

        public Turn(Player player)
        {
            this.player = player;
        }
        public void TakeTurn()
        {
            Console.WriteLine("It is your turn {0}", player.GetName());
            string playerchoice = player.GetChoice();
            Console.WriteLine("Your Choice was {0}", playerchoice);
            player.AddOneToScore();
            player.AddOneToScore();
            Console.WriteLine("Your turn is over {0}, your score is {1}", player.GetName(), player.GetScore());
            Console.ReadKey();
        }
    }

}
