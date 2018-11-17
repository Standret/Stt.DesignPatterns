using System;

namespace Stt.DesignPatterns.Creational.Prototype
{
    public class Composite
    {
        public int X { get; set; }
        public string Key { get; set; }
    }
    public class Filter : BaseFilter, ICloneable
    {
        public int Min { get; set; }
        public string Value { get; set; }
        public Composite CompositeValue { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
