using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Structural.Composite
{
    public interface IEntity
    {
        int TranslateCount();
        void Add(IEntity entity);
    }
}
