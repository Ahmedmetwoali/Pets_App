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
    class Animal
    {
        private String name;
        private int startingHungerLevel;
        private int maxHungerlevel;
        private int startingHappinessLevel;
        private int maxHappinessLevel;
        private String foodType;
        private String interactionType;
        private int currentHungerLevel;
        private int currentHappinessLevel;
        private bool isExhausted = false;
        private String animalType;
        private List<String> likedFood;
        private List<String> likedInteraction;

        public Animal(String name) { this.name = name; }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int StartingHungerLevel
        {
            get { return startingHungerLevel; }
            set { startingHungerLevel = value; }
        }
        public int MaxHungerlevel
        {
            get { return maxHungerlevel; }
            set { this.maxHungerlevel = value; }
        }
        public int StartingHappinessLevel
        {
            get { return startingHappinessLevel; }
            set { startingHappinessLevel = value; }
        }
        public int MaxHappinessLevel
        {
            get { return maxHappinessLevel; }
            set { maxHappinessLevel = value; }
        }
        public String FoodType
        {
            get { return foodType; }
            set { foodType = value; }
        }
        public String Interactiontype
        {
            get { return interactionType; }
            set { interactionType = value; }
        }
        public int CurrentHungerLevel
        {
            get { return currentHungerLevel; }
            set { currentHungerLevel = value; }
        }
        public int CurrentHappinessLevel
        {
            get { return currentHappinessLevel; }
            set { currentHappinessLevel = value; }
        }
        public bool IsExhausted
        {
            get { return isExhausted; }
            set { isExhausted = value; }
        }
        public String AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public List<String> LikedFood
        {
            get { return likedFood; }
            set { likedFood = value; }
        }

        public List<String> LikedInteraction
        {
            get { return likedInteraction; }
            set { likedInteraction = value; }
        }

        
    } 
}
