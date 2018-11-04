using System.Collections.Generic;
namespace Task_5
{
    /// <summary>
    /// Class contains a list of valid userCommands and methods for checking input userCommands.
    /// </summary>
    public class CommandsChecker
    {
        List<string> defaultCommand = new List<string> { "count types", "count all", "average price     ", "exit" };
        DataGetter databaseInformation = new DataGetter();

        /// <summary>
        /// Checks the userCommand.
        /// </summary>
        /// <returns> true, if userCommand was checked, false userCommand was unchecked.</returns>
        /// <param name="userCommand">User userCommand.</param>
        public bool CheckCommand(string userCommand)
        {
            foreach (string brand in databaseInformation.GetAllBrands())
            {
                if (userCommand == defaultCommand[2] + " " + brand)
                {
                    return true;
                }
            }
            return defaultCommand.Contains(userCommand);
        }
    }
}