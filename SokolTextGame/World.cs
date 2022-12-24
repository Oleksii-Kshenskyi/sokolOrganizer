using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SokolTextGame
{
    internal class World
    {
        private Dictionary<string, ICommand> commands = new();
        private void CommandDictionary()
        {
            commands["echo"] = new Echo();
            commands["exit"] = new Exit();

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
        }
    }
}
