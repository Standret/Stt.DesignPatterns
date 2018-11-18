using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Flyweight
{
    public class FlyweightExample : BaseExampleRunable
    {
        public FlyweightExample() : base("Flyweight") { }

        protected override void RunAction()
        {
            var factory = new AnswerFactory();

            var answers = new Answer[]
            {
                 factory.GetAnswer(Type.Original),
                 factory.GetAnswer(Type.Translate),
                 new UnsharedAnswer(Type.Original, 2, 13)
            };

            foreach (var item in answers)
                item.Evaluate(2);
        }
    }
}
