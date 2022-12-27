using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokolTextGame
{
    public interface IWeapon
    {
        public string Descriprion { get; }
    }

    public class BareFists : IWeapon
    {
        public string Descriprion { get; } = "Bare fists. What else could it be?\n";
    }
}
