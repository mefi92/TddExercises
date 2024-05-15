namespace PrimeNumberDetection.Test
{
    [TestClass]
    public class PrimeNumberDetectorTest
    {
        [TestMethod]
        public void IsDivisibleByTwo()
        {
            PrimeNumberDetector primeNumberDetector = new PrimeNumberDetector();
            Assert.IsFalse(primeNumberDetector.IsItPrimeNumber(2));
        }

        [TestMethod]
        public void IsDivisibleByThree()
        {
            PrimeNumberDetector primeNumberDetector = new PrimeNumberDetector();
            Assert.IsTrue(primeNumberDetector.IsItPrimeNumber(3));
        }

    }
}