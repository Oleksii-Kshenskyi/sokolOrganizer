namespace SokolTextGame
{
    public interface ICommand
    {
        public void Execute(string[] words, World world);
    }
    public class Echo : ICommand
    {
        public void Execute(string[] words, World world)
        {
            string text = string.Join(" ", words.Skip(1));
            Console.WriteLine(text);
        }
    }

    public class Exit : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.WriteLine("See you later..");
            Environment.Exit(0);
        }
    }
    public class WhoAmI : ICommand
    {
        public void Execute(string[] words, World world)
        {
            if (string.Join(" ", words) == "who") Console.Write("who, who? =)\n");
            else if (string.Join(" ", words) == "who am i") Console.Write(world?.player?.Description);
            else Console.Write("I know the command \"who am i\"\n");
        }
    }
    public class Look : ICommand
    {
        public void Execute(string[] words, World world)
        {
            if (string.Join(" ", words) == "look") Console.Write("Look... What's next? You can look at your weapon\n");
            else if (string.Join(" ", words) == "look at") Console.Write("Look at... what?\n");
            else if (string.Join(" ", words) == "look at my weapon") Console.Write(world?.player?.Weapon.Descriprion);
            else Console.Write("I know the command \"look at my weapon\"\n");
        }
    }
    public class WhereAmI : ICommand
    {
        public void Execute(string[] words, World world)
        {
            if (string.Join(" ", words) == "where") Console.Write("Where? Where what? Or where who?\n");
            else if (string.Join(" ", words) == "where am i") Console.Write(world.CurrentLocation().Description);
            else Console.Write("I know the command \"where am i\"\n");
        }
    }
    public class GoTo : ICommand
    {
        public void Execute(string[] words, World world)
        {
            if (words.Length == 3)
            {
                if (string.Join(" ", words.Take(2)) == "go to")
                {
                    string locationName = string.Join(" ", words.Skip(2));
                    if (world.player.CurrentLocation == locationName) Console.WriteLine($"I am already in a location {world.player.CurrentLocation}");
                    else
                    {
                        world.player.CurrentLocation = locationName;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Current location: {locationName.ToUpper()}");
                        Console.ResetColor();
                    }
                }
            }
            else if (string.Join(" ", words) == "go")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Where are we going?");
                Console.ResetColor();
            }
            else if (string.Join(" ", words) == "go to")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not bad, not bad.\n" +
                    "But you have to give the name of the place you want to go to.");
                Console.ResetColor();
            }
        }
    }

    public class Unknown : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.WriteLine("I'm sorry, but there is no such command. =) ");
        }
    }

    public class CreatePlayer : ICommand
    {
        public void Execute(string[] words, World world)
        {
            if (words[0].Equals("warrior")) world.player = new Warrior(new BareFists());
            else if (words[0].Equals("rogue")) world.player = new Rogue(new BareFists());
            else if (words[0].Equals("wizard")) world.player = new Wizard(new BareFists());
        }
    }
}