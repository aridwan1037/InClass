namespace RentCarSolid;
public class CarRepository : ICarRepository
{
    private readonly List<ICar> _cars;

    public CarRepository()
    {
        _cars = new List<ICar>
        {
            new Car { Make = "Toyota", Model = "Camry", Year = 2021, DailyRate = 50.00, Available = true },
            new Car { Make = "Honda", Model = "Accord", Year = 2022, DailyRate = 60.00, Available = true },
            new SportsCar(),
        };
    }
}
