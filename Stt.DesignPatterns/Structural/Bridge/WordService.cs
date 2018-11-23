using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Bridge
{
    public class WordService : IWordService
    {
        public void GetWord()
        {
            Console.WriteLine("Word Service");
        }
    }
}
