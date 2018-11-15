using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod.Proucts
{
    public abstract class Validator : IValidator
    {
        public virtual bool Validate()
        {
            // do some validation logic
            return true;
        }
    }
}
