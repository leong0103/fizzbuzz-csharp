namespace FizzBuzz.Rules
{
    public class ReverseRule : IApplyable
    {
        public int Divisor { get; set; }

        public ReverseRule(int divisor)
        {
            Divisor = divisor;
        }

        public List<string> Apply(List<string> previous, int number)
        {
            if (number % Divisor != 0)
            {
                return previous;
            }

            var output = new List<string>(previous);
            output.Reverse();
            return output;
        }
    }
}