using FibonacciNumberGeneratorLibrary;

namespace FibonacciNumberGeneratorTestCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FibonacciNumberGeneratorTestCases()
        {
            Assert.That(FibonacciNumberGenerator.generateFibonacciNumber(1), Is.EqualTo (1));
        }
    }
}