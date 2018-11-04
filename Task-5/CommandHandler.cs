using System;
namespace Task_5
{
    /// <summary>
    /// Class containing user interaction methods
    /// </summary>
    public class CommandHandler
    {
        private CommandsChecker listInputCommands = new CommandsChecker(); 
        private static CommandHandler objCommandHandler = new CommandHandler();

        /// <summary>
        /// Ensures that only one object is created for the class.
        /// </summary>
        /// <returns>The object of interviewer.</returns>
        public static CommandHandler GetObjCommandHandler()
        {
            if (objCommandHandler == null)
                objCommandHandler = new CommandHandler();
            return objCommandHandler;
        }

        /// <summary>
        /// Asks the user for the brand of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The brand of cars.</returns>
        public string InputBrand()
        {
            Console.WriteLine("Enter brand of cars: ");
            string brand = Console.ReadLine();
            if (brand.Length < 1)
            {
                Console.WriteLine("Cars brand of incorrect.");
                InputBrand();
            }
            return brand;
        }

        /// <summary>
        /// Asks the user for the model of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The model of cars.</returns>
        public string InputModel()
        {
            Console.WriteLine("Enter model of cars: ");
            string model = Console.ReadLine();
            if (model.Length < 1)
            {
                Console.WriteLine("Cars model of incorrect.");
                InputModel();
            }
            return model;
        }

        /// <summary>
        /// Asks the user for the quantity of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The quantity of cars.</returns>
        public int InputNumber()
        {
            try
            {
                Console.WriteLine("Enter quantity of cars: ");
                int quantity = Int32.Parse(Console.ReadLine());
                if (quantity < 0)
                {
                    Console.WriteLine("Cars quantity of incorrect.");
                    InputNumber();
                }
                return quantity;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
                return InputNumber();
            }
        }

        /// <summary>
        /// Asks the user for The cost per unit of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The cost per unit of car.</returns>
        public int InputPrice()
        {
            try
            {
                Console.WriteLine("Enter the cost of one car: ");
                int costPerUnitOfCar = Int32.Parse(Console.ReadLine());
                if (costPerUnitOfCar < 0)
                {
                    Console.WriteLine("The cost of one car of incorrect.");
                    InputPrice();
                }
                return costPerUnitOfCar;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
                return InputPrice();
            }
        }

        /// <summary>
        /// Asks the user userCommand.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The user userCommand.</returns>
        public string InputCommand()
        {
            Console.WriteLine("Enter userCommand: ");
            string inputCommand = Console.ReadLine();
            if (!listInputCommands.CheckCommand(inputCommand))
            {
                Console.WriteLine("Sorry, Wrong userCommand. Try again.");
                InputCommand();
            }
            return inputCommand;
        }
    }
}