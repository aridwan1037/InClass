namespace _0.FactoryPattern;

public interface Animal
{
    void Speak(); 
}

public class Dog: Animal{
    public void speak() { 
        Console.WriteLine("Bark");
    }
}
public class Cat: Animal{
    public void Speak() {
        Console.WriteLine("Meow");
    }
}
public class Tiger: Animal{
    public void Speak() {
        Console.WriteLine("Roar");
    }
}