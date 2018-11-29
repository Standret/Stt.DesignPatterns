using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Bridge
{
    public class WordInteractor: BaseInteractor, IWordInteractor
    {
        public WordInteractor(IWordService wordService) : base (wordService) { }

        public void GetWord()
        {
            _wordService.GetWord();
        }
    }
}
