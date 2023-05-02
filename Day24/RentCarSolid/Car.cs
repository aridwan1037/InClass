namespace RentCarSolid;

public class Car : ICar
{
    //Liskov Subtitutios Principle
    public virtual string Make { get; set; }
    public virtual string Model { get; set; }
    public virtual int Year { get; set; }
    public virtual double DailyRate { get; set; }
    public virtual bool Available { get; set; }
    
    // public string Make { get; set; }
    // public string Model { get; set; }
    // public int Year { get; set; }
    // public double DailyRate { get; set; }
    // public bool Available { get; set; }
}
public class SportsCar : Car
{
    public override double DailyRate => 200.00;
}

