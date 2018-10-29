using System;
/// <summary>
/// Program that realised searching cars in list
/// User add cars(Car car) to list(carList) 
/// And add one car to method   Search
/// And program show all cars that have the same parameters
/// </summary>
namespace CarToList
{
    /// <summary>
    /// Empty point of program
    /// </summary>
    class ProgramtToSearchCar
    {
        static void Main(string[] args)
        {
            DoublyLinkedList carList = new DoublyLinkedList();
            Car car1 = new Car("Mazda","626","Green");
            Car car2 = new Car("Renault","Logan","Black");
            Car car3 = new Car("Mazda", "3", "Gray");
            Car car4 = new Car("BMW", "X5", "Black");
            Car car5 = new Car("Honda", "Civic", "Red");
            Car car6 = new Car("Honda", "Accord", "Gray");           //Object that parameters are basis for searching
            Car car7 = new Car("Hundai", "Solaris", "White");
            carList.Push(car1);
            carList.Push(car2);
            carList.Push(car3);
            carList.Push(car4);
            carList.Push(car5);
            carList.Push(car7);

            DoublyLinkedList sortList = carList.Search(car6);         //Sorted list with needed parameters
            sortList.Display();
            Console.Read();
        }
    }
}