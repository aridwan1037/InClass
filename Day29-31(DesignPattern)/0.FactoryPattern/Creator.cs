namespace _0.FactoryPattern;

public class Creator
{
    Animal CreateAnimal(string name){
        if (name == "tiger")
            return new Tiger();
        if (name == "cat")
            return new Cat();
        if (name == "dog")
            return new Dog();
        return;
    }
}
