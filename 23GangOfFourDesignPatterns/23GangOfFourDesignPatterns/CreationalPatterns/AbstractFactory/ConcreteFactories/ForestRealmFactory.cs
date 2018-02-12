using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
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
