using System;

namespace Task3
{
    /// <summary>
    /// Class that converts number from one numeral system to another
    /// </summary>
    class RadixConverter
    {
        private int oldBase = 10;
        /// <summary>
        /// Method that converts number from one numeral system to another
        /// </summary>
        /// <param name="nubmer">Integer number that entered by user</param>
        /// <param name="newBase">Base of new numeral system that entered by user </param>
        /// <returns>Number in new numeral system</returns>
        public string Converter(string nubmer, int newBase)
        {
            //Converts a string representation of a number with the specified base of a number system 
            //to its equivalent 32-bit integer
            return (Convert.ToString(Convert.ToInt32(nubmer, oldBase), newBase)); 
        }
    }
}