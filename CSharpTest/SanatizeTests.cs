using System;
using CSharpVerbalExpressions;
using NUnit.Framework;

namespace VerbalExpressionsUnitTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SanatizeTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Sanitize_Handles_Null_String()
        {
            //Arrange
            var verbEx = VerbalExpressions.DefaultExpression;
            string value = null;

            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => verbEx.Sanitize(value));
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Sanitize_AddCharactersThatShouldBeEscaped_ReturnsEscapedString()
        {
            //Arrange
            var verbEx = VerbalExpressions.DefaultExpression;
            string value = "*+?";
            string result = string.Empty;
            string expected = @"\*\+\?";

            //Act
            result = verbEx.Sanitize(value);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
