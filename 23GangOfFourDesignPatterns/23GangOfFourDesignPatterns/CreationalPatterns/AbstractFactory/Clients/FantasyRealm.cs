using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactories;
using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.Clients
{
    /// <summary>
    /// The FantasyRealm class is where the Attacker and Defender abstract classes are implemented, and where they demonstrate their usefulness over interfaces thanks to their implementable methods.
    /// </summary>
    class FantasyRealm
    {
        private Attacker attaker;
        public Defender defender;

        /// <summary>
        /// This constructor uses the abstract classes that will later be specified by the ForestRealmFactory and PlainsRealmFactory.
        /// </summary>
        /// <param name="realmFactory">The abstract realmFactory that handles the initialization of it's own attackers and defenders.</param>
        public FantasyRealm(FantasyRealmFactory realmFactory)
        {
            attaker = realmFactory.CreateAttacker();
            defender = realmFactory.CreateDefender();

        }

        /// <summary>
        /// This method implements the Attack method from attacker class, which is specified by the ForestGoblin and PlainsCentaur classes that implement the Attacker class.
        /// </summary>
        public void RunBattle()
        {
            attaker.Attack(defender);
        }
        
    }
}
