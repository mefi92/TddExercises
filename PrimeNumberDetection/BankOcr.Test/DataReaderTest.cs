namespace BankOcr.Test
{
    [TestClass]
    public class DataReaderTest
    {
        public string[,] one = {
            {"   "},
            {"  |"},
            {"  |"},
            {"   "}
        };

        public string[,] onetwo = {
            {"    _  _ "},
            {"  | _| _|"},
            {"  ||_  _|"},
            {"         "}
        };

        [TestMethod]
        public void ShouldIdentifyOne()
        {
            DataReader reader = new DataReader();

            Assert.AreEqual(1, reader.ReadNumber(one));
        }

        [TestMethod]
        public void ShouldIdentifyOneTwo()
        {
            DataReader reader = new DataReader();

            Assert.AreEqual(12, reader.ReadNumber(onetwo));
        }
    }
}