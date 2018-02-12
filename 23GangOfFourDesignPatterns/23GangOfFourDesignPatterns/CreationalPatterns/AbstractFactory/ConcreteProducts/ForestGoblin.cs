using System;
using System.ComponentModel;
using _23GangOfFourDesignPatterns.Utilities.CustomAttributes;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    internal class ForestGoblin : Attacker
    {
        public ForestGoblin forestGoblin;

        public ForestGoblin()
        {

        }

        public ForestGoblin(string Name)
        {
            this.Name = Name;
        }

        

        public override void Attack(Defender defender)
        {
            forestGoblin = forestGoblin ?? new ForestGoblin("Forest Goblin");

            Console.WriteLine(forestGoblin.Name + " attacks " + defender.GetType().GetAttributeValue((ClassNameFriendlyAttribute cnfa) => cnfa.FriendlyName));
        }
    }
}