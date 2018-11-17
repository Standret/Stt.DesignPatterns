using System;
using System.Collections.Generic;
using System.Text;

namespace Stt.DesignPatterns
{
    public interface IExampleRunable
    {
        void Run();
    }

    public abstract class BaseExampleRunable: IExampleRunable
    {
        private string key;

        public BaseExampleRunable(string key)
        {
            this.key = key;
        }

        public void Run()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"--- {key} ---\n");
            RunAction();
            Console.WriteLine(new String('-', 40));
        }

        protected abstract void RunAction();
    }
}
