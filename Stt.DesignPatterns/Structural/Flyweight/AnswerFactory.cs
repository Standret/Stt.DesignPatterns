using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Flyweight
{
    public class AnswerFactory
    {
        private readonly Dictionary<Type, Answer> answers = new Dictionary<Type, Answer>();

        public Answer GetAnswer(Type type)
        {
            if (!answers.ContainsKey(type))
                answers.Add(type, new SimpleAnswer(type));

            return answers[type];
        }
    }
}
