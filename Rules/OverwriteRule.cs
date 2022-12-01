namespace FizzBuzz.Rules
{
    public class OverwriteRule : IApplyable
    {
        public int Divisor { get; set; }
        public string ToReplaceWith { get; set; }

        public OverwriteRule(int divisor, string toReplaceWith)
        {
            Divisor = divisor;
            ToReplaceWith = toReplaceWith;
        }

        public List<string> Apply(List<string> previous, int number)
        {
            if (number % Divisor != 0)
            {
                return previous;
            }

            return new List<string>() { ToReplaceWith };
        }
    }
}