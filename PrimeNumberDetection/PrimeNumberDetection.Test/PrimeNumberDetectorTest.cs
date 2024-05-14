namespace PrimeNumberDetection.Test
{
    [TestClass]
    public class PrimeNumberDetectorTest
    {
        [TestMethod]
        public void IsPrime_3_ReturnsTrue()
        {
            PrimeNumberDetector primeNumberDetector = new PrimeNumberDetector();
            Assert.IsTrue(primeNumberDetector.IsPrime(3));
        }

        [TestMethod]
        public void IsPrime_4_ReturnsFalse()
        {
            PrimeNumberDetector primeNumberDetector = new PrimeNumberDetector();
            Assert.IsFalse(primeNumberDetector.IsPrime(4));
        }
    }
}