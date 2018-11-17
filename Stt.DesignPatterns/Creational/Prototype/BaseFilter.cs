using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.Prototype
{
    public class BaseCompositeModel
    {
        public int X { get; set; }
        public string Key { get; set; }
    }
    public class BaseFilter
    {
        public int BaseIntValue { get; set; }
        public string BaseStringValue { get; set; }
        public BaseCompositeModel BaseCompositeValue { get; set; }
    }
}
