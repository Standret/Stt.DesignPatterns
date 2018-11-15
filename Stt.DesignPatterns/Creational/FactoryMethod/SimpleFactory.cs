using Stt.DesignPatterns.Creational.FactoryMethod.Proucts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.FactoryMethod
{
    public static class SimpleFactory
    {
        public static IValidator CreateEmailValidator()
        {
            return new EmailValidator(); // and add init field like min, max pattern etc
        }

        public static IValidator CreateConfirmPasswordValidator(IValidator passwordValidator)
        {
            return new ConfirmPasswordValidator(passwordValidator); // and add init field like min, max pattern etc
        }
    }
}
