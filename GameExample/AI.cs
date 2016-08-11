using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class AI : Player
    {
        List<string> choices = new List<string>() { "Rock", "Paper", "Scissors"};
        public void SetName()
        {
            this.name = "Computer";
        }
        public override string GetChoice()
        {
            Random r = new Random();
            r.Next(0, choices.Count);
            string choice = choices[r.Next(0, choices.Count)];
            return choice;
        }
     
    }
}
