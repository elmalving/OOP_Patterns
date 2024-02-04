namespace OONV
{
    public class Hero
    {
        public string Name { get; }
        public int Age { get; }
        public enum Classes
        {
            KNIGHT,
            MAGE,
            SORCERER,
            CLERIC,
            PALADIN,
            ROGUE
        }
        public Classes Class { get; }

        private int _xp;

        public int XP
        {
            get { return _xp; }
            set { _xp = value; }
        }

        public int Level
        {
            get
            {
                return (int)Math.Floor(Math.Pow(_xp / 100, 1.0 / 1.4));
            }
        }


        private Weapon? _weapon;

        public Weapon? Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        private Armor? _armor;

        public Armor? Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        public double Damage => Weapon?.Damage ?? 1;

        private static Hero? _instance;
        private static readonly object _lockObject = new();

        private Hero(string name, int age, Classes heroClass)
        {
            Name = name;
            Age = age;
            if (Enum.IsDefined(typeof(Classes), heroClass))
            {
                Class = heroClass;
            }
            else
            {
                throw new ArgumentException("Invalid class value");
            }
        }

        public static Hero Create(string name, int age, Classes heroClass)
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    _instance ??= new Hero(name, age, heroClass);
                }
            }
            return _instance;
        }
    }
}