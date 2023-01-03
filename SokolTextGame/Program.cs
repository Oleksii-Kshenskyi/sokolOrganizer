using SokolTextGame;

World? world = null;
while (true)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("[Welcome!]\n" +
        "[You will need a character to play the game.]\n" +
        "\nChoose who you want to be:\nWarrior\nRogue\nWizard\n~~>>");
    string? userInput = Console.ReadLine();
    Console.ResetColor();

    if (userInput != null)
    {
        string[] classes = { "warrior", "rogue", "wizard" };
        string[] words = userInput.ToLower().Trim().Split();
        if (words.Length != 1) continue;
        else if (classes.Contains(words[0]))
        {
            world = new World();
            CreatePlayer player = new CreatePlayer();
            player.Execute(words, world);
            Console.Clear();
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("You must write: Warrior or Rogue or Wizard\n\n");
            Console.ResetColor();
        }
    }
}

while (true)
{
    Console.Write("~~>> ");
    string? userInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(userInput)) world.ExecuteCommand(userInput);
}
