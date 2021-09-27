using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2A
{
    class TemperatureConverter
    {
        public TemperatureConverter()
        {
            Start();
        }
        #region Start
        private void Start()
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine();//Starts with a blank line to seperate from previous run
                DisplayMenu();
                choice = Input.InputInt("Your choice: ");

                switch (choice)
                {
                    case 1:
                        ShowCelsiusToFahrenheit();
                        break;
                    case 2:
                        ShowFahrenheitToCelsius();
                        break;
                }
            }
        }
        private void DisplayMenu()
        {
            string menu = "Teperature Converter Menu";
            Menu.LineOfStars(50);//Draws a line of * to make the menu look neat
            Console.WriteLine();
            Console.WriteLine($"{menu,38}");//Writes menu title aligned to be in centre
            Console.WriteLine();
            Menu.LineOfStars(50);
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.WriteLine("0. Return to Main Menu");
            Console.WriteLine();
            Menu.LineOfStars(50);
        }
        #endregion

        #region Conversion and tables
        private void ShowCelsiusToFahrenheit()//Displays a table of degrees in C and what that is in F
        {
            Console.WriteLine();
            const int max = 100;//maximum value to display
            for(double i = 0; i < max+1; i += 5)//increment of 5, max+1 to include max value as well
            {
                double celsius = i;// Not really necessary, just makes it very clear what is going on
                double fahrenheit = ConvertToFahrenheit(i);//Converts value of i (celsius) to degrees F
                Console.WriteLine($"{celsius,6:f2} C = {fahrenheit,6:f2} F");
                //the above line writes degrees in C with two decimal as well as converted degrees in F
                //also with 2 decimals
            }
        }

        private void ShowFahrenheitToCelsius()//Works exactly the same as ShowCelsiusToFahrenheit, but reversed
        {
            Console.WriteLine();
            const int max = 212;
            for (double i = 0; i < max + 1; i += 10)//Increment of 10 instad of 5
            {
                double fahrenheit = i;
                double celsius = ConvertToCelsius(i);//Same principle but reversed
                Console.WriteLine($"{fahrenheit,16:f2} C = {celsius,6:f2} F");
            }
        }

        private double ConvertToFahrenheit(double celsius)
        {//Calcualtion converting celsius to fahrenheit
            double fahrenheit = 9.0 / 5.0 * celsius + 32;
            return fahrenheit;
        }

        private double ConvertToCelsius(double fahrenheit)
        {//Calculation converting fahrenheit to celsius
            double celsius = 5.0 / 9.0 * (fahrenheit - 32);
            return celsius;
        }
    }
    #endregion
}
