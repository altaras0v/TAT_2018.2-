using System;
using System.Text;

namespace RadixConverter
{
    /// <summary>
    /// Class that converted number from one numeral system to another
    /// </summary>
    public class CoverterToNewSystem
    {
        static string newSystemValues = "0123456789ABCDEFGHIJ";
        /// <summary>
        /// Method that converted number from one numeral system to another
        /// </summary>
        /// <param name="number">Number that entered by user</param>
        /// <param name="newBase">Base of new numeral system that entered by user</param>
        /// <returns>Еhe absolute value of number in new numeral system</returns>
        public string ToNewBaseConverter(int number, int newBase)
        {
            StringBuilder convertedNumber = new StringBuilder();
            do
            {
                int newSystemNumber = number % newBase;
                convertedNumber.Insert(0, newSystemValues[Math.Abs(newSystemNumber)]);
                number = number / newBase;
            } while (number != 0);

            return convertedNumber.ToString();
        }
    }
}