using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod.Proucts
{
    public class ConfirmPasswordValidator: Validator
    {
        private readonly IValidator passwordValidator;

        public ConfirmPasswordValidator(IValidator password)
        {
            passwordValidator = password;
        }

        public override bool Validate()
        {
            Console.WriteLine("-> ConfirmPasswordValidator");
            return base.Validate(); // added here compare two password
        }
    }
}
