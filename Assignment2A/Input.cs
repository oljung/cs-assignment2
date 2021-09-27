using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2A
{/// <summary>
/// Class Input.cs is used as a utility class, storing some useful input methods to save time.
/// The overloaded versoin of InputInt and the SetBool method are used for handling menu choices
/// and yes/no questions, other are simply shortcuts for getting valid values.
/// </summary>
    class Input
    {
        /// <summary>
        /// Input.cs
        /// 
        /// Created By: Patrik Österljung, 29 jan 2021
        /// Purpose: Shortcut for asking for string input and displaying information in the same method
        /// </summary>
        /// <param name="messageToUser">Used to inform the user on what type of input is required</param>
        /// <returns>String entered by user</returns>
        #region Input methods
        //This section contains inputmethods that should be used directly if used in other applications
        //than the ConsoleInput app
        public static string InputString(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            string output = Console.ReadLine();
            return output;
        }
        /// <summary>
        /// /// Input.cs
        /// 
        /// Created By: Patrik Österljung, 29 jan 2021
        /// Purpose: Shortcut for asking for char input and displaying information in the same method
        /// </summary>
        /// <param name="messageToUser">Used to inform the user on what type of input is required</param>
        /// <returns>Character inserted by the user</returns>
        public static char InputChar(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            bool valid = false;
            char output = 'x';
            do
            {
                string strTemp = Console.ReadLine();
                if (strTemp.Length == 1)
                {
                    output = strTemp[0];
                    valid = true;
                }
                else
                    Console.WriteLine("Invalid input, please write only one character");
            } while (!valid);
            return output;
        }
        /// <summary>
        ///  Created By: Patrik Österljung, 29 jan 2021
        ///  Purpose: Method for converting from string to int. If input is invalid ask for new input
        /// </summary>
        /// <param name="messageToUser">Used to give information on what type of input is required</param>
        /// <returns>Input value in correct data type</returns>
        public static int InputInt(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            bool valid;
            int output;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out output);
                if (!valid)
                    Console.WriteLine("Invalid input, please input integer only.");
            } while (!valid);
            return output;
        }
        /// <summary>
        /// Created By: Patrik Österljung, 29 jan 2021
        /// Purpose: Method for converting from string to int. If input is invalid ask for new input
        ///          Overloaded method mainly used for validating menu choices.
        /// </summary>
        /// <param name="messageToUser">Used to give information on what type of input is required</param>
        /// <param name="low">Lowest number to be accepted</param>
        /// <param name="high">Highest number to be accepted</param>
        /// <returns>Iput value converted to int</returns>
        public static int InputInt(string messageToUser, int low, int high)
        {
            Console.WriteLine(messageToUser);
            bool valid = false;
            int output;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out output);//checks if input is integer
                if (valid)//If integer checks if it whithin desired range
                {
                    if ((output >= low) && (output <= high))
                    {
                        valid = true;// All good
                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice");//Outside of desired range
                    }
                }
                if (!valid)
                    Console.WriteLine("Invalid input, please input integer only.");//Non an int
            } while (!valid);
            return output;
        }
            /// <summary>
            /// Created By: Patrik Österljung, 29 jan 2021
            /// Purpose:Method for converting from string to double. If input is invalid ask for new input
            /// </summary>
            /// <param name="messageToUser">Used to give user information on what input is required</param>
            /// <returns>Input value converted to double</returns>
        public static double InputDouble(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            bool valid;
            double output;
            do
            {
                valid = double.TryParse(Console.ReadLine(), out output);
                if (!valid)
                    Console.WriteLine("Invalid input, please input numbers only");
            } while (!valid);
            return output;
        }
        /// <summary>
        /// Created By: Patrik Österljung, 29 jan 2021
        /// Purpose:Method for converting a user input, y/n into a bool y= true, else false
        /// </summary>
        /// <param name="messageToUser">Used to ask user a yes or no question</param>
        /// <returns>Bool value true or false</returns>
        public static bool SetBool(string messageToUser)
        {//returns true if choice is 'y' or 'Y' else returns false
            bool output = false;
            char choice = InputChar(messageToUser);
            if (choice == 'y' || choice == 'Y')
                output = true;
            return output;

        }
        #endregion
    }
}
