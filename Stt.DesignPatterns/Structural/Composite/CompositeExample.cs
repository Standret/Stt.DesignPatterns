using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Composite
{
    public class CompositeExample : BaseExampleRunable
    {
        public CompositeExample() : base("Composite") { }

        protected override void RunAction()
        {
            var section = new WordsSection();
            var nestedSection = new WordsSection();
            var nestedNestedSection = new WordsSection();

            section.Add(nestedSection);
            nestedSection.Add(nestedNestedSection);

            section.Add(new Word(1));
            section.Add(new Word(2));

            nestedSection.Add(new Word(3));

            nestedNestedSection.Add(new Word(4));
            nestedNestedSection.Add(new Word(5));

            Console.WriteLine($"section count: {section.TranslateCount()}");
            Console.WriteLine($"nesetd section count: {nestedSection.TranslateCount()}");
            Console.WriteLine($"nested nested count: {nestedNestedSection.TranslateCount()}");
        }
    }
}
