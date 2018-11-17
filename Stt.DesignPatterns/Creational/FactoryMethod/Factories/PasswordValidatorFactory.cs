using System;
using System.Collections.Generic;
using System.Text;
using Stt.DesignPatterns.Creational.FactoryMethod.Proucts;

namespace Stt.DesignPatterns.Creational.FactoryMethod.Factories
{
    public class PasswordValidatorFactory : IValidatorFactory
    {
        public IValidator Create()
        {
            return new PasswordValidator(); // add logic for construct
        }
    }
}
