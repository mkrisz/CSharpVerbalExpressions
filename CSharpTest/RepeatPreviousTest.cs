using System.Text.RegularExpressions;
using CSharpVerbalExpressions;
using NUnit.Framework;

namespace VerbalExpressionsUnitTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class RepeatPreviousTests
    {

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void RepeatPrevious_WhenThreeA_RegesIsAsExpected()
        {
            // Arrange
            VerbalExpressions verbEx = VerbalExpressions.DefaultExpression;

            // Act
            verbEx.BeginCapture()
                  .Add("A")
                  .RepeatPrevious(3)
                  .EndCapture();

            // Assert
            Assert.AreEqual("(A{3})", verbEx.ToString());
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void RepeatPrevious_WhenBetweenTwoAndFourA_RegesIsAsExpected()
        {
            // Arrange
            VerbalExpressions verbEx = VerbalExpressions.DefaultExpression;

            // Act
            verbEx.BeginCapture()
                  .Add("A")
                  .RepeatPrevious(2, 4)
                  .EndCapture();

            // Assert
            Assert.AreEqual("(A{2,4})", verbEx.ToString());
        }

    }
}
