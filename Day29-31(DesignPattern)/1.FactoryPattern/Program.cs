using System;

public class Game
{
    public static void Main()
    {
        Console.Clear();

        HeroFactory heroFactory = new HeroFactory();
        IHero goblin = heroFactory.createCharacter("Goblin");
        goblin.attack();
        IHero mage = heroFactory.createCharacter("Mage");
        mage.attack();
        IHero assassins = heroFactory.createCharacter("Assassins");
        assassins.attack();
    }
}
