using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Behviour.Visitor
{
    public class DayGraduator : IGraduable
    {
        public void Graduate(SimpleAnswer answer)
        {
            Console.WriteLine("answer graduated by Day function");
        }

        public void Graduate(CompositeAnswer answer)
        {
            Console.WriteLine("composite answer graduated by Day function");
        }
    }
}
