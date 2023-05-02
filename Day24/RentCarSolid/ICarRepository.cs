namespace RentCarSolid;
public interface ICarRepository
{
    IList<ICar> GetAvailableCars();
    void UpdateCarAvailability(ICar car, bool available);
}
