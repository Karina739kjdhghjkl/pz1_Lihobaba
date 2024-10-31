using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinomialApp.Tests
{
    [TestClass]
    public class BinomialTests
    {
        [TestMethod]
        public void Add_TwoBinomials_ReturnsCorrectResult()
        {
            // Arrange
            IBinomial binomial1 = new Binomial(2, 3);
            IBinomial binomial2 = new Binomial(4, 5);

            // Act
            IBinomial result = binomial1.Add(binomial2);

            // Assert
            Assert.AreEqual(new Binomial(6, 8), result);
        }

        [TestMethod]
        public void Subtract_TwoBinomials_ReturnsCorrectResult()
        {
            // Arrange
            IBinomial binomial1 = new Binomial(5, 7);
            IBinomial binomial2 = new Binomial(3, 4);

            // Act
            IBinomial result = binomial1.Subtract(binomial2);

            // Assert
            Assert.AreEqual(new Binomial(2, 3), result);
        }

        [TestMethod]
        public void MultiplyBy_Number_ReturnsCorrectResult()
        {
            // Arrange
            IBinomial binomial = new Binomial(2, 3);
            double multiplier = 2;

            // Act
            IBinomial result = binomial.MultiplyBy(multiplier);

            // Assert
            Assert.AreEqual(new Binomial(4, 6), result);
        }

        [TestMethod]
        public void AddNumber_ToBinomial_ReturnsCorrectResult()
        {
            // Arrange
            IBinomial binomial = new Binomial(2, 3);
            double numberToAdd = 5;

            // Act
            IBinomial result = binomial.AddNumber(numberToAdd);

            // Assert
            Assert.AreEqual(new Binomial(7, 3), result);
        }

        [TestMethod]
        public void Calculate_ForGivenX_ReturnsCorrectValue()
        {
            // Arrange
            IBinomial binomial = new Binomial(2, 3);
            double x = 4;

            // Act
            double result = binomial.Calculate(x);

            // Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void SolveEquation_HasSolution_ReturnsCorrectResult()
        {
            // Arrange
            IBinomial binomial = new Binomial(2, 3);

            // Act
            double? result = binomial.SolveEquation();

            // Assert
            Assert.AreEqual(-2.0 / 3, result);
        }

        [TestMethod]
        public void SolveEquation_NoSolution_ReturnsNull()
        {
            // Arrange
            IBinomial binomial = new Binomial(2, 0);

            // Act
            double? result = binomial.SolveEquation();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SolveEquation_InfiniteSolutions_ReturnsNull()
        {
            // Arrange
            IBinomial binomial = new Binomial(0, 0);

            // Act
            double? result = binomial.SolveEquation();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Equals_SameBinomials_ReturnsTrue()
        {
            // Arrange
            IBinomial binomial1 = new Binomial(2, 3);
            IBinomial binomial2 = new Binomial(2, 3);

            // Act & Assert
            Assert.IsTrue(binomial1.Equals(binomial2));
        }

        [TestMethod]
        public void Equals_DifferentBinomials_ReturnsFalse()
        {
            // Arrange
            IBinomial binomial1 = new Binomial(2, 3);
            IBinomial binomial2 = new Binomial(5, 7);

            // Act & Assert
            Assert.IsFalse(binomial1.Equals(binomial2));
        }
    }
}
