using Stt.DesignPatterns.Creational.FactoryMethod.Factories;
using Stt.DesignPatterns.Creational.FactoryMethod.Proucts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethodExample : BaseExampleRunable
    {
        public FactoryMethodExample() : base("Factory Method") { }

        protected override void RunAction()
        {
            IValidatorFactory passwordFactory = new PasswordValidatorFactory();
            IValidator passwordValidator = passwordFactory.Create();

            IValidatorFactory confirmPasswordFactory = new ConfirmPasswordValidatorFactory(passwordValidator);
            IValidator confirmPasswordValidator = confirmPasswordFactory.Create();

            passwordValidator.Validate();
            confirmPasswordValidator.Validate();
        }
    }
}
