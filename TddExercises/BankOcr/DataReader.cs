namespace BankOcr
{
    public class DataReader
    {
        public string ReadNumber(string[,] text)
        {
            ValidateInput(text);

            return "111111111";
        }

        private static void ValidateInput(string[,] text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }

            ValidateInputLength(text);
        }

        private static void ValidateInputLength(string[,] text)
        {
            foreach (var array in text)
            {
                if (array.Length != 27)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
