using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Assignment2A
{
    class SelecationAndIteration
    {
        public SelecationAndIteration()//Constructor calling the different methods
        {
            Console.WriteLine();
            Console.WriteLine("My name is Patrik Österljung and I am a student of the VT21 semester");
            Console.WriteLine();

            ShowStringLength(); // Calls the string length method
            Console.WriteLine();

            MakeMyDay(); // Calls the make my day method
            Console.WriteLine();

            SumNumbers(); // Calls the sum numbers method
            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu!");
            Console.ReadKey();

        }

        #region String Length
        private void ShowStringLength()
        {
            Console.WriteLine("Let me calculate the length of strings for you.");
            Console.WriteLine("Give me a text of any lenght and press enter,\nor just enter to exit");
            bool done = false;
            do
            {
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))//checks if string is empty, condition for ending loop.
                {
                    Console.WriteLine("You pressed enter, let's make your day!");
                    done = true;
                }
                else//any other string
                {
                    string strOutput = input.ToUpper();//Make all characters capital
                    //Creates a new string with no white spaces, to let user know how many actual letters a sentence has
                    string inputTrimmed = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
                    Console.WriteLine();
                    Console.WriteLine(strOutput);//Writes out input string in capital letters
                    Console.WriteLine($"Number of chars (including whitespace) = {input.Length}.");//length (number of chars) including white space
                    Console.WriteLine($"Number of chars (excluding whitespace) = {inputTrimmed.Length}.");//same, with no white space
                    Console.WriteLine();
                }
            } while (!done);

        }
        #endregion

        #region Make my day
        private void MakeMyDay()
        {
            //The InputInt method only returns valid ints, checked with TryParse and if statement to guarantee desired range
            int choice = Input.InputInt("I can predict your day, choose a number between 1 and 7.", 1, 7);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monday: Keep calm! You can fall apart!");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case 4:
                    Console.WriteLine("Thursday, Uuush, still one day to Friday!");
                    break;
                case 5:
                    Console.WriteLine("It's Friday! You are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
            }
        }
        #endregion

        #region Sum of Numbers
        private void SumNumbers()
        {
            int inputStart = Input.InputInt("Give me a starting number: ");
            int inputEnd = Input.InputInt("Give me an end number: ");// Both lines gets valid int
            int start;//where the loop will start, variable to hold possible flip of values
            int end;//  where the loop will end,   same as above
            int sum = 0;
            if(inputStart > inputEnd)//check if inputStart is higher than inputEnd
            {
                start = inputEnd;//flip the values
                end = inputStart;//flip the values
            }
            else// if instuctions are followed and inputStart is lower
            {
                start = inputStart;//assign values
                end = inputEnd;
            }
            
            for(int i = start; i < end+1; i++)//sets i to value of start
            {// end+1 is to include the value of end in the caltulation
             //could be done with <= but I have been taught that < and +1 is the way to go.
                sum += i;
            }
            Console.WriteLine();//blank line before printing start, end and sum of calcualtion.
            Console.WriteLine($"The sum of numbers between {start} and {end} is {sum}.");
        }
        #endregion
    }
}
