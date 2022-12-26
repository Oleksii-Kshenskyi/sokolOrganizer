using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokolTextGame
{
    public interface ILocation
    {
        string Name { get; }
        string Description { get; }
    }
    public class Forest : ILocation
    {
        public string Name { get; } = "Forest";

        public string Description { get; } = "It is raining, and you can smell the rotten leaves in the air.\n" +
            "You are standing on a path in a dense forest.";
    }
}
