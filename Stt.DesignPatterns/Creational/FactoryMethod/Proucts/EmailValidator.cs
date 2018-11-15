using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod.Proucts
{
    public class EmailValidator: Validator
    {
        public override bool Validate()
        {
            // add specific validation logic
            return base.Validate() && true;
        }
    }
}
