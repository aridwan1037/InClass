public class HeroFactory {
   public IHero createCharacter(string type) {
      if (type.Equals("Goblin", StringComparison.OrdinalIgnoreCase)) {
         return new Goblin();
      } else if (type.Equals("Mage", StringComparison.OrdinalIgnoreCase)) {
         return new Mage();
      } else if (type.Equals("Assassins", StringComparison.OrdinalIgnoreCase)) {
         return new Assassins();
      } else {
         return null;
      }
   }
}
