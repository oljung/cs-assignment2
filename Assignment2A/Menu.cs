using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2A
{/// <summary>
/// This class runs the menu for the different tasks in Assignment 2. 
/// </summary>
    class Menu
    {
        public Menu()
        {
            Start();
        }
        
        private void Start()//Method that runs the menu
        {//Runs the main menu for selecting what "program" to run
            int choice;
            bool done = false;
            do
            {
                DisplayMenu();//To show what can be done in the program
                //Input method (overloaded) that checks for valid input, see Input.cs for more info
                choice = Input.InputInt("Your choice: ", 0, 3);
                switch (choice)//Runs selected class.
                {
                    case 0:
                        done = true;
                        break;
                    case 1:
                        SelecationAndIteration obj1 = new SelecationAndIteration();
                        break;
                    case 2:
                        TemperatureConverter obj2 = new TemperatureConverter();
                        break;
                    case 3:
                        WorkSchedule obj3 = new WorkSchedule();
                        break;
                }
            } while (!done);
        }

        private void DisplayMenu()//Contains the information on choices.
        {
            LineOfStars(50);
            Console.WriteLine("What program would you like to run?");
            Console.WriteLine("1. Selection and Iteration");
            Console.WriteLine("2. Temperature Converter");
            Console.WriteLine("3. Work Schedule");
            Console.WriteLine("0. Quit program");
            LineOfStars(50);
        }
        public static void LineOfStars(int length)//for loop to draw a line of stars (*)
        {//public to be usable in other classes with similar menus, static as to not require instanciating classobject
            for (int i = 0; i < length + 1; i++)//length+1 is to include max value, giving it the length the user entered
            {
                Console.Write("*");
                if (i == length)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
