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
            
        private readonly string[,] one = {
            {"   "},
            {"  |"},
            {"  |"},
            {"   "}
        };

        private readonly string[,] two = {
            {" _ "},
            {" _|"},
            {"|_ "},
            {"   "}
        };

        private string[,] three = {
            {" _ "},
            {" _|"},
            {" _|"},
            {"   "}
        };

        public string ReadNumber(string[,] text)
        {
            ValidateInput(text);

            StringBuilder outputDigits = new StringBuilder();

            for (int digit = 0; digit < maxDigitNums; digit++)
            {
                string recognizedDigit = RecognizeDigit(text, outputDigits, digit);
                outputDigits.Append(recognizedDigit);
            }

            return outputDigits.ToString();
        }

        private string RecognizeDigit(string[,] text, StringBuilder outputDigits, int digit)
        {
            if (IsMatch(text, digit, one))
            {
                return "1";
            }
            if (IsMatch(text, digit, two))
            {
                return "2";
            }
            if (IsMatch(text, digit, three))
            {
                return "3";
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
            if (text.GetLength(0) != 4 && text.GetLength(1) != 0)
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
