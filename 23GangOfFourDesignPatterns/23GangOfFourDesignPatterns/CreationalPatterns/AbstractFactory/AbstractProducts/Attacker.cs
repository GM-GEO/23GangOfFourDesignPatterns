namespace _23GangOfFourDesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    /// <summary>
    /// The Attacker Abstract Product defines a template for what classes implementing the Attacker class must have. 
    /// In this case, classes deriving the Attacker class must implement a name as well as an Attack method where they are attacking a class that is derived of the Defender class.
    /// </summary>
    public abstract class Attacker
    {
        public string Name { get; set; }

        public abstract void Attack(Defender d);
    }
}