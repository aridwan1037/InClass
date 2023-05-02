namespace RentCarSolid;
public interface IRental
{
    ICar Car { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
    double CalculatePrice();
}
