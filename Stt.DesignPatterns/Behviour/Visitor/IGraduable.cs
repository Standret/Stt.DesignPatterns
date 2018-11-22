using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Behviour.Visitor
{
    public interface IGraduable
    {
        void Graduate(SimpleAnswer answer);
        void Graduate(CompositeAnswer answer);
    }
}
