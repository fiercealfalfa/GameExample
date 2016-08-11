using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Human : Player
    {
        public void SetName()
        {
            Console.WriteLine("Please enter new name");
            this.name = Console.ReadLine();
        }
        public override string GetChoice()
        {
            Console.WriteLine("Please choose Rock, Paper, or Scissors");
            string choice;
            choice = Console.ReadLine().ToLower();
            return choice;
        }
      
    }
}
