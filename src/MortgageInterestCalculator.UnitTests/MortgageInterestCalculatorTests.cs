using App.Logic;

namespace App.Logic.UnitTests
{
    // ClassTests

    [TestClass]
    public class MortgageInterestCalculatorTests
    {

        //[TestMethod]
        //public void Method_Scenario_ExpectedBehavior()
        //{
        //}
        
        // OverLimit


        DateTime LeapYear = new DateTime(2024, 1, 1);
        DateTime NoLeapYear = new DateTime(2023, 1, 1);

        /*
         *
        [TestMethod]
        public void Calculate_LeapYear1_ReturnsInterest()
        {
            // Arrange - przygotowanie przypadku testowego (scenariusza) do testu
            MortgageInterestCalculator calculator = new MortgageInterestCalculator(LeapYear);

            // Act - czynnoœæ 
            decimal result = calculator.Calculate(150000, 6m);

            // Assert - weryfikacja zwracanych wyników
            Assert.AreEqual(762, result);
        }

        [TestMethod]
        public void Calculate_LeapYear2_ReturnsInterest()
        {
            // Arrange - przygotowanie przypadku testowego (scenariusza) do testu
            MortgageInterestCalculator calculator = new MortgageInterestCalculator(LeapYear);

            // Act - czynnoœæ 
            decimal result = calculator.Calculate(300000, 6m);

            // Assert - weryfikacja zwracanych wyników
            Assert.AreEqual(1525, result);
        }

        */

        [TestMethod]
        [DataRow(150000, 6, 762)]
        [DataRow(300000, 6, 1525)]        
        public void Calculate_LeapYear_ReturnsInterest(int leftToPaid, int rate, int expected)
        {
            // Arrange - przygotowanie przypadku testowego (scenariusza) do testu
            MortgageInterestCalculator calculator = new MortgageInterestCalculator(LeapYear);

            // Act - czynnoœæ 
            decimal result = calculator.Calculate(leftToPaid, rate);

            // Assert - weryfikacja zwracanych wyników
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_NoLeapYear_ReturnsInterest()
        {
            // Arrange - przygotowanie przypadku testowego (scenariusza) do testu
            MortgageInterestCalculator calculator = new MortgageInterestCalculator(NoLeapYear);

            // Act - czynnoœæ 
            decimal result = calculator.Calculate(150000, 6m);

            // Assert - weryfikacja zwracanych wyników
            Assert.AreEqual(764, result);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Calculate_LeftToPaidIsZero_ShouldThrowsInvalidOperationException()
        {
            // Arrange
            MortgageInterestCalculator calculator = new MortgageInterestCalculator();

            // Act
            calculator.Calculate(0, 1);

            // Assert
        }

        [TestMethod]
        public void Calculate_RateIsZero_ReturnsZero()
        {
            // Arrange
            MortgageInterestCalculator calculator = new MortgageInterestCalculator();

            // Act
            decimal result = calculator.Calculate(1, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void Calculate_LeftToPaidIsNegative_ShouldThrowsApplicationException()
        {
            // Arrange
            MortgageInterestCalculator calculator = new MortgageInterestCalculator();

            // Act
            calculator.Calculate(-1, 1);

            // Assert
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_RateIsNegative_ShouldThrowsArgumentOutOfRangeException()
        {
            // Arrange
            MortgageInterestCalculator calculator = new MortgageInterestCalculator();

            // Act
            calculator.Calculate(1, -1);

            // Assert
        }
    }
}