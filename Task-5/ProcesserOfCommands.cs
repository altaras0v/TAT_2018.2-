namespace Task_5
{
    /// <summary>
    /// This class handles user-entered userCommands.
    /// Calls data counting methods.
    /// </summary>
    public class ProcesserOfCommands
    {
        DataGetter databaseInformation = new DataGetter();
        /// <summary>
        /// Processes the userCommands and calls the appropriate counting methods.
        /// </summary>
        /// <returns>Counting results.</returns>
        /// <param name="inputCommand">User userCommand.</param>
        /// 
        public int ResultOfCommand(string inputCommand)
        {
            switch (inputCommand)
            {
                case "count types":
                    return GetNumberOfBrands();
                case "count all":
                    return GetNumberOfCars();
                case "average price":
                    return GetAverageCostOfAllCars();
                default:
                    return GetAverageCostOfCars(inputCommand); //????//
            }
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>Number of car brands.</returns>
        public int GetNumberOfBrands()
        {
            return databaseInformation.GetAllBrands().Count;
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>The number of cars.</returns>
        public int GetNumberOfCars()
        {
            int count = 0;
            foreach (var element in databaseInformation.GetOfNumberAllCars())
            {
                count += element;
            }
            return count;
        }
        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>Number of cars of a particular brand.</returns>
        /// <param name="brand">Brand of car.</param>
        public int GetNumberOfCars(string brand)
        {
            int count = 0;
            foreach (var element in databaseInformation.GetOfNumberAllCars(brand))
            {
                count += element;
            }
            return count;
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>The average cost of all cars.</returns>
        public int GetAverageCostOfAllCars()
        {
            int countOfCostPerUnit = databaseInformation.getTheSumOfTheCostPerUnit();
            int countTheNumberOfAllCars = GetNumberOfCars();
            return countTheNumberOfAllCars / countOfCostPerUnit;
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>The average cost of a particular car.</returns>
        /// <param name="inputCommand">User userCommand.</param>
        public int GetAverageCostOfCars(string inputCommand)
        {
            string brand = inputCommand.Substring("average price ".Length);
            int numberOfCars = GetNumberOfCars(brand);
            int sumOfCars = databaseInformation.getTheSumOfTheCostPerUnit(brand);
            return numberOfCars / sumOfCars;
        }
    }
}
