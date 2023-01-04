namespace SokolTextGame{
    public interface ILocation
    {
        string Name { get; }
        string Description { get; }
        string[] possibleLocation { get; }

        IObject? ObjectOnLocation { get; set; }
    }
    public class Forest : ILocation
    {
        public string Name { get; } = "forest";

        public string Description { get; } = "It is raining, and you can smell the rotten leaves in the air.\n" +
            "You are standing on a path in a dense forest.\n";

        public string[] possibleLocation => new[] { "square" };

        public IObject? ObjectOnLocation { get; set; }
        public Forest(IObject? objectOnLocation) => ObjectOnLocation = objectOnLocation;
    }
    public class Square : ILocation
    {
        public string Name => "square";

        public string Description { get; } = "The square. A place where life is boiling.\n" +
            "You can smell the fire and freshly cooked meat in the air.\n" +
            "Merchants selling cloth and spices.\n" +
            "Blacksmiths who use their huge hammers to make weapons that every traveler can buy,\n" +
            "as long as he has coins in his pocket and not air.\n";

        public string[] possibleLocation => new[] { "forest", "weapon shop", "cave" };

        public IObject? ObjectOnLocation { get; set; }
        public Square(IObject objectOnLocation)
        {
            ObjectOnLocation = objectOnLocation;
        }
    }

    public class WeaponShop : ILocation
    {
        public string Name => "weapon shop";

        public string Description => "Weapon store, a place where you can choose weapons to your liking,\n" +
            " and perhaps something else as well. If you are a warrior, you can look out for an axe,\n" +
            " and if you are an outlaw, why not pick up a light sword. And if you are a wizard,\n" +
            " there is also a staff, which will be a good companion in battles.\n";

        public string[] possibleLocation => new[] { "square" };

        public IObject? ObjectOnLocation { get; set; }
        public WeaponShop(IObject? objectOnLocation) => ObjectOnLocation = objectOnLocation;
    }
    public class Cave : ILocation
    {
        public string Name => "cave";

        public string Description => "A dark place that has one entrance and one exit.\n" +
            "There are traces of dried blood on the walls.\n" +
            "The deadly smell in the air makes it clear that not everyone who entered here\n" +
            "could see the light of day again.\n";

        public string[] possibleLocation => new[] { "square" };

        public IObject? ObjectOnLocation { get; set; }
        public Cave(IObject? objectOnLocation)
        {
            ObjectOnLocation = objectOnLocation;
        }
    }
}
