
//while (true)
//{
//    Console.Write(">> ");
//    string? user_input = Console.ReadLine();
//    if (!string.IsNullOrEmpty(user_input)) world.ExecuteCommand(user_input);
//}
using SokolTextGame;

World? world = new World();

while (true)
{
   
    Console.Write("~~>> ");
    string? userInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(userInput)) world.ExecuteCommand(userInput);
}
