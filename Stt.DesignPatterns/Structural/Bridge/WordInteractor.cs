using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Bridge
{
    public class WordInteractor
    {
        private readonly IWordService wordService;

        public WordInteractor(IWordService wordService)
        {
            this.wordService = wordService;
        }

        public void GetWord()
        {
            wordService.GetWord();
        }
    }
}
