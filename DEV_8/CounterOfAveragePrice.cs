using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class CounterOfAveragePrice : ICommand
    {
        CarsDealership CarsDealership;
        string Brand;

        /// <summary>
        /// Constructor.
        /// </summary>     
        /// <param name="vehiclesStorage">Cars storage.</param>
        /// <param name="brand">Brand, if necessary</param>
        public AveragePriceCounter(CarsDealership vehiclesStorage, string brand = null)
        {
            CarsDealership = vehiclesStorage;
            Brand = brand;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>       
        public void Execute()
        {
            CarsDealership.AveragePriceCounter(Brand);
        }
    }

}
