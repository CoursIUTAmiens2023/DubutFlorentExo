using CalculatorClass;
using Bogus;

namespace TestsExemple
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator m_Calculator = new ();

        [TestMethod]
        public void AddMethod_ShouldReturnSumOfNumber()
        {
            int v_Nombre1 = 5;
            int v_Nombre2 = 9;

            int v_Sum = v_Nombre1 + v_Nombre2;

            int v_Result = m_Calculator.Add(v_Nombre1, v_Nombre2);
        
            Assert.AreEqual(v_Sum, v_Result);
        }

        [TestMethod]
        public void SubtractMethod_ShouldReturnSubtactOfTwoNumber()
        {
            int v_Nombre1 = 5;
            int v_Nombre2 = 9;

            int v_Sum = v_Nombre1 - v_Nombre2;

            int v_Result = m_Calculator.Subtract(v_Nombre1, v_Nombre2);

            Assert.AreEqual(v_Sum, v_Result);
        }

        [TestMethod]
        public void MultiplyMethod_ShouldReturnMultiplyOfNumber()
        {
            int v_Nombre1 = 5;
            int v_Nombre2 = 9;

            int v_Sum = v_Nombre1 * v_Nombre2;

            int v_Result = m_Calculator.Multiply(v_Nombre1, v_Nombre2);

            Assert.AreEqual(v_Sum, v_Result);
        }

        [TestMethod]
        public void DivideMethod_ShouldReturnNumber1DividedByNumber2()
        {
            int v_Nombre1 = 5;
            int v_Nombre2 = 9;

            int v_Sum = v_Nombre1 / v_Nombre2;

            int v_Result = m_Calculator.Divide(v_Nombre1, v_Nombre2);

            Assert.AreEqual(v_Sum, v_Result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Division by zero is not allowed.")]
        public void DivideMethod_WhenDividedByZero_ShouldReturnError()
        {
            int v_Nombre1 = 5;
            int v_Nombre2 = 0;

            int v_Result = m_Calculator.Divide(v_Nombre1, v_Nombre2);
        }
    }
}