using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns.Behviour.Visitor
{
    public class VisitorExample : BaseExampleRunable
    {
        public VisitorExample() : base("Visitor") { }

        protected override void RunAction()
        {
            var simpleAnswer = new SimpleAnswer();
            var compositeAnswer = new CompositeAnswer();

            var dayGraduator = new DayGraduator();
            var weekGraduator = new WeekGraduator();

            simpleAnswer.Accept(dayGraduator);
            compositeAnswer.Accept(weekGraduator);

            Console.WriteLine(new String('-', 40));

            compositeAnswer.Accept(dayGraduator);
            compositeAnswer.Accept(weekGraduator);

        }
    }
}
