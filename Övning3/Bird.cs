using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Bird : Animal
    {
        private int numberOfWings = 2;
        internal override string DoSound()
        {
            return "Tweet";
        }
        public Bird(string name, double weight, int age, bool herbivore, string habitat, string color, int numberOfWings) : base(name, weight, age, herbivore, habitat, color)
        {
            NumberOfWings = numberOfWings;
        }
        public int NumberOfWings
        {
            get { return numberOfWings; }
            set { numberOfWings = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nSpeed in km: {numberOfWings}";
        }
    }
    internal class Pelican : Bird
    {
        private bool bigMouth = true;
        public Pelican(string name, double weight, int age, bool herbivore, string habitat, string color, int numberOfWings, bool bigMouth) : base(name, weight, age, herbivore, habitat, color, numberOfWings)
        {
            NumberOfWings = numberOfWings;
            BigMouth = bigMouth;
        }
        public bool BigMouth
        {
            get { return bigMouth; }
            set { bigMouth = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nNumber of wings: {NumberOfWings}\nHas a big mouth: {bigMouth}";
        }

    }
    internal class Flamingo : Bird
    {
        private bool shiny = true;
        public Flamingo(string name, double weight, int age, bool herbivore, string habitat, string color, int numberOfWings, bool shiny) : base(name, weight, age, herbivore, habitat, color, numberOfWings)
        {
            NumberOfWings = numberOfWings;
            Shiny = shiny;
        }
        public bool Shiny
        {
            get { return shiny; }
            set { shiny = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nNumber of wings: {NumberOfWings}\nIs shiny: {shiny}";
        }

    }
    internal class Swan : Bird
    {
        private int numberOfPartners = 1;
        public Swan(string name, double weight, int age, bool herbivore, string habitat, string color, int numberOfWings, int numberOfPartners) : base(name, weight, age, herbivore, habitat, color, numberOfWings)
        {
            NumberOfWings = numberOfWings;
            NumberOfPartners = numberOfPartners;
        }
        public int NumberOfPartners
        {
            get { return numberOfPartners; }
            set { numberOfPartners = value; }
        }
        internal override string Stats()
        {
            return base.Stats() + $"\nNumber of wings: {NumberOfWings}\nNumber of partners: {numberOfPartners}";
        }

    }
}

