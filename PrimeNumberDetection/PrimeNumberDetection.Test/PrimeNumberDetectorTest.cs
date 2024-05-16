namespace PrimeNumberDetection.Test
{
    [TestClass]
    public class PrimeNumberDetectorTest
    {
        PrimeNumberDetector primeNumberDetector;

        [TestInitialize]
        public void TestInitialize()
        {
            primeNumberDetector = new PrimeNumberDetector();
        }

        [TestMethod]
        public void IsItPrime_1_RetrunsFalse()
        {
            Assert.IsFalse(primeNumberDetector.IsItPrime(1));
        }

        [TestMethod]
        public void IsItPrime_2_RetrunsTrue()
        {
            Assert.IsTrue(primeNumberDetector.IsItPrime(2));
        }

        [TestMethod]
        public void IsItPrime_3_RetrunsTrue()
        {
            Assert.IsTrue(primeNumberDetector.IsItPrime(3));
        }

        [TestMethod]
        public void IsItPrime_4_RetrunsFalse()
        {
            Assert.IsFalse(primeNumberDetector.IsItPrime(4));
        }

        [TestMethod]
        public void IsItPrime_5_RetrunsTrue()
        {
            Assert.IsTrue(primeNumberDetector.IsItPrime(5));
        }

        [TestMethod]
        public void IsItPrime_7_RetrunsTrue()
        {
            Assert.IsTrue(primeNumberDetector.IsItPrime(7));
        }

        [TestMethod]
        public void IsItPrime_10_RetrunsFalse()
        {
            Assert.IsFalse(primeNumberDetector.IsItPrime(10));
        }

        [TestMethod]
        public void IsItPrime_89_RetrunsFalse()
        {
            Assert.IsTrue(primeNumberDetector.IsItPrime(89));
        }
 

        [TestMethod]
        public void IsItPrime_From_1_To_100()
        {
            int[] primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];

            bool expected = false;


            for (int i = 1; i <= 100; i++) 
            {
                if (primes.Contains(i)) { expected = true; }
                else { expected = false; }

                Assert.AreEqual(expected, primeNumberDetector.IsItPrime(i));                
            }
        }

    }
}