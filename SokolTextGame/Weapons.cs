namespace SokolTextGame
{
    public interface IWeapon
    {
        public string Description { get; }
    }

    public class BareFists : IWeapon
    {
        public string Description { get; } = "Bare fists. What else could it be?\n";
    }
    public class Axe : IWeapon
    {
        public string Description { get; } = "There is always something to do with an axe.\nYou can split firewood, or you can split a skull.\n";
    }
    public class Sword : IWeapon
    {
        public string Description { get; } = "Sword, not big, light, nice to hold in your hand,\nbut you have to watch its sharpness.\n";
    }
    public class Staff : IWeapon
    {
        public string Description { get; } = "Staff made of old oak, handle covered with leather,\nif you know the spell, you can use the staff for additional damage,\nand if not, you can use it as a two-handed cudgel.\n";
    }
}
