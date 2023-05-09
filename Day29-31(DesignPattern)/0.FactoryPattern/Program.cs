namespace _0.FactoryPattern;
internal class Program
{
    private static void Main(string[] args)
    {
        Creator creator = new Creator();
        var tiger = creator.CreateAnimal("tiger");
        tiger.Speak();
        var cat = creator.CreateAnimal("cat");
        cat.Speak();
        var dog = creator.CreateAnimal("dog");
        dog.Speak();
    }
}