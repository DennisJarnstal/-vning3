using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Worm : Animal
    {
        private double lengthCm;
        internal override string DoSound()
        {
            return ".....";
        }
        public Worm(string name, double weight, int age, bool herbivore, string habitat, string color, double lengthCm) : base(name, weight, age, herbivore, habitat, color)
        {
            LengthCm = lengthCm;
        }
        public double LengthCm
        {
            get { return lengthCm; }
            set { lengthCm = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nHow many cm long: {lengthCm}";
        }
    }
}
