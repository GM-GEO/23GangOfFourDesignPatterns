using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactories;
using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.Clients
{
    class FantasyRealm
    {
        private Attacker attaker;
        public Defender defender;

        public FantasyRealm(FantasyRealmFactory realmFactory)
        {
            attaker = realmFactory.CreateAttacker();
            defender = realmFactory.CreateDefender();

        }

        public void RunBattle()
        {
            attaker.Attack(defender);
        }
        
    }
}
