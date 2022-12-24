using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokolTextGame
{
    internal interface ICommand
    {
        void Execute(string[] words, World world);                
    }
    public class Echo : ICommand
    {
        void ICommand.Execute(string[] words, World world)
        {
            string text = string.Join(" ", words.Skip(1));
            Console.WriteLine(text);
        }
    }

    public class Exit : ICommand
    {
        void ICommand.Execute(string[] words, World world)
        {
            Console.WriteLine("See you later..");
            Environment.Exit(0);
        }
    }

    public class Unknown : ICommand
    {
        void ICommand.Execute(string[] words, World world)
        {
            Console.WriteLine("I'm sorry, but there is no such command. =) ");
        }
    }
}
