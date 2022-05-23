using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Wolf : Animal
    {
        internal bool bitePain = true;
        internal override string DoSound()
        {
            return "Howl";
        }
        public Wolf(string name, double weight, int age, bool herbivore, string habitat, string color, bool bitePain) : base(name, weight, age, herbivore, habitat, color)
        {
            BitePain = bitePain;
        }
        public bool BitePain
        {
            get { return bitePain; }
            set { bitePain = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nIs the bite painful: {bitePain}";
        }
    }
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool herbivore, string habitat, string color, bool bitePain) : base(name, weight, age, herbivore, habitat, color, bitePain)
        {           
        }
        internal override string Stats()
        {
            return base.Stats();
        }
        public string Talk()
        {
            return ("\nI am wolfman, fear me!");
        }

    }
}
