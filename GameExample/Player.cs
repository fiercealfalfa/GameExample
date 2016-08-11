using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Player
    {
        protected string name;
        protected int score; 

        public Player()
        {
            this.score = 0;
        }
        public int GetScore()
        {
            return this.score; 
        }
        public void AddOneToScore()
        {
            this.score += 1;
        }
        public virtual string GetName()
        {
            return this.name;
        }
        public virtual string GetChoice()
        {
            string choice = "";
            return choice;
        }

    }
}
