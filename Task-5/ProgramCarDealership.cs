using System;
namespace Task_5
{
    /// <summary>
    /// Program that displays the information that the user requested
    /// it is number of car brands,total number of cars,average price of cars and average price of model 
    /// </summary>
    class ProgramCarDealership
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        public static void Main()
        {
            DatabaseBuilder databaseBuilder = new DatabaseBuilder();
            CreationCar carCreator = new CreationCar();
            ProcesserOfCommands processerOfCommand = new ProcesserOfCommands();
            do
            {
                try
                {
                    carCreator.Create();
                    databaseBuilder.Build();
                    Console.WriteLine("Press Esc to take action. Press Enter to continue input");
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: " + error.Message);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            string inputCommand = CommandHandler.GetObjCommandHandler().InputCommand();
            if (inputCommand == "exit")
                Environment.Exit(0);
        }
    }
}