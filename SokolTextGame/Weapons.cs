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
}
