using System;

namespace DesignPatternsExample.CreationalPatterns
{
    public class FactoryExampleRunner : AbstractDesignPatternExampleRunner
    {
        public override string GetTitle()
        {
            return "LA FABRIQUE";
        }

        /// <summary>
        /// La Fabrique est un patron de conception de création qui permet de créer des produits sans avoir à préciser leurs classes concrètes.
        /// </summary>
        /// <see cref="https://refactoring.guru/fr/design-patterns/factory-method/csharp/example"/>
        public override void RunInternal()
        {
            Console.WriteLine(new GazelleCreator().Observe());
            Console.WriteLine(new LionCreator().Observe());
        }
    }

    public abstract class AnimalCreator
    {
        public abstract IAnimal CreateAnimal();

        public string Observe()
        {
            IAnimal animal = CreateAnimal();

            string result = "Observation : " + animal.Eat();

            return result;
        }
    }

    public class GazelleCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal()
        {
            return new Gazelle();
        }
    }


    public class LionCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal()
        {
            return new Lion();
        }
    }

    public interface IAnimal
    {
        string Eat();
    }

    public class Gazelle : IAnimal
    {
        public string Eat()
        {
            return "la gazelle a mangé de l'herbe.";
        }
    }

    public class Lion : IAnimal
    {
        public string Eat()
        {
            return "le lion a mangé la gazelle.";
        }
    }
}