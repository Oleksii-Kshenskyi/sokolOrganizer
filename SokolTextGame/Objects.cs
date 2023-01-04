using SokolTextGame;

namespace SokolTextGame
{
    public interface IObject
    {
        public string Name { get; }
        public string Description { get; }
        public string[] LinesObjectSays { get; }
        public string[] ItemsForSale { get; }
    }
}
public class Guard : IObject
{
    public string Name => "guard";
    public string Description => "The guard is a man in steel armor and with a huge two-handed club.\n" +
        "You don't want to fight him, but you can ask him something.\n";
    public string[] LinesObjectSays => new[] { "What is that smell? Isn't that shit on your shoe?\n",
    "Life is a nightmare that prevents one from sleeping.\n",
    "Be yourself; everyone else is already taken\n",
    "It is awfully hard work doing nothing.\n",
    "Watermelon – it’s a good fruit. You eat, you drink, you wash your face.\n",
    "Death is hereditary.\n"};
    public string[] ItemsForSale { get; } = null;
}

public class Shopkeeper : IObject
{
    public string Name => "shopkeeper";
    public string Description => "A grandfather, with a big gray beard and strong facial features.\n" +
        "He had met many travelers, seen many battles, and knew many secrets about weapons,\n" +
        "but he was not very willing to share those secrets.\n";
    public string[] LinesObjectSays => new[] {"Stop talking and buy something already!"};
    public string[] ItemsForSale { get; } = new[] { "axe", "sword", "staff" };
}
public class Monster : IObject
{
    public string Name => "monster";

    public string Description => "A large shaggy beast, rather like a huge rock because of the color of its fur.\n" +
        "Its body shows scars, most likely from travelers who sought shelter from the rain and found their doom\n" +
        "because the beast lies on a pile of bones\n ";

    public string[] LinesObjectSays => throw new NotImplementedException();

    public string[] ItemsForSale => null;
}