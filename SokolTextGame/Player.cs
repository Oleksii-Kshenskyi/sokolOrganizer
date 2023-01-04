namespace SokolTextGame
{
    public interface IPlayer
    {
        public string Description { get; }
        public IWeapon Weapon { get; set; }
        public string CurrentLocation { get; set; }
        public int HealtPlayer { get; set; }
    }
    public class Warrior : IPlayer
    {
        public string Description { get; } = "A character of unremarkable appearance, but of sturdy build\n" +
            "and with a facial expression that makes it clear that talking is not your forte.\n" +
            "You're ready to knock your opponent's teeth out at any moment,\n" +
            "and maybe even break a bone or two.\n";
        public IWeapon Weapon { get; set; }
        public string CurrentLocation { get; set; } = "forest";
        public Warrior(IWeapon weapon)
        {
            Weapon = weapon;
        }
        public int HealtPlayer { get; set; } = 100;
    }
    public class Rogue : IPlayer
    {
        public string Description { get; } = "You are fast, nimble, invisible to most people around you.\n" +
            "You like silence and control over the situation.\n" +
            "Conqueror of women's hearts and purses.\n";
        public IWeapon Weapon { get; set; }
        public string CurrentLocation { get; set; } = "forest";
        public Rogue(IWeapon weapon)
        {
            Weapon = weapon;
        }
        public int HealtPlayer { get; set; } = 100;
    }
    public class Wizard : IPlayer
    {
        public string Description { get; } = "You are a wizard of high intelligence and intuition.\n" +
            "But to use magic, you need a magic book.\n" +
            "Without it, you can only show a trick with disappearance of a thumb on your hand.\n";
        public IWeapon Weapon { get; set; }
        public string CurrentLocation { get; set; } = "forest";
        public Wizard(IWeapon weapon)
        {
            Weapon = weapon;
        }
        public int HealtPlayer { get; set; } = 100;
    }
}
