namespace RentCarSolid;
public interface ICarRentalService
{
    IList<ICar> GetAvailableCars();
    IRental RentCar(ICar car, DateTime startDate, DateTime endDate);
    void ReturnCar(IRental rental);
}

public class CarRentalService : ICarRentalService
{
    private readonly ICarRepository _carRepository;
    private readonly IRentalRepository _rentalRepository;

    public CarRentalService(ICarRepository carRepository, IRentalRepository rentalRepository)
    {
        _carRepository = carRepository;
        _rentalRepository = rentalRepository;
    }

    public IList<ICar> GetAvailableCars()
    {
        return _carRepository.GetAvailableCars();
    }

    public IRental RentCar(ICar car, DateTime startDate, DateTime endDate)
    {
        var rental = new Rental
        {
            Car = car,
            StartDate = startDate,
            EndDate = endDate
        };

        rental.CalculatePrice();

        _carRepository.UpdateCarAvailability(car, false);
        _rentalRepository.AddRental(rental);

        return rental;
    }

    public void ReturnCar(IRental rental)
    {
        _carRepository.UpdateCarAvailability(rental.Car, true);
        _rentalRepository.RemoveRental(rental);
    }
}
    public IList<ICar> GetAvailableCars()
    {
        return _cars.Where(c => c.Available).ToList();
    }

    public void UpdateCarAvailability(ICar car, bool available)
    {
        var carToUpdate = _cars.FirstOrDefault(c => c.Make == car.Make && c.Model == car.Model && c.Year == car.Year);
        if (carToUpdate != null)
        {
            carToUpdate.Available = available;
        }
    }


}

public class RentalRepository : IRentalRepository
{
    private readonly List<IRental> _rentals;

    public RentalRepository()
    {
        _rentals = new List<IRental>();
    }

    public void AddRental(IRental rental)
    {
        _rentals.Add(rental);
    }

    public void RemoveRental(IRental rental)
    {
        _rentals.Remove(rental);
    }
}

public interface ICarRentalServise
{
}
