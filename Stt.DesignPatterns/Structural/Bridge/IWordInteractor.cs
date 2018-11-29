using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Bridge
{
    public interface IWordInteractor
    {
        void GetWord();
    }

    public abstract class BaseInteractor
    {
        protected readonly IWordService _wordService;

        public BaseInteractor(IWordService wordService)
        {
            _wordService = wordService;
        }
    }
}
