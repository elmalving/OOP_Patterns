namespace OONV
{
    public class Program
    {
        public static void Main()
        {
            HeroBuilder heroBuilder = new();
            heroBuilder.SetWeapon();
            heroBuilder.SetArmor();
            Hero hero = heroBuilder.TrainHero();
            Console.WriteLine($"{hero.Name}, {hero.Age}\nClass: {hero.Class}\nWeapon: {hero.Weapon.Name}\nArmor: {hero.Armor.Name}");

            Hero hero1 = Hero.Create("", 22, Hero.Classes.KNIGHT);
            Hero hero2 = Hero.Create("", 23, Hero.Classes.KNIGHT);
            Console.WriteLine($"{hero1.Age}, {hero2.Age}");
        }
    }
}