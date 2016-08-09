using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Player
    {
        string name;
        int score; 

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }
        public int getScore()
        {
            return this.score; 
        }
        public void addOneToScore()
        {
            this.score += 1;
        }
        public string getName()
        {
            return this.name;
        }
        public void changeName(string name)
        {
            this.name = name;
        }
    }
}
