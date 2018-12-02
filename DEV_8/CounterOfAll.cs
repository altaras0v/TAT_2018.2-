using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class CounterOFAll : ICommand
    {
        private CarsDealership CarsDealership;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="vehiclesStorage">Cars storage.</param>
        public CounterOfAll(CarsDealership vehiclesStorage)
        {
            CarsDealership = vehiclesStorage;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>       
        public void Execute()
        {
            CarsDealership.CounterOfAll();
        }
    }

}
