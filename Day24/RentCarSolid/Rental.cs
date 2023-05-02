namespace RentCarSolid;

public class Rental
{
    public Car Car { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double TotalPrice { get; set; }

    public double CalculatePrice()
    {
        // Calculate the rental price based on the car's daily rate and the rental period
        var rentalPeriod = (EndDate - StartDate).Days + 1;
        TotalPrice = rentalPeriod * Car.DailyRate;
        return TotalPrice;
    }
}
