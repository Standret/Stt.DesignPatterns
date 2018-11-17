using Stt.DesignPatterns.Creational.FactoryMethod.Proucts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod.Factories
{
    public interface IValidatorFactory
    {
        IValidator Create();
    }
}
