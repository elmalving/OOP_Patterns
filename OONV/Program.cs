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
        }
    }
}