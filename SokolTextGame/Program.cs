using SokolTextGame;
using System.Drawing;

World? world = null;
while (true)
{
    Console.Write("Welcome! You will need a character to play the game." +
        "\nChoose who you want to be:\nWarrior\nRogue\nWizard\n~~>>");
    string? userInput = Console.ReadLine();

    if (userInput != null)
    {
        string[] classes = { "warrior", "rogue", "wizzard" };
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
            Console.ForegroundColor= ConsoleColor.Red;
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
