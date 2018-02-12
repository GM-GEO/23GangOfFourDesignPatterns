using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    /// <summary>
    /// The PlainsRealmFactory is the concrete implementation of the FantasyRealmFactory and it's methods.
    /// </summary>
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
