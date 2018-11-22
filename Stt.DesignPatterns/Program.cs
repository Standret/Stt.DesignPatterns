using Stt.DesignPatterns.Behviour.Visitor;
using Stt.DesignPatterns.Creational.Builder;
using Stt.DesignPatterns.Creational.FactoryMethod;
using Stt.DesignPatterns.Creational.Prototype;
using Stt.DesignPatterns.Structural.Composite;
using Stt.DesignPatterns.Structural.Flyweight;
using System;

namespace Stt.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IExampleRunable example = null;

            // Creational
            example = new SimpleFactoryMethodsExample();
            example = new FactoryMethodExample();
            example = new BuilderExample();
            example = new PrototypeMemberwiseExample();

            // Structural
            example = new FlyweightExample();
            example = new CompositeExample();

            // Behaviour
            example = new VisitorExample();

            example.Run();

            Console.ReadKey();
        }
    }
}
