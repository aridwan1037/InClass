using log4net;
using System;

namespace CarRent
{
    public class Car
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Car));

        public string Model { get; }
        public int Year { get; }
        public bool IsRented { get; private set; }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
            IsRented = false;

            logger.Info($"Created car {Model} ({Year})");
        }

        public void Rent()
        {
            if (IsRented)
            {
                logger.Warn($"Car {Model} ({Year}) is already rented");
                return;
            }

            IsRented = true;

            logger.Info($"Car {Model} ({Year}) is rented");
        }

        public void Return()
        {
            if (!IsRented)
            {
                logger.Warn($"Car {Model} ({Year}) is not rented");
                return;
            }

            IsRented = false;

            logger.Info($"Car {Model} ({Year}) is returned");
        }
    }

    public class CarRental
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CarRental));
        private readonly Car[] cars;

        public CarRental(Car[] cars)
        {
            this.cars = cars;
        }

        public Car RentCar()
        {
            foreach (var car in cars)
            {
                if (!car.IsRented)
                {
                    car.Rent();
                    return car;
                }
            }

            logger.Warn("All cars are rented");
            return null;
        }

        public void ReturnCar(Car car)
        {
            if (car == null)
            {
                logger.Warn("Cannot return null car");
                return;
            }

            if (!Array.Exists(cars, c => c == car))
            {
                logger.Warn($"Car {car.Model} ({car.Year}) is not from this car rental");
                return;
            }

            car.Return();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cars = new Car[]
            {
                new Car("Toyota Avanza", 2018),
                new Car("Daihatsu Xenia", 2017),
                new Car("Honda Jazz", 2019),
            };

            var rental = new CarRental(cars);

            rental.RentCar();
            rental.RentCar();
            rental.RentCar();

            rental.ReturnCar(null);

            var car = new Car("Nissan X-Trail", 2020);
            rental.ReturnCar(car);

            rental.ReturnCar(cars[1]);
        }
    }
}
