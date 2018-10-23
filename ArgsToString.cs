using System;
using System.Text;

namespace ConsoleApp3
{
    /// <summary>
    /// Class that convert data to string.
    /// </summary>
    static class ArgsToString
    {
        /// <summary>
        /// Method that covert data to string and lower case
        /// </summary>
        public static string ArrayToString(this string[] args)
        {
            StringBuilder concatenatedString = new StringBuilder();       
            String returnString = String.Empty;
            if (args.Length == 1)
            {
                foreach (string i in args)          
                {
                    concatenatedString.Append(i);
                }
            }      
            else
            {
                foreach (string i in args)
                {
                    concatenatedString.Append(i + " ");
                }
                concatenatedString.Remove(concatenatedString.Length - 1, 1);                                       // Delete last space bar
            }   
            returnString = concatenatedString.ToString();
            return returnString.ToLower();
        }
    }
}