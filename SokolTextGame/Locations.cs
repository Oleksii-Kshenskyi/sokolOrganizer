namespace SokolTextGame
{
    public interface ILocation
    {
        string Name { get; }
        string Description { get; }
    }
    public class Forest : ILocation
    {
        public string Name { get; } = "forest";

        public string Description { get; } = "It is raining, and you can smell the rotten leaves in the air.\n" +
            "You are standing on a path in a dense forest.\n";
    }
}
