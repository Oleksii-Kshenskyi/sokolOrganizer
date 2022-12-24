using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class Unknown : ICommand
    {
        public void Execute(string[] words, World world)
        {
            Console.WriteLine("I'm sorry, but there is no such command. =) ");
        }
    }
}
