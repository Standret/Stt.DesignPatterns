using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Behviour.Visitor
{
    public class SimpleAnswer : IAnswer
    {
        public void Accept(IGraduable graduable)
        {
            graduable.Graduate(this);
        }
    }
}
