using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Behviour.Visitor
{
    public class CompositeAnswer : IAnswer
    {
        public void Accept(IGraduable graduable)
        {
            graduable.Graduate(this);
        }
    }
}
