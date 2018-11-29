using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Bridge
{
    public class BridgeExample : BaseExampleRunable
    {
        public BridgeExample() : base("Bridge") { }

        protected override void RunAction()
        {
            IWordInteractor simple = new WordInteractor(new WordService());
            IWordInteractor mock = new WordInteractor(new WordMockService());

            simple.GetWord();
            mock.GetWord();
        }
    }
}
