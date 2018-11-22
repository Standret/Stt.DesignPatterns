using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Behviour.Visitor
{
    public interface IAnswer
    {
        void Accept(IGraduable graduable);
    }
}
