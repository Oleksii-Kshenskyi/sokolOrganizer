using SokolTextGame;

namespace SokolTextGame
{
    public interface IObject
    {
        public string Name { get; }
        public string Description { get; }
        public string[] ObjectPharse { get; }
    }
}
public class Guard : IObject
{


    public string Name => "guard";

    public string Description => "The guard is a man in steel armor and with a huge two-handed club.\n" +
        "You don't want to fight him, but you can ask him something.\n";

    public string[] ObjectPharse => new[] { "What is that smell? Isn't that shit on your shoe?\n",
    "Life is a nightmare that prevents one from sleeping.\n",
    "Be yourself; everyone else is already taken\n",
    "It is awfully hard work doing nothing.\n",
    "Watermelon – it’s a good fruit. You eat, you drink, you wash your face.\n",
    "Death is hereditary.\n"};
}
