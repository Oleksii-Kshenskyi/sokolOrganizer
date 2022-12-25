using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokolTextGame
{
    public interface IPlayer
    {
        public string Description { get; }
    }
    public class Warrior : IPlayer
    {
        public string Description { get; } = "A man of unremarkable appearance, but of sturdy build\n" +
            " and with a facial expression that makes it clear that talking is not your forte.\n" +
            "You're ready to knock your opponent's teeth out at any moment,\n" +
            " and maybe even break a bone or two.";
    }
}
