namespace FizzBuzz.Rules
{
    public interface IApplyable
    {
        List<string> Apply(List<string> previous, int number);
    }
}