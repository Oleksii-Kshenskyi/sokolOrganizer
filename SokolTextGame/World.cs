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
            commands["who"] = new WhoAmI();
            commands["look"] = new Look();
            commands["where"] = new WhereAmI();
        }
        private Dictionary<string, ILocation> locations = new();
        private void LocationDictionary()
        {
            locations["forest"] = new Forest();
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
