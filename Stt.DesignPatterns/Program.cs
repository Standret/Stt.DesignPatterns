using Stt.DesignPatterns.Creational.Builder;
using Stt.DesignPatterns.Creational.FactoryMethod;
using Stt.DesignPatterns.Creational.Prototype;
using System;

namespace Stt.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IExampleRunable example = null;

            example = new SimpleFactoryMethodsExample();
            example = new FactoryMethodExample();
            example = new BuilderExample();
            example = new PrototypeMemberwiseExample();

            example.Run();

            Console.ReadKey();
        }
    }
}
