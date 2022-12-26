using SokolTextGame;

World world = new World();

while (true)
{
    Console.Write("~~>> ");
    string? userInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(userInput)) world.ExecuteCommand(userInput);
}
