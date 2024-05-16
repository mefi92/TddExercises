namespace PrimeNumberDetection
{
    public class PrimeNumberDetector
    {
        public bool IsItPrime(int number)
        {
            if (number == 1 || number == 0) 
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
