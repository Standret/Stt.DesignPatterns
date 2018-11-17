using Stt.DesignPatterns.Creational.FactoryMethod;
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

            example.Run();

            Console.ReadKey();
        }
    }
}
