using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactories
{
    /// <summary>
    /// The FantasyRealmFactory is an abstract class, which differs from an interface due to it's ability to be instantiated. 
    /// Abstract classes are generally "IS-A" relationships, where Forest Realm is a Fantasy Realm and Plains Realm is a Fantasy Realm.
    /// </summary>
    abstract class FantasyRealmFactory
    {
        public abstract Attacker CreateAttacker();
        public abstract Defender CreateDefender();
    }
}
