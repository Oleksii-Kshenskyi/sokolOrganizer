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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("See you later..");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
    public class Who : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (string.Join(" ", words) == "who") Console.Write("who, who? =)\n");
            else if (string.Join(" ", words) == "who am i")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(world?.player?.Description);
            }
            else Console.Write("I know the command \"who am i\"\n");
            Console.ResetColor();
        }
    }
    public class Look : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var locObj = world.CurrentLocation().ObjectOnLocation;
            if (string.Join(" ", words) == "look") Console.Write("Look... What's next? You can look at your weapon or look around\n");
            else if (string.Join(" ", words) == "look at my weapon")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(world?.player?.Weapon.Description);
            }
            else if (string.Join(" ", words.Take(2)) == "look at" && locObj?.Name == string.Join(" ", words.Skip(2)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(locObj.Description);
            }
            else if ((words.Length > 2 && string.Join(" ", words.Take(2)) == "look at") && (locObj?.Name != string.Join(" ", words.Skip(2))))
            {
                Console.WriteLine("I don't see this object on location");
            }
            else if (string.Join(" ", words) == "look at") Console.Write("Look at... what?\n");
            else if (string.Join(" ", words) == "look around")
            {
                if (locObj == null)
                {
                    Console.WriteLine("There's nothing to see in this place.");
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"You see: {locObj.Name}");
                }
            }
            else Console.Write("I know commands \"look at my weapon\", \"look around\" and \"look at <object>\"\n");
            Console.ResetColor();
        }
    }
    public class Where : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (string.Join(" ", words) == "where") Console.Write("Where? Where what? Or where who?\n");
            else if (string.Join(" ", words) == "where am i")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(world.CurrentLocation().Description);
            }
            else if (string.Join(" ", words) == "where can i go")
            {
                string output = string.Join(", ", world.CurrentLocation().possibleLocation);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Possible location : {output}");
                Console.ResetColor();
            }
            else Console.Write("I know the command \"where am i\" and \"where can i go\"\n");
            Console.ResetColor();
        }
    }
    public class Go : ICommand
    {
        public void Execute(string[] words, World world)
        {
            if (words.Length > 2 && string.Join(" ", words.Take(2)) == "go to")
            {
                string locationName = string.Join(" ", words.Skip(2));
                if (world?.player?.CurrentLocation == locationName)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"I am already in a location {world.player.CurrentLocation}");
                    Console.ResetColor();
                }
                else
                {
                    var currentLocarion = world.CurrentLocation();
                    if (currentLocarion.possibleLocation.Contains(locationName))
                    {
                        world.player.CurrentLocation = locationName;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Current location: {locationName}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Can't go to location {locationName} because it doesn't exist");
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
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I need a <go to \"location name>\" command.");
                Console.ResetColor();
            }
        }
    }
    public class Talk : ICommand
    {
        public void Execute(string[] words, World world)
        {
            var locObj = world.CurrentLocation().ObjectOnLocation;
            Console.ForegroundColor = ConsoleColor.Red;
            if (string.Join(" ", words) == "talk") Console.Write("blah blah blah blah\nThe command exists, but you have to say \"talk to\"\n");
            else if (string.Join(" ", words) == "talk to") Console.WriteLine("Talk to who?");
            else if ((string.Join(" ", words.Take(2)) == "talk to") && locObj?.Name == string.Join(" ", words.Skip(2)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Random rand = new Random();
                int randomIdex = rand.Next(0, locObj.LinesObjectSays.Length);
                Console.WriteLine($"{locObj.Name}: {locObj.LinesObjectSays[randomIdex]}");
                Console.ResetColor();
            }
            else Console.WriteLine("There is no such thing here.");
            Console.ResetColor();
        }
    }
    public class What : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var locObj = world.CurrentLocation().ObjectOnLocation;
            if (string.Join(" ", words) == "what") Console.WriteLine("What \"what\"?");
            else if ((string.Join(" ", words) == "what can i buy"))
            {
                if (locObj?.ItemsForSale != null)
                {
                    var output = string.Join(", ", locObj.ItemsForSale);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You can buy : {output} from a {locObj.Name}\n");
                }
                else Console.WriteLine("No one is selling anything here.");
            }
            else Console.WriteLine("Use the command \"What can I buy\"");
            Console.ResetColor();
        }
    }
    public class Buy : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (string.Join(" ", words) == "buy" || words.Length != 4) Console.WriteLine("Use: buy <weapon> from <seller>");
            else if (world.CurrentLocation().ObjectOnLocation != null)
            {
                var locObj = world.CurrentLocation().ObjectOnLocation;
                var weaponName = words[1];
                if (locObj.ItemsForSale != null &&
                    words[0] == "buy" &&
                    locObj.ItemsForSale.Contains(words[1]) &&
                    words[2] == "from" &&
                    words[3] == locObj.Name)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    world.GetWeapon(weaponName);
                    Console.WriteLine($"Congratulations, you bought {weaponName} from {locObj.Name}");
                }
                else if (words[3] == locObj.Name && locObj.ItemsForSale == null)
                {
                    Console.WriteLine($"Do you want to buy something from a {locObj.Name}? Really?\n You'd better go to a weapon shop.");
                }
                else if (words[3] != locObj.Name) Console.WriteLine($"Who is {words[3]}? Perhaps you have the wrong shop?");
                else Console.WriteLine($"{locObj.Name} doesn't have any {weaponName}s to sell you.");
            }
            else Console.WriteLine("No vendors nearby.");
            Console.ResetColor();
        }
    }

    public class Unknown : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I'm sorry, but there is no such command. =) ");
            Console.ResetColor();
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