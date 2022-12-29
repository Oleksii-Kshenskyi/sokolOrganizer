namespace SokolTextGame
{
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

        public string[] possibleLocation => new[] { "forest" };

        public IObject? ObjectOnLocation { get; set; }
        public Square(IObject objectOnLocation)
        {
            ObjectOnLocation = objectOnLocation;
        }
    }
}
