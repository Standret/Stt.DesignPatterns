using Stt.DesignPatterns.Creational.FactoryMethod.Proucts;

namespace Stt.DesignPatterns.Creational.FactoryMethod.Factories
{
    public class ConfirmPasswordValidatorFactory : IValidatorFactory
    {
        private readonly IValidator passwordValidator;

        public ConfirmPasswordValidatorFactory(IValidator passwordValidator)
        {
            this.passwordValidator = passwordValidator;
        }

        public IValidator Create()
        {
            return new ConfirmPasswordValidator(passwordValidator); // add logic for consturct object
        }
    }
}
