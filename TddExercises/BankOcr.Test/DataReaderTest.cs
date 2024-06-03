namespace BankOcr.Test
{
    [TestClass]
    public class DataReaderTest
    {

        public string[,] oneInput = {
            {"   "},
            {"  |"},
            {"  |"},
            {"   "}            
        };

        public string[,] validOnlyOnes = {
            {"                           "},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] validOnlyTwos = {
            {" _  _  _  _  _  _  _  _  _ "},
            {" _| _| _| _| _| _| _| _| _|"},
            {"|_ |_ |_ |_ |_ |_ |_ |_ |_ "},
            {"                           "}
        };

        public string[,] validOnlyThrees = {
            {" _  _  _  _  _  _  _  _  _ "},
            {" _| _| _| _| _| _| _| _| _|"},
            {" _| _| _| _| _| _| _| _| _|"},
            {"                           "}
        };

        public string[,] validOnlyFours = {
            {"                           "},
            {"|_||_||_||_||_||_||_||_||_|"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] validOnlyFives = {
            {" _  _  _  _  _  _  _  _  _ "},
            {"|_ |_ |_ |_ |_ |_ |_ |_ |_ "},
            {" _| _| _| _| _| _| _| _| _|"},
            {"                           "}
        };

        public string[,] validOnlySixes = {
            {" _  _  _  _  _  _  _  _  _ "},
            {"|_ |_ |_ |_ |_ |_ |_ |_ |_ "},
            {"|_||_||_||_||_||_||_||_||_|"},
            {"                           "}
        };

        public string[,] validOnlySevens = {
            {" _  _  _  _  _  _  _  _  _ "},
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] validOnlyEights = {
            {" _  _  _  _  _  _  _  _  _ "},
            {"|_||_||_||_||_||_||_||_||_|"},
            {"|_||_||_||_||_||_||_||_||_|"},
            {"                           "}
        };

        public string[,] validOnlyNines = {
            {" _  _  _  _  _  _  _  _  _ "},
            {"|_||_||_||_||_||_||_||_||_|"},
            {" _| _| _| _| _| _| _| _| _|"},
            {"                           "}
        };

        public string[,] validOneToNine = {
            {"    _  _     _  _  _  _  _ "},
            {"  | _| _||_||_ |_   ||_||_|"},
            {"  ||_  _|  | _||_|  ||_| _|"},
            {"                           "}
        };

        public string[,] threeRowsInput = {            
            {"  |  |  |  |  |  |  |  |  |"},
            {"  |  |  |  |  |  |  |  |  |"},
            {"                           "}
        };

        public string[,] fiveRowsInput = {
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

        public string[,] oneTwoThreeUnknown = {
            {"    _  _                   "},
            {"  | _| _|                  "},
            {"  ||_  _|                  "},
            {"                           "}
        };

        public string[,] emptyInput = {
            {"                           "},
            {"                           "},
            {"                           "},
            {"                           "}
        };

        [TestMethod]
        public void ValidateInput_OnlyOnes_Returns1x9()
        {
            string expected = "111111111";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyOnes);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlyTwos_Returns2x9()
        {
            string expected = "222222222";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyTwos);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlyThrees_Returns3x9()
        {
            string expected = "333333333";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyThrees);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlyFours_Returns4x9()
        {
            string expected = "444444444";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyFours);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlyFives_Returns5x9()
        {
            string expected = "555555555";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyFives);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlySixes_Returns6x9()
        {
            string expected = "666666666";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlySixes);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlySevens_Returns7x9()
        {
            string expected = "777777777";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlySevens);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlyEights_Returns8x9()
        {
            string expected = "888888888";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyEights);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OnlyNines_Returns9x9()
        {
            string expected = "999999999";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOnlyNines);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OneToNince_Returns123456789()
        {
            string expected = "123456789";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(validOneToNine);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_OneTwoThreeUnknown_Returns123Questionmarks()
        {
            string expected = "123??????";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(oneTwoThreeUnknown);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ValidateInput_EmptyInput_ReturnsQuestionmarks()
        {
            string expected = "?????????";

            DataReader reader = new DataReader();
            string output = reader.ReadNumber(emptyInput);

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
            reader.ReadNumber(threeRowsInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateInput_FiveLines_ReturnsException()
        {
            DataReader reader = new DataReader();
            reader.ReadNumber(fiveRowsInput);
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