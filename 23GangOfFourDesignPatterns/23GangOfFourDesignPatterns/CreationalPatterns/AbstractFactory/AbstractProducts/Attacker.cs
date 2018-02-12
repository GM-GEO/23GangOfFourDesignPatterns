namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    public abstract class Attacker
    {
        public string Name { get; set; }

        public abstract void Attack(Defender d);
    }
}