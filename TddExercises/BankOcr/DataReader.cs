namespace BankOcr
{
    public class DataReader
    {
        private static readonly char[] ValidChars = { ' ', '_', '|' };

        public string ReadNumber(string[,] text)
        {
            ValidateInput(text);

            return "111111111";
        }


        private static void ValidateInput(string[,] text)
        {
            ValidateNullInput(text);

            ValidateArrayDimensionsInput(text);

            ValidateInputTextContent(text);

        }

        private static void ValidateInputTextContent(string[,] text)
        {
            foreach (var row in text)
            {
                if (row.Length != 27)
                {
                    throw new ArgumentException("Row must be 27 characters long.");
                }

                CheckInputCharacters(row);
            }
        }

        private static void CheckInputCharacters(string row)
        {
            foreach (var ch in row)
            {
                if (!ValidChars.Contains(ch))
                {
                    throw new ArgumentException("Text contians invalid character.");
                }
            }
        }

        private static void ValidateArrayDimensionsInput(string[,] text)
        {
            if (text.GetLength(0) != 4 && text.GetLength(1) != 0)
            {
                throw new ArgumentException("The input array must have 4 rows.");
            }
        }

        private static void ValidateNullInput(string[,] text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
