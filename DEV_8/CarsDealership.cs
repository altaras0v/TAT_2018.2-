using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class CarsDealership
    {
        string TypeOfVehicle;
        public List<Cars> Vehicles { get; }

        /// <summary>
        /// Constructor for CarsDealership class.
        /// Adds new cars to the cars list.
        /// </summary>
        public CarsDealership(string typeOfVehicle, List<Cars> newList)
        {
            TypeOfVehicle = typeOfVehicle;
            Vehicles = newList;
        }

        /// <summary>
        /// Method for count all types of vehicles.
        /// </summary>
        public void CounterOfAll()
        {
            int quantityOfAllVehicles = Vehicles.Select(i => i.Quantity).Sum(x => x);
            Console.Write("Total number of " + TypeOfVehicle + ": " + quantityOfAllVehicles + "\n");
        }

        /// <summary>
        /// Method for calculate price of vehicles
        /// or calculate price of vehicles for only one brand.
        /// </summary>
        /// <param name="arg">Brand for calculate(if necessary).</param>
        public void AveragePriceCounter(string arg = null)
        {
            double result = 0.0;
            var tempCarsList = Vehicles;
            string returnedString = String.Empty;
            if (!string.IsNullOrEmpty(arg) && Vehicles.Exists(product => product.Brand.Equals(arg)))
            {
                returnedString = "Average cost of a " + TypeOfVehicle + " in the brand " + arg.ToString() + ": ";
                tempCarsList = Vehicles.FindAll(product => product.Brand.Equals(arg));
            }
            else
            {
                returnedString = "Average " + TypeOfVehicle + " cost: ";
            }
            foreach (var product in tempCarsList)
            {
                result += product.unitCost;
            }
            Console.Write(returnedString + " " + (result / tempCarsList.Count) + "\n");
        }

        /// <summary>
        /// Method for calculate number of vehicles brands.
        /// </summary>
        public void CounterOfBrands()
        {
            int quantityOfBrands = Vehicles.GroupBy(i => i.Brand).Count();
            Console.Write("Number of " + TypeOfVehicle + " brands: " + quantityOfBrands + "\n");
        }
    }

}

