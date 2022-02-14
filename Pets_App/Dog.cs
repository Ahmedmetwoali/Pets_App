/*
Author: Ahmed Metwoali
Date: 02/07/2022 - 02/08/2022
Purpose: Castle Hill Gaming Programming Test
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace Pets_App
{
    class Dog : Animal
    {
        
        public Dog(String name) : base(name)
        {
            AnimalType = "DOG";
            StartingHappinessLevel = 5;
            MaxHappinessLevel = 10;
            StartingHungerLevel = 2;
            MaxHungerlevel = 10;
            CurrentHappinessLevel = StartingHappinessLevel;
            CurrentHungerLevel = StartingHungerLevel;
            LikedFood = getDogLikedFood();
            LikedInteraction = getDogLikedInteraction();
        }
        private static List<String> DogLikedInteraction = new List<String> { "Rub Belly", "Play", "Scold" };
        private static List<String> DogLikedFood = new List<String> { "Bacon Snack", "Dry Dog Food" };
        
        public static List<String> getDogLikedInteraction() { return DogLikedInteraction; }
        public static List<String> getDogLikedFood() { return DogLikedFood; }


        public void feed(Dog d) 
        {

            if (d.LikedFood.Contains(d.FoodType) == false)
            {
                d.CurrentHungerLevel += 2;
                d.CurrentHappinessLevel -= 2;
            }
            else if (d.FoodType == "Bacon Snake") 
            {
                d.CurrentHungerLevel = d.CurrentHungerLevel / 2;
                d.CurrentHappinessLevel += 1;
            }
            else if (d.FoodType == "Dry Dog Food")
            {
                d.CurrentHungerLevel = 0;
                d.CurrentHappinessLevel += 1;
            }
        }
        
        public void interact(Dog d)
        {

            if (d.LikedInteraction.Contains(d.Interactiontype) == false)
            {
                d.CurrentHungerLevel += 2;
                d.CurrentHappinessLevel -= 2;
            }
            else if (d.Interactiontype == "Rub Belly")
            {
                d.CurrentHungerLevel +=1;
                d.CurrentHappinessLevel += 1;
            }
            else if (d.Interactiontype == "Play")
            {
                d.CurrentHungerLevel +=3;
                d.CurrentHappinessLevel += 2;
            }
            else if (d.Interactiontype == "Scold")
            {
                d.CurrentHungerLevel +=2;
                d.CurrentHappinessLevel -= 2;
            }
        }

    }
}
