using CSharpVerbalExpressions;
using NUnit.Framework;
using System;

namespace VerbalExpressionsUnitTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MultipleTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Multiple_WhenNullOrEmptyValueParameterIsPassed_ShouldThrowArgumentException()
        {
            //Arrange
            var verbEx = VerbalExpressions.DefaultExpression;
            string value = null;

            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => verbEx.Multiple(value));
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Multiple_WhenParamIsGiven_ShouldMatchOneOrMultipleValuesGiven()
        {
            //Arrange
            var verbEx = VerbalExpressions.DefaultExpression;
            string text = "testesting 123 yahoahoahou another test";
            string expectedExpression = "y(aho)+u";
            //Act
            verbEx.Add("y")
                .Multiple("aho")
                .Add("u");

            //Assert
            Assert.IsTrue(verbEx.Test(text));
            Assert.AreEqual(expectedExpression, verbEx.ToString());
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Multiple_WhenNullArgumentPassed_ThrowsArgumentNullException()
        {
            //Arrange
            var verbEx = VerbalExpressions.DefaultExpression;
            string argument = string.Empty;

            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => verbEx.Multiple(argument));
        }
    }
}
