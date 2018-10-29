namespace CarToList
{
    /// <summary>
    /// Create object like a car
    /// </summary>
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        /// <summary>
        /// Initialize car(object)
        /// </summary>
        /// <param name="Model">Model of car</param>
        /// <param name="Brand">Brend of car</param>
        /// <param name="Color">Color of car</param>

        public Car(string Model, string Brand, string Color)
        {
            this.Model = Model;
            this.Brand = Brand;
            this.Color = Color;
        }

        /// <summary>
        /// Сreate an object with one parameter 
        /// </summary>
        /// <param name="Car">Object to creating new object with the same fields </param>
        public Car(Car car)
        {
            Model = car.Model;
            Brand = car.Brand;
            Color = car.Color;
        }
    }

}