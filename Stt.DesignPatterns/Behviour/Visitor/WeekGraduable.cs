using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Behviour.Visitor
{
    public class WeekGraduator : IGraduable
    {
        public void Graduate(SimpleAnswer answer)
        {
            Console.WriteLine("simple answer graduated by Week function");
        }

        public void Graduate(CompositeAnswer answer)
        {
            Console.WriteLine("composite answer graduated by week function");
        }
    }
}
