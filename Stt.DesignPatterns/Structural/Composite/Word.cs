using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Stt.DesignPatterns.Structural.Composite
{
    public class Word : IEntity
    {
        private int _totalTranslate;

        public Word(int totalTranslate)
        {
            _totalTranslate = totalTranslate;
        }

        public void Add(IEntity entity)
        {
            throw new InvalidOperationException("Add canot called for primitive type");
        }

        public int TranslateCount() =>
            _totalTranslate;
    }
}
