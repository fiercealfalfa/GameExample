using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Person
    {
        string name;
        string dateOfBirth;
        string gender;
        int arms;
        int legs;
        float xCoordinate;
        float yCoordinate;
        List<string> favoriteFoods = new List<string>(); 


        public void Breathe()
        {
            Console.WriteLine("Mmmmm gas exchange");
        }
        public void walk()
        {
            bool ableToWalk = checkWalkingAbility();
            if (ableToWalk)
            {
                Console.WriteLine("Walking is awesome");
            
            }
            else if (!ableToWalk)
            {
                Console.WriteLine("You ain't got no legs Lt. Dan");
            }
        }
        public void AddFavoriteFood()
        {
            Console.WriteLine("What is a foood you would like to add");
            favoriteFoods.Add(Console.ReadLine());
        }
        public void PopulateFavoriteFood()
        {
            
        }
        public void setName()
        {
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();
        }
        public string getName()
        {
            return name;
        }
        private bool checkWalkingAbility()
        {
           if(legs >= 2)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
