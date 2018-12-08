using System;
using System.Collections.Generic;

namespace SameLetter
{
    /// <summary>
    /// Class that display number of same letters and this same letters
    /// </summary>
    class SameLettersDisplayer
    {
        /// <summary>
        /// Method that display number of same letters and this same letters as a dictionary
        /// </summary>
        /// <param name="sameLettersDictionary">Dictionary of same letters and their number</param>
        public void DisplaySameLetter(Dictionary<char, int> sameLettersDictionary)
        {
            foreach (KeyValuePair<char, int> keyValue in sameLettersDictionary)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }  
        }
    }
}
