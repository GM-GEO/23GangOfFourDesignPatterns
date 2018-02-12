using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactories;
using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.Clients;
using _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FantasyRealmFactory forestRealm = new ForestRealmFactory();
            FantasyRealm fantasyRealm = new FantasyRealm(forestRealm);
            fantasyRealm.RunBattle();

            // Create and run the American animal world

            FantasyRealmFactory plainsRealm = new PlainsRealmFactory();
            fantasyRealm = new FantasyRealm(plainsRealm);
            fantasyRealm.RunBattle();

            // Wait for user input

            Console.ReadKey();
        }
    }
}
