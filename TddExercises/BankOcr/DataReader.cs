namespace BankOcr
{
    public class DataReader
    {
        public int ReadNumber(string[,] text)
        {
            if (text[0, 0][0] == ' ')
            { return 1; }
            else { return -1; }
        }
    }
}
