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
        public string Description { get; } = "There is always something to do with an axe. You can split firewood, or you can split a skull.";
    }
    public class Sword : IWeapon
    {
        public string Description { get; } = "Sword, not big, light, nice to hold in your hand, but you have to watch its sharpness.";
    }
    public class Staff : IWeapon
    {
        public string Description { get; } = "Staff made of old oak, handle covered with leather, if you know the spell, you can use the staff for additional damage, and if not, you can use it as a two-handed cudgel.";
    }
}
