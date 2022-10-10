using SharedProject;

namespace UnitTests
{
    public class UnitTestModel
    {
        [Fact]
        public void TestMonthlyPaymentValidInputValidMonthlyPayment()
        {
            CalculationService calculation = new CalculationService();
            double monthlyPayment = calculation.MonthlyPayment(8000000.0, 6.0, 30);

            Assert.Equal(47964.04, monthlyPayment, 2);
        }
    }
}