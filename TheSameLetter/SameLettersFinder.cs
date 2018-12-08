using System;
using System.Collections.Generic;

namespace SameLetter
{    /// <summary>
     /// Class that find same letters
     /// </summary>
    class SameLettersFinder
    {
        /// <summary>
        /// Method that find same letters
        /// </summary>
        /// <param name="enteredString">String,that needed to find same letters</param>
        /// <returns>Return dicionary like "letter - count"</returns>
        public Dictionary<char, int> GetSameLetters(String enteredString)
        {
            Dictionary<char, int> sameLetters = new Dictionary<char, int>();
            int counter = 0;
            char PreSymbol = '\\';
            foreach (char symbol in enteredString)
            {
                foreach (char letter in enteredString)
                    if (letter != PreSymbol && letter == symbol)
                        counter++;
                if (counter > 1)
                    sameLetters.Add(symbol,counter);
                counter = 0;
                PreSymbol = symbol;
            }
            return sameLetters;
        }
    }
}

  