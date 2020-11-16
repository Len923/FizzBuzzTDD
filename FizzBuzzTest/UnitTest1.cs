using FizzBuzzApp;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class Tests
    {
        /*
         Players generally sit in a circle. The player designated to go first says the number "1", and the players then count upwards in turn.
         However, any number divisible by three is replaced by the word fizz and any number divisible by five by the word buzz.
         Numbers divisible by 15 become fizz buzz.
         */

        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz(100);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(10)]
        public void FizzBuzzReturnsNumbersOutsideThreeFiveAsNumbers(int input)
        {
            string output = fizzBuzz.check(input);

            Assert.AreEqual(input.ToString(), output);
        }
    }
}