using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Creational.Builder
{
    public class BuilderExample : BaseExampleRunable
    {
        public BuilderExample() : base("Builder") { }

        protected override void RunAction()
        {
            var filter = new FilterBuilder()
                .UseMin(2)
                .UseMax(10)
                .UseUnique()
                .Build();
        }
    }
}
