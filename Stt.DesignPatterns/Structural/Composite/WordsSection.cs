using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stt.DesignPatterns.Structural.Composite
{
    public class WordsSection : IEntity
    {
        private readonly List<IEntity> wordsEntity = new List<IEntity>();

        public void Add(IEntity entity) =>
            wordsEntity.Add(entity);

        public int TranslateCount() =>
            wordsEntity.Sum(o => o.TranslateCount());
    }
}
