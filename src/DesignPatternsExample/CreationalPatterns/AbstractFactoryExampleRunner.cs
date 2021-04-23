using System;

namespace DesignPatternsExample.CreationalPatterns
{
    public class AbstractFactoryExampleRunner : AbstractDesignPatternExampleRunner
    {
        public override string GetTitle()
        {
            return "LA FABRIQUE ABSTRAITE";
        }

        /// <summary>
        /// La Fabrique abstraite est un patron de conception de création qui permet de créer des familles de produits complètes sans avoir à préciser leurs classes concrètes.
        /// </summary>
        /// <see cref="https://refactoring.guru/fr/design-patterns/abstract-factory/csharp/example"/>
        public override void RunInternal()
        {
            ConcreteToulouseCarFactory toulouseCarFactory = new ConcreteToulouseCarFactory();
            ConcreteMoissacCarFactory moissacCarFactory = new ConcreteMoissacCarFactory();

            Console.WriteLine(toulouseCarFactory.CreateFamilyCar().GetName());
            Console.WriteLine(toulouseCarFactory.CreateRaceCar().GetName());

            Console.WriteLine(moissacCarFactory.CreateFamilyCar().GetName());
            Console.WriteLine(moissacCarFactory.CreateRaceCar().GetName());
        }
    }

    public interface ICarAbstractFactory
    {
        ICarAbstractProduct CreateFamilyCar();

        ICarAbstractProduct CreateRaceCar();
    }

    public class ConcreteToulouseCarFactory : ICarAbstractFactory
    {
        private readonly string _location = "Toulouse";

        public ICarAbstractProduct CreateFamilyCar()
        {
            return new ConcretePeugeot508Product(_location);
        }

        public ICarAbstractProduct CreateRaceCar()
        {
            return new ConcreteRenaultR5TurboProduct(_location);
        }
    }

    public class ConcreteMoissacCarFactory : ICarAbstractFactory
    {
        private readonly string _location = "Moissac";

        public ICarAbstractProduct CreateFamilyCar()
        {
            return new ConcretePeugeot508Product(_location);
        }

        public ICarAbstractProduct CreateRaceCar()
        {
            return new ConcreteRenaultR5TurboProduct(_location);
        }
    }

    public interface ICarAbstractProduct
    {
        string GetName();
    }

    public class ConcretePeugeot508Product : ICarAbstractProduct
    {
        private readonly string _madeIn;

        public ConcretePeugeot508Product(string madeIn)
        {
            _madeIn = madeIn;
        }

        public string GetName()
        {
            return $"Peugeot 508 fabriquée à {_madeIn}";
        }
    }

    public class ConcreteRenaultR5TurboProduct : ICarAbstractProduct
    {
        private readonly string _madeIn;

        public ConcreteRenaultR5TurboProduct(string madeIn)
        {
            _madeIn = madeIn;
        }

        public string GetName()
        {
            return $"R5 Turbo    fabriquée à {_madeIn}";
        }
    }
}