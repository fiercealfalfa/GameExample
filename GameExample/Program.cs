using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //There is a lot of example code in here. Player, Human, and AI are examples of inheritance. 
            Game game = new Game();
            game.RunGame();
            Console.WriteLine("Game over man, Game Over!!");
            Console.ReadLine();
            //Person person = new Person();

        }
    }
}
