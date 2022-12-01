using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<IApplyable> rules = new List<IApplyable>()
            {
                new DivisibleRule(3, "Fizz"),
                new DivisibleRule(5, "Buzz"),
                new DivisibleRule(7, "Bang"),
                new OverwriteRule(11, "Bong"),
                new ReverseRule(17),
            };

            FizzBuzzer firstFizzBuzzer = new FizzBuzzer(rules);

            for (int i = 1; i <= 110; i++)
            {
                Console.WriteLine(firstFizzBuzzer.FizzBuzz(i));
            }
        }
    }
}