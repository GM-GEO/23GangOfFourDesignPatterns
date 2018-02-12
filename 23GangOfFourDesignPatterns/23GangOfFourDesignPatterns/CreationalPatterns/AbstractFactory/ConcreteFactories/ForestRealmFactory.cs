using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    /// <summary>
    /// The ForestRealmFactory is the concrete implementation of the ForestRealmFactory and it's specified methods for the ForestGoblin and ForestRanger.
    /// </summary>
    class ForestRealmFactory : AbstractFactories.FantasyRealmFactory
    {
        public override Attacker CreateAttacker()
        {
            return new ForestGoblin();
        }

        public override Defender CreateDefender()
        {
            return new ForestRanger();
        }
    }
}
