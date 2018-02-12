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
            //By initializing a FantasyRealmFactory and instatiating a ForestRealmFactory (which derives FantasyRealmFactory), we make use of the Abstract classes ability to run methods.
            //Because each concrete factory handles it's own initialization of attackers and defenders, we can use the base method RunBattle without additional code for realm-specific battles.
            FantasyRealmFactory forestRealm = new ForestRealmFactory();
            FantasyRealm fantasyRealm = new FantasyRealm(forestRealm);
            fantasyRealm.RunBattle();

            FantasyRealmFactory plainsRealm = new PlainsRealmFactory();
            fantasyRealm = new FantasyRealm(plainsRealm);
            fantasyRealm.RunBattle();

            Console.ReadKey();
        }
    }
}
