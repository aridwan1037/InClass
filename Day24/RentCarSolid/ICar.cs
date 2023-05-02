namespace RentCarSolid;

public interface ICar
{
    string Make { get; set; }
    string Model { get; set; }
    int Year { get; set; }
    double DailyRate { get; set; }
    bool Available { get; set; }
}
