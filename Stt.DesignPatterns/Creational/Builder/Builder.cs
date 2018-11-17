using System.Text.RegularExpressions;

namespace Stt.DesignPatterns.Creational.Builder
{
    public class FilterBuilder
    {
        private int min = -1;
        private int max = -1;
        private bool isUnique;
        private string pattern;

        public FilterBuilder UseMin(int value)
        {
            min = value;
            return this;
        }

        public FilterBuilder UseMax(int value)
        {
            max = value;
            return this;
        }

        public FilterBuilder UseUnique()
        {
            isUnique = true;
            return this;
        }

        public FilterBuilder UsePattern(string value)
        {
            Regex.Match("", pattern);
            pattern = value;
            return this;
        }

        public Filter Build()
        {
            return new Filter(this);
        }
    }
}
