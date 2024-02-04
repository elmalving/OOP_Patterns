namespace OONV
{
    interface IBuilder
    {
        void Reset();
        void SetWeapon();
        void SetArmor();
        Hero TrainHero();
    }
    public class HeroBuilder : IBuilder
    {
        private Hero _newHero;
        public HeroBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _newHero = Hero.Create("Stark", 21, Hero.Classes.KNIGHT);
        }
        public Hero TrainHero()
        {
            // Nemůžu přijít na to, proč to tady je.
            // Hero create_hero = _newHero;
            // Reset();
            return _newHero;
        }
        public void SetWeapon()
        {
            _newHero.Weapon = ItemDatabase.WOODEN_SWORD; 
        }
        public void SetArmor()
        {
            _newHero.Armor = ItemDatabase.LETHER_ARMOR;
        }
    }
}
