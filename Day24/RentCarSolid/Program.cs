using System;
using System.Linq;

namespace RentCarSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the repositories and service
            ICarRepository carRepository = new CarRepository();
            IRentalRepository rentalRepository = new RentalRepository();
            CarRentalService carRentalService = new CarRentalService(carRepository, rentalRepository);

            // Retrieve a list of available cars
            var availableCars = carRentalService.GetAvailableCars();

            // Rent a car
            var carToRent = availableCars.FirstOrDefault();
            var rental = carRentalService.RentCar(carToRent, DateTime.Now, DateTime.Now.AddDays(7));

            // Return a rental
            carRentalService.ReturnCar(rental);

            Console.WriteLine("Car rental completed successfully.");
            Console.ReadKey();
        }
    }
}
