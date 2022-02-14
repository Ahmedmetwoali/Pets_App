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
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pets_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dog dog = new Dog("royy");
        Cat cat = new Cat("Kitty");
        Store store = new Store();
        User user = new User();
        String newPetName;
        Timer timer = new System.Timers.Timer();

        public MainWindow()
        {
            InitializeComponent();
            foreach (Dog dog in store.getAnimalsList()[0])
            {
                AvailablePets_listbox.Items.Add(dog);
            }
            foreach (Cat cat in store.getAnimalsList()[1])
            {
                AvailablePets_listbox.Items.Add(cat);
            }
            foreach (Fish fish in store.getAnimalsList()[2])
            {
                AvailablePets_listbox.Items.Add(fish);
            }

            // Setting up Timer


            timer.Interval = 5000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        
        private void MainWindow_load(object sender, EventArgs e)
        {
          
            
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            //pets will lose -1 of happiness and gain +1 of hungriness every 20 seconds if not fed.
            //ssdwfwefwveewvc
            //a.CurrentHappinessLevel -= 1;
            //a.CurrentHungerLevel += 1;
            Console.WriteLine("Timer ending 20 second count");
        }
        private void btn_SaveName_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                newPetName = txt_petName.Text;

                while (txt_petName.Text == null || txt_petName.Text == "")
                {
                    MessageBox.Show("You must give your new pet a name!");
                    break;
                }
                //if (DogListbox.)
                user.setNewPetName((Animal)AvailablePets_listbox.SelectedItem, newPetName);
                txt_petName.Text = "";
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You must acquire a pet before naming it.");
            }


            
            
        }
        private void btn_Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (newPetName != null && newPetName != "")
            { 
                user.addToUsersPetCollection(AvailablePets_listbox.SelectedItem);
              
                
        

                //string stringPetCollection = string.Join(", ", user.getPetList());
            }
            else { MessageBox.Show("You must give your new pet a name!"); }
            foreach (Animal animal in user.getPetList())
            {
                UserPetsListbox.Items.Add(animal);
            }

        }

        private void btn_start_feeding_Click(object sender, RoutedEventArgs e)
        {
            lbl_available_food.Visibility = Visibility.Visible;
            comboBox_available_food.Visibility = Visibility.Visible;
            try
            {
                Animal a = (Animal)UserPetsListbox.SelectedItem;
                
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You must select a pet from your collection first.");
            }
            
        }

        private void btn_Feed_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Animal an = (Animal)UserPetsListbox.SelectedItem;
                an.FoodType = comboBox_available_food.Text;
                if (comboBox_available_food.Text == "")
                {
                    MessageBox.Show("Please select food type.");
                }
                else { 
                        if (an.AnimalType == "DOG")
                        {
                            Dog an_dog = (Dog)an;
                            an_dog.feed(an_dog);
                            txt_response.Text = "You have just gave " + an_dog.FoodType.ToLower() + " to your dog"; 
                           
                        }
                        else if (an.AnimalType == "CAT")
                        {
                            Cat an_cat = (Cat)an;
                            an_cat.feed(an_cat);
                            txt_response.Text = "You have just gave " + an_cat.FoodType.ToLower() + " to your cat";
                    }
                        else if (an.AnimalType == "FISH")
                        {
                            Fish an_fish = (Fish)an;
                            an_fish.feed(an_fish);
                        txt_response.Text = "You have just gave " + an_fish.FoodType.ToLower() + " to your fish";
                    }
                         
                    timer.Stop();
                    timer.Start();
                    }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You must select a pet from your collection first.");
            }
           
        }

        private void btn_Interact_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Animal an = (Animal)UserPetsListbox.SelectedItem;
                an.Interactiontype = comboBox_available_Interaction.Text;
                if (comboBox_available_Interaction.Text == "")
                {
                    MessageBox.Show("Please select interaction type.");
                }
                else if (an.CurrentHungerLevel > an.MaxHungerlevel || an.CurrentHappinessLevel <= 0)
                {
                    txt_response.Text = "" +
                        "your pet will NOT interact with you because he is exhausted \n You have to feed you pet to gain energy and intecact with you.";
                }
                else
                {
                    if (an.AnimalType == "DOG")
                    {
                        Dog an_dog = (Dog)an;
                        an_dog.interact(an_dog);
                        txt_response.Text = "You have just " + an_dog.Interactiontype.ToLower() + " your dog."; 
                    }
                        
                    else if (an.AnimalType == "CAT")
                    {
                        Cat an_cat = (Cat)an;
                        an_cat.interact(an_cat);
                        txt_response.Text = "You have just " + an_cat.Interactiontype.ToLower() + " your cat.";

                    }
                    else if (an.AnimalType == "FISH")
                    {
                        Fish an_fish = (Fish)an;
                        an_fish.interact(an_fish);
                        txt_response.Text = "You have just " + an_fish.Interactiontype.ToLower() + " your fish.";
                    }
                    
                    timer.Stop();
                    timer.Start();
                    
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You must select a pet from your collection first.");
            }
        }

      

        private void btn_start_interacting_pet_Click(object sender, RoutedEventArgs e)
        {
            lbl_available_Interaction.Visibility = Visibility.Visible;
            comboBox_available_Interaction.Visibility = Visibility.Visible;
        }

        private void btn_current_state_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Animal an = (Animal)UserPetsListbox.SelectedItem;
            lbl_selected_pet_name_VALUE.Content = an.Name;
            lbl_happiness_status_VALUE.Content = an.CurrentHappinessLevel;
            lbl_hungerness_status_VALUE.Content = an.CurrentHungerLevel;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You must select a pet from your collection to check the status.");
            }
        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Animal a = (Animal)UserPetsListbox.SelectedItem;
                user.removeFromUsersPetCollection(a);
                UserPetsListbox.Items.Remove(a);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please select the pet you want to delete.");
            }
        }
    }
}

