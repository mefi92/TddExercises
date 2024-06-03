using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace BankOcr
{
    public class DataReader
    {
        const int maxDigitNums = 9;
        const int lengthOfDigit = 3;
        const int numOfRows = 4;

        private readonly Dictionary<string, string[,]> digitPatterns = new Dictionary<string, string[,]>
        {
            { "0", new string[,] { { " _ " }, { "| |" }, { "|_|" }, { "   " } } },
            { "1", new string[,] { { "   " }, { "  |" }, { "  |" }, { "   " } } },
            { "2", new string[,] { { " _ " }, { " _|" }, { "|_ " }, { "   " } } },
            { "3", new string[,] { { " _ " }, { " _|" }, { " _|" }, { "   " } } },
            { "4", new string[,] { { "   " }, { "|_|" }, { "  |" }, { "   " } } },
            { "5", new string[,] { { " _ " }, { "|_ " }, { " _|" }, { "   " } } },
            { "6", new string[,] { { " _ " }, { "|_ " }, { "|_|" }, { "   " } } },
            { "7", new string[,] { { " _ " }, { "  |" }, { "  |" }, { "   " } } },
            { "8", new string[,] { { " _ " }, { "|_|" }, { "|_|" }, { "   " } } },
            { "9", new string[,] { { " _ " }, { "|_|" }, { " _|" }, { "   " } } },
        };

        public string ReadNumber(string[,] text)
        {
            ValidateInput(text);

            return GetDigitsString(text);
        }

        private string GetDigitsString(string[,] text)
        {
            StringBuilder outputDigits = new StringBuilder();

            for (int digit = 0; digit < maxDigitNums; digit++)
            {
                string recognizedDigit = RecognizeDigit(text, digit);
                outputDigits.Append(recognizedDigit);
            }

            return outputDigits.ToString();
        }

        private string RecognizeDigit(string[,] text, int digit)
        {
            foreach (var pattern in digitPatterns) 
            {
                if (IsMatch(text, digit, pattern.Value))
                {
                    return pattern.Key;
                }

            }              
            return "?";

        }

        private bool IsMatch(string[,] text, int digit, string[,] digitPattern)
        {
            for (int row = 0; row < numOfRows; row++)
            {
                int actDigit = digit * lengthOfDigit;
                if (text[row, 0].Substring(actDigit, lengthOfDigit) != digitPattern[row, 0])
                {
                    return false;
                }
            }
            return true;
        }

        private static void ValidateInput(string[,] text)
        {
            ValidateNullInput(text);

            ValidateArrayDimensionsInput(text);

            ValidateInputTextContent(text);

        }

        private static void ValidateInputTextContent(string[,] text)
        {
            char[] validCharsNormal = { ' ', '_', '|' };
            char[] validCharForthLine = { ' ' };

            for (int row=0; row<text.GetLength(0); row++)
            {
                string line = text[row, 0];

                if (line.Length != 27)
                {
                    throw new ArgumentException("Row must be 27 characters long.");
                }

                char[] validChars = row == 3 ? validCharForthLine : validCharsNormal; 
                CheckInputCharacters(line, validChars);

            }
            
        }

        private static void CheckInputCharacters(string row, char[] validChars)
        {
            foreach (var ch in row)
            {
                if (!validChars.Contains(ch))
                {
                    throw new ArgumentException("Text contians invalid character.");
                }
            }
        }

        private static void ValidateArrayDimensionsInput(string[,] text)
        {
            if (text.GetLength(0) != 4 && text.GetLength(1) != 0 || text.Length == 0)
            {
                throw new ArgumentException("The input array must have 4 rows.");
            }
        }

        private static void ValidateNullInput(string[,] text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("Invalid Null input.");
            }
        }
    }

        
    }
