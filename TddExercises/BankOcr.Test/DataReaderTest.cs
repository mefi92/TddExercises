namespace BankOcr.Test
{
    [TestClass]
    public class DataReaderTest
    {
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

        public string[,] onlyOne = {
            {"                           "},
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

        public string[,] onetwo = {
            {"    _  _ "},
            {"  | _| _|"},
            {"  ||_  _|"},
            {"         "}
        };

        [TestMethod]
        public void ValidateInput_ValidInput()
        {
            string expected = "111111111";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(onlyOne);

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



        // valid-e a beadott t�mb 27 oszlop 4 sor
        // megfelel� karakterek vannak e benne: | _ space
        // 4. sor �res
        // 9db 1-es felismer�se
        // minden karakter x9 felismer�se


    }
}