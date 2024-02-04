namespace OONV
{
    public class Item(string name)
    {
        private static int lastAssignedId = 0;
        public int Id { get; } = ++lastAssignedId;
        public string Name { get; } = name;
    }
    public class Weapon(string name, double damage) : Item(name)
    {
        public double Damage { get; } = damage;
    }
    public class Armor(string name, int armor) : Item(name)
    {
        public int ArmorValue { get; } = armor;
    }
}