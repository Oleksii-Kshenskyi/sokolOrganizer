namespace SokolTextGame
{
    public class World
    {
        public IPlayer? player;
        private Dictionary<string, ICommand> commands = new();
        private void CommandDictionary()
        {
            commands["echo"] = new Echo();
            commands["exit"] = new Exit();
            commands["who"] = new Who();
            commands["look"] = new Look();
            commands["where"] = new Where();
            commands["go"] = new Go();
            commands["talk"] = new Talk();
            commands["what"] = new What();
        }
        private Dictionary<string, ILocation> locations = new();
        private void LocationDictionary()
        {
            locations["forest"] = new Forest(null);
            locations["square"] = new Square(new Guard());
            locations["weapon shop"] = new WeaponShop(new Shopkeeper());
        }
        public ILocation CurrentLocation()
        {
            return locations[player.CurrentLocation];
        }

        public void ExecuteCommand(string command)
        {
            string[] commandList = command
                .ToLower()
                .Trim()
                .Split()
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToArray();
            commands.GetValueOrDefault(commandList[0], new Unknown()).Execute(commandList, this);
        }

        public World()
        {
            CommandDictionary();
            player = null;
            LocationDictionary();
        }
    }
}
