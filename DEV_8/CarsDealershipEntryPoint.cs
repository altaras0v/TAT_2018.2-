using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class CarDealershipEntryPoint
    {
        static void Main(string[] args)
        {
            XMLCarsParser parser = XMLCarsParser.GetInstance();
            CarsDealership carsStorage = new CarsDealership("Cars", parser.GetVehicleList(args[0]));
            CarsDealership truckStogare = new CarsDealership("Trucks", parser.GetVehicleList(args[1]));
            CommandHandler commandHandler = new CommandHandler(carsStorage, truckStogare);
            commandHandler.Show();
        }
    }
}
}