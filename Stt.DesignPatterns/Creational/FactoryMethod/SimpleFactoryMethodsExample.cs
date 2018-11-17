using Stt.DesignPatterns.Creational.FactoryMethod.Proucts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod
{
    public class SimpleFactoryMethodsExample : BaseExampleRunable
    {
        public SimpleFactoryMethodsExample() : base ("Simple Factory Method") { }

        protected override void RunAction()
        {
            var passwordValidators = SimpleFactory.CreatePasswordValidator();
            var confirmPasswordValidators = SimpleFactory.CreateConfirmPasswordValidator(passwordValidators);

            passwordValidators.Validate();
            confirmPasswordValidators.Validate();
        }
    }
}
