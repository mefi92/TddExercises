namespace BankOcr.Test
{
    [TestClass]
    public class DataReaderTest
    {
        public string[,] validOnlyOne = {
            {"                           "},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] validOnlyTwo = {
            {" _  _  _  _  _  _  _  _  _ "},
            {" _| _| _| _| _| _| _| _| _|"},
            {"|_ |_ |_ |_ |_ |_ |_ |_ |_ "},
            {"                           "}
        };

        public string[,] threeArrays = {            
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] fiveArrays = {
            {"                           "},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "},
            {"                           "}
        };

        public string[,] shortArray = {
            {"                          "},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] longArray = {
            {"                            "},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };        

        public string[,] invalidCharacter = {
            {"                           "},
            {"  |  |  |  a  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] forthRowNotEmpty = {
            {"                           "},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |                        "}
        };

        public string[,] onetwo = {
            {"    _  _ "},
            {"  | _| _|"},
            {"  ||_  _|"},
            {"         "}
        };

        [TestMethod]
        public void ValidateInput_OnlyOnes_Returns1x9()
        {
            string expected = "111111111";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyOne);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlyTwos_Returns2x9()
        {
            string expected = "222222222";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyTwo);

            Assert.AreEqual(expected, output);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullInput_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_ShortInput_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(shortArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_LongInput_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(longArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_ThreeLines_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(threeArrays);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_FiveLines_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(fiveArrays);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_InvalidCharacter_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(invalidCharacter);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_ForthRowNotEmtpy_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(forthRowNotEmpty);
        }




        //[TestMethod]
        //public void ShouldIdentifyOne()
        //{
        //    DataReader reader = new DataReader();

        //    Assert.AreEqual(1, reader.ReadNumber(one));
        //}

        //[TestMethod]
        //public void ShouldIdentifyOneTwo()
        //{
        //    DataReader reader = new DataReader();

        //    Assert.AreEqual(12, reader.ReadNumber(onetwo));
        //}



        // x valid-e a beadott tömb 27 oszlop 4 sor
        // x megfelelõ karakterek vannak e benne: | _ space
        // x 4. sor üres
        // 9db 1-es felismerése
        // minden karakter x9 felismerése


    }
}