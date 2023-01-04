namespace SokolTextGame
{
    public interface IWeapon
    {
        string Name { get; set; }
        public string Description { get; }
        public int WeaponDamage { get; set; }
    }

    public class BareFists : IWeapon
    {
        public string Description { get; } = "Bare fists. What else could it be?\n";
        public string Name { get; set; } = "bare fists";
        public int WeaponDamage { get; set; } = 10;
    }
    public class Axe : IWeapon
    {
        public string Description { get; } = "There is always something to do with an axe.\nYou can split firewood, or you can split a skull.\n";
        public string Name { get; set; } = "axe";
        public int WeaponDamage { get; set; } = 25;
    }
    public class Sword : IWeapon
    {
        public string Description { get; } = "Sword, not big, light, nice to hold in your hand,\nbut you have to watch its sharpness.\n";
        public string Name { get; set; } = "sword";
        public int WeaponDamage { get; set; } = 25;
    }
    public class Staff : IWeapon
    {
        public string Description { get; } = "Staff made of old oak, handle covered with leather,\nif you know the spell, you can use the staff for additional damage,\nand if not, you can use it as a two-handed cudgel.\n";
        public string Name { get; set; } = "staff"; 
        public int WeaponDamage { get; set; } = 25;
    }
}
