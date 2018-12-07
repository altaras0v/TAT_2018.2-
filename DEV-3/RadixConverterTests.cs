using NUnit.Framework;
namespace RadixConverter

{
    [TestFixture()]
    public class NumberConverterTests
    {
        [Test()]
        public void Add_MaxValueInt_And_NumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int maxValueInt = int.MaxValue;
            const int numberNewSystemRadix = 2;

            //Act
            var actual = converter.ToNewBaseConverter(maxValueInt, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("21474836470000000000", actual);
        }

        [Test()]
        public void Add_MinValueInt_And_NumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int maxValueInt = int.MinValue;
            const int numberNewSystemRadix = 2;

            //Act
            var actual = converter.ToNewBaseConverter(maxValueInt, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("21474836470000000000", actual);
        }

        [Test()]
        public void Add_IntegerNumber_And_DecimalNumber_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 2;
            const int numberNewSystemRadix = 10;

            //Act
            var actual = converter.ToNewBaseConverter(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("2", actual);
        }

        [Test()]
        public void Add_PossitiveEvenNumber_And_EvenNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 100;
            const int numberNewSystemRadix = 2;

            //Act
            var actual = converter.ToNewBaseConverter(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("1100100", actual);
        }

        [Test()]
        public void Add_NegativeEvenNumber_And_EvenNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = -100;
            const int numberNewSystemRadix = 2;

            //Act
            var actual = converter.ToNewBaseConverter(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("1100100", actual);
        }

        [Test()]
        public void Add_Number_And_MaxValueNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 999;
            const int numberNewSystemRadix = 20;

            //Act
            var actual = converter.ToNewBaseConverter(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("29J", actual);
        }

        [Test()]
        public void Add_ZeroNumber_And_NumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 0;
            const int numberNewSystemRadix = 10;

            //Act
            var actual = converter.ToNewBaseConverter(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("0", actual);
        }

        [Test()]
        public void Add_PossitiveOddNumber_And_EvenNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 1000;
            const int numberNewSystemRadix = 7;

            //Act
            var actual = converter.ToNewBaseConverter(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("2626", actual);
        }

        [Test()]
        public void Add_PossitiveOddNumber_And_OddNumberNewSystemRadix_ReturnNewNumber()
        {
            //Arrange
            var converter = CreateObjectNumberConverter();
            const int number = 1001;
            const int numberNewSystemRadix = 3;

            //Act
            var actual = converter.ToNewBaseConverter(number, numberNewSystemRadix);

            //Assert
            Assert.AreEqual("1101002", actual);
        }

        private CoverterToNewSystem CreateObjectNumberConverter()
        {
            return new CoverterToNewSystem();
        }
    }
}
