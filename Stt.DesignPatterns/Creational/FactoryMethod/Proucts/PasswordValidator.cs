using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod.Proucts
{
    public class PasswordValidator: Validator
    {
        public override bool Validate()
        {
            Console.WriteLine("-> PasswordValidator");
            // add specific validation logic
            return base.Validate() && true;
        }
    }
}
