using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Horse : Animal
    {
        private double speedKm;
        internal override string DoSound()
        {
            return "Niegh";
        }
        public Horse(string name, double weight, int age, bool herbivore, string habitat, string color, double speedKm) : base(name, weight, age, herbivore, habitat, color)
        {
            SpeedKm = speedKm;
        }
        public double SpeedKm
        {
            get { return speedKm; }
            set { speedKm = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nSpeed in km: {speedKm}";
        }
    }
}
