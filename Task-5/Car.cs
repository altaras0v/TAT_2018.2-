using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    /// <summary>
    /// Class Car.
    /// Information about cars, brand and their number.
    /// </summary>
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Number { get; set; }
        public int CostPerUnit { get; set; }
        private static Car objCar = new Car();

        /// <summary>
        /// Ensures that only one object is created for the class.
        /// </summary>
        /// <returns>The object of car.</returns>
        
        public static Car GetObjCar()
        {
            if (objCar == null)
                objCar = new Car();
            return objCar;
        }
        
    }
        public class CreationCar
        {
            Car car = Car.GetObjCar();
            CommandHandler interviewer = CommandHandler.GetObjCommandHandler();

            /// <summary>
            /// Creats new car.
            /// </summary>
            public void Create()
            {
                car.Brand = interviewer.InputBrand();
                car.Model = interviewer.InputModel();
                car.Number = interviewer.InputNumber();
                car.CostPerUnit = interviewer.InputPrice();
            }
        }
    }

