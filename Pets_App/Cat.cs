/*
Author: Ahmed Metwoali
Date: 02/07/2022 - 02/08/2022
Purpose: Castle Hill Gaming Programming Test
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets_App
{

    class Cat : Animal
    {
        public Cat(String name) : base(name)
        {
            AnimalType = "CAT";
            StartingHappinessLevel = 4;
            MaxHappinessLevel = 5;
            StartingHungerLevel = 2;
            MaxHungerlevel = 8;
            CurrentHappinessLevel = StartingHappinessLevel;
            CurrentHungerLevel = StartingHungerLevel;
            LikedFood = getCatLikedFood();
            LikedInteraction = getCatLikedInteraction();
        }

        private static List<String> CatLikedInteraction = new List<String> { "Pet", "Ignore", "Scold" };
        private static List<String> CatLikedFood = new List<String> { "Tuna", "Dry Cat Food" };

        public static List<String> getCatLikedInteraction() { return CatLikedInteraction; }
        public static List<String> getCatLikedFood() { return CatLikedFood; }

        public void feed(Cat c)
        {

            if (c.LikedFood.Contains(c.FoodType) == false)
            {
                c.CurrentHungerLevel += 2;
                c.CurrentHappinessLevel -= 2;
            }
            else if (c.FoodType == "Tuna")
            {
                c.CurrentHungerLevel = 0;
                c.CurrentHappinessLevel += 3;
            }
            else if (c.FoodType == "Dry Cat Food")
            {
                c.CurrentHungerLevel = c.CurrentHungerLevel/2;
                c.CurrentHappinessLevel += 1;
            }

        }

        public void interact(Cat c)
        {

            if (c.LikedInteraction.Contains(c.Interactiontype) == false)
            {
                c.CurrentHungerLevel += 2;
                c.CurrentHappinessLevel -= 2;
            }
            else if (c.Interactiontype == "Pet")
            {
                Random rand = new Random();
                int randNum = rand.Next(0, 10); //returns random number between 0-9
                c.CurrentHungerLevel += 1;
                c.CurrentHappinessLevel += 1;
                if (randNum == 7)   // The number 7 will be the number the cat will dislike this interaction.
                {
                    c.CurrentHungerLevel += 2;
                    c.CurrentHappinessLevel -= 2;
                }
            }
            else if (c.Interactiontype == "Ignore")
            {
                c.CurrentHungerLevel += 1;
                c.CurrentHappinessLevel += 2;
            }
            else if (c.Interactiontype == "Scold")
            {
                c.CurrentHungerLevel += 2;
                c.CurrentHappinessLevel -= 2;
            }
        }
    }
}
