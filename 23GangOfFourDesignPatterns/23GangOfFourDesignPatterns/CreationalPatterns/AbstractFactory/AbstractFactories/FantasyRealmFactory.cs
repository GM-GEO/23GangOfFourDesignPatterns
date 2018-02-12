using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactories
{
    abstract class FantasyRealmFactory
    {
        public abstract Attacker CreateAttacker();
        public abstract Defender CreateDefender();
    }
}
