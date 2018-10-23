using System.Collections;

namespace ConsoleApp2
{
    /// <summary>
    /// Class for counting the maximum length
    /// </summary>
    class MaxUniqueSequnceFinder
    {
        /// <summary>
        /// Method that counted the maximum length
        /// </summary>
        /// <param name="element">
        /// Data that the user entered
        /// </param>
        /// <returns>
        /// Return maximum number of consecutive non-repeating elements
        /// </returns>
        public static string MaxFinderMethod(string element)        
        {
            ArrayList nonRepeatingSymbols = new ArrayList();                // Array of non-repeating elements
            int maxLength = 0;

            for (int n = 0; n < element.Length; n++)
            {
                nonRepeatingSymbols.Add(element[n]);

                for (int k = n + 1; k < element.Length && !(nonRepeatingSymbols.Contains(element[k])); k++)
                {
                    nonRepeatingSymbols.Add(element[k]);

                    if (nonRepeatingSymbols.Count > maxLength)
                    {
                        maxLength = nonRepeatingSymbols.Count;
                    }
                }
                nonRepeatingSymbols.Clear();
            }
            return "Maximum number of consecutive non-repeating elements is: " + maxLength;
        }
    }
}