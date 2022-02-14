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
    class Fish : Animal
    {
        public Fish(String name) : base(name)
        {
            AnimalType = "FISH";
            StartingHappinessLevel = 2;
            MaxHappinessLevel = 5;
            StartingHungerLevel = 2;
            MaxHungerlevel = 5;
            CurrentHappinessLevel = StartingHappinessLevel;
            CurrentHungerLevel = StartingHungerLevel;
            LikedFood = getFishLikedFood();
            LikedInteraction = getFishLikedInteraction();
        }

        private static List<String> FishLikedInteraction = new List<String> { "Play Music", "Talk To Them", "Tap On Glass" };
        private static List<String> FishLikedFood = new List<String> { "Fish Food" };

        public static List<String> getFishLikedInteraction() { return FishLikedInteraction; }
        public static List<String> getFishLikedFood() { return FishLikedFood; }

        public void feed(Fish f)
        {

            if (f.LikedFood.Contains(f.FoodType) == false)
            {
                f.CurrentHungerLevel += 2;
                f.CurrentHappinessLevel -= 2;
            }
            else if (f.FoodType == "Fish Food")
            {
                f.CurrentHungerLevel = 0;
                f.CurrentHappinessLevel += 1;
            }
        }

        public void interact(Fish f)
        {

            if (f.LikedInteraction.Contains(f.Interactiontype) == false)
            {
                f.CurrentHungerLevel += 2;
                f.CurrentHappinessLevel -= 2;
            }
            else if (f.Interactiontype == "Play Music")
            {
                f.CurrentHungerLevel += 1;
                f.CurrentHappinessLevel += 1;
            }
            else if (f.Interactiontype == "Talk To Them")
            {
                f.CurrentHungerLevel += 1;
                f.CurrentHappinessLevel += 1;
            }
            else if (f.Interactiontype == "Tap On Glass")
            {
                f.CurrentHungerLevel += 3;
                f.CurrentHappinessLevel -= 2;
            }
        }
    }
}
