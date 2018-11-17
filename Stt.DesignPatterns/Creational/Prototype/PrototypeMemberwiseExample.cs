using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.Prototype
{
    public class PrototypeMemberwiseExample : BaseExampleRunable
    {
        public PrototypeMemberwiseExample() : base("MemberviseClone") {  }

        protected override void RunAction()
        {
            var filter = new Filter
            {
                Min = 1,
                Value = "Value",
                CompositeValue = new Composite
                {
                    Key = "CompositeValue",
                    X = 2
                },
                BaseIntValue = 3,
                BaseStringValue = "BaseValue",
                BaseCompositeValue = new BaseCompositeModel
                {
                    X = 4,
                    Key = "BaseCompositeValue"
                }
            };
            var filter2 = (Filter)filter.Clone();

            Console.WriteLine("\n");
            Console.WriteLine("Original");
            Print(filter);

            Console.WriteLine("\n");
            Console.WriteLine("Copied");
            Print(filter2);

            filter2.Min = 5;
            filter2.Value = "ChangedValue";
            filter2.CompositeValue.X = 6;
            filter2.CompositeValue.Key = "ChangedCompositeValue";
            filter2.BaseIntValue = 7;
            filter2.BaseStringValue = "ChangedBaseValue";
            filter2.BaseCompositeValue.X = 8;
            filter2.BaseCompositeValue.Key = "ChangedBaseCompositeValue";

            Console.WriteLine("After change\n");
            Console.WriteLine("Original");
            Print(filter);

            Console.WriteLine("\n");
            Console.WriteLine("Copied");
            Print(filter2);
        }

        private void Print(Filter filter)
        {
            Console.WriteLine(JsonConvert.SerializeObject(filter, Formatting.Indented));
            Console.WriteLine("\n");
        }
    }
}
