using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Hedgehog : Animal
    {
        private string taste = "Yummy";
        internal override string DoSound()
        {
            return "Miiiii";
        }
        public Hedgehog(string name, double weight, int age, bool herbivore, string habitat, string color, string taste) : base(name, weight, age, herbivore, habitat, color)
        {
            Taste = taste;
        }
        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nWhat does it taste like: {taste}";
        }
    }
}
