using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Flyweight
{
    public enum Type
    {
        Original, Translate
    }

    public abstract class Answer
    {
        protected Type _type;

        public abstract void Evaluate(int answer);
    }

    public class SimpleAnswer : Answer
    {
        public SimpleAnswer(Type type)
        {
            _type = type;
        }
        public override void Evaluate(int answer)
        {
            // do some logic
            Console.WriteLine($"Answer was evaluated with type: {_type} and answer {answer}");
        }
    }

    public class UnsharedAnswer: Answer
    {
        private readonly int _e;
        private readonly int _repetition;

        public UnsharedAnswer(Type type, int e, int repetition)
        {
            _type = type;
            _e = e;
            _repetition = repetition;
        }

        public override void Evaluate(int answer)
        {
            // do some logic
            Console.WriteLine($"Unshared Answer was evaluated with type: {_type} and answer {answer}");
        }
    }
}
