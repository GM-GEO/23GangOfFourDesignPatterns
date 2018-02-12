using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    class PlainsRealmFactory : AbstractFactories.FantasyRealmFactory
    {
        public override Attacker CreateAttacker()
        {
            return new PlainsCentaur();
        }

        public override Defender CreateDefender()
        {
            return new PlainsHorseman();
        }
    }
}
