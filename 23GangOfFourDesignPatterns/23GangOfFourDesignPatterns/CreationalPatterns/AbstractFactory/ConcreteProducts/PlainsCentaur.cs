using _23GangOfFourDesignPatterns.Utilities.CustomAttributes;
using System;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    internal class PlainsCentaur : Attacker
    {
        public PlainsCentaur plainsCentaur;

        public PlainsCentaur()
        {

        }

        public PlainsCentaur(string Name)
        {
            this.Name = Name;
        }

        public override void Attack(Defender defender)
        {
            plainsCentaur = plainsCentaur ?? new PlainsCentaur("Plains Centaur");

            Console.WriteLine(plainsCentaur.Name + " attacks " + defender.GetType().GetAttributeValue((ClassNameFriendlyAttribute cnfa) => cnfa.FriendlyName));
        }
    }
}