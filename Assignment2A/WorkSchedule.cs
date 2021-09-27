using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2A
{/// <summary>
/// This class displays a menu where user can choose to see either what weekends to work (every 3rd) or
/// which weeks to work nights (every 5th). I decided to use a forloop that increments by either 3 (for every 3rd)
/// or by 5 (for every 5th) This loop is in a method CalculateWeeks() that takes start week and week increment as arguments.
/// The ShowWeekends and ShowNights methods are technically not needed, as the cases could have called the CalculateWeeks()
/// directly using 1, 3 and 6, 5 as arguments respectivly, but I found this way to be more comprihensible.
/// I'm also fairly sure that I have used TryParse for all integer inputs in the entire assignment, as all
/// are done with the Input.InputInt() methods. I also know that it contains some parts that are not mentioned or
/// required, but I wanted to test some things that I thought would make the coding smoother, such as overloading the InputInt()
/// </summary>
    class WorkSchedule
    {
        public WorkSchedule()
        {
            Start();
        }

        #region
        private void Start()
        {
            int choice = -1;//invalid options to make loop start
            while(choice != 0)
            {
                Console.WriteLine();
                DisplayMenu();
                choice = Input.InputInt("Your choice: ", 0, 2);//same method again, gives valid int in desired range
                switch (choice)
                {
                    case 1://If user chooses to view weekends
                        ShowWeekends();//Mehtod that displays weekends to work
                        break;
                    case 2:
                        ShowNights();//Method that displays weeks to work nights
                        break;
                }
            }
        }

        private void DisplayMenu()
        {
            string menu = "Your Schedule Program";//Menu title
            Console.WriteLine();
            Menu.LineOfStars(50);//as seen before
            Console.WriteLine();
            Console.WriteLine($"{menu,30}");
            Console.WriteLine();
            Menu.LineOfStars(50);
            Console.WriteLine("1. Show weeks to work weekends");
            Console.WriteLine("2. Show weeks to work nights");
            Console.WriteLine("3. Return to Main Menu");
            Menu.LineOfStars(50);
        }
        #endregion

        #region Calculating and showing weeks

        private void ShowWeekends()
        {
            int start = 1;//Sets starting week to week 1
            int increment = 3;//Sets increment to 3, meaning it will display every 3rd week will be displayed (every 3rd value of i)
            CalculateWeeks(start, increment);
        }

        private void ShowNights()
        {
            int start = 6;//Sets starting week to week 6
            int increment = 5;//Sets increment to 5, meaning every 5th week will be displayed (every 5th value of i)
            CalculateWeeks(start, increment);
        }

        private void CalculateWeeks(int start, int increment)
        {//takes week to start and week increment as arguments and then calculates what weeks to work.
            
            int p = 0;//Used for writing columns, used for determining when to draw new line
            //The variable p is needed as the loop does not increment by 1, therefore using i (loopvariable)
            //Would not work as that value would not correspond to value needed to determine new line.
            
            int columns = 6;//Used for writing columns, determines the number of columns in the table
            
            for (int i = start; i < 53; i+= increment)
            {//starts loop at desired start value, <53 because 52 weeks/year and increases by desired increment
                
                string week = $"Week {i,2}";//Makes the week string aligned so numbers are always in the same position
                
                Console.Write($"{week,15}");//Prints week with sufficent space before next entry
                
                p++;//increases the determiner for when to make new line
                
                if((p % columns == 0) && (p >= columns))//should draw new line after 6 entries, as specified by columns varibale
                {//checks if p is divisible by columns and if p i larger, If so, makes a new line in table
                    Console.WriteLine();//starts a new line in table
                }

            }
        }
        #endregion
    }
}
