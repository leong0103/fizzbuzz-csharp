using FizzBuzz.Rules;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public List<IApplyable> Rules { get; set; }

        public FizzBuzzer(List<IApplyable> rules)
        {
            Rules = rules;
        }

        public string FizzBuzz(int number)
        {
            List<string> output = new List<string>();

            foreach (IApplyable rule in Rules)
            {
                output = rule.Apply(output, number);
            }

            if (output.Count == 0)
            {
                return number.ToString();
            }

            return string.Join("", output);
        }
    }
}