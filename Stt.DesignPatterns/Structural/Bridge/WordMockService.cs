using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Bridge
{
    public class WordMockService : IWordService
    {
        public void GetWord()
        {
            Console.WriteLine("Word Mock Service");
        }
    }
}
