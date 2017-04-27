using CSharpVerbalExpressions;
using NUnit.Framework;

namespace VerbalExpressionsUnitTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ThenTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Then_VerbalExpressionsEmail_DoesMatchEmail()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.StartOfLine().Then(CommonRegex.Email);

            var isMatch = verbEx.IsMatch("test@github.com");
            Assert.IsTrue(isMatch, "Should match email address");
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Then_VerbalExpressionsEmail_DoesNotMatchUrl()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.StartOfLine().Then(CommonRegex.Email);

            var isMatch = verbEx.IsMatch("http://www.google.com");
            Assert.IsFalse(isMatch, "Should not match url address");
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Then_VerbalExpressionsUrl_DoesMatchUrl()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.StartOfLine()
                  .Then(CommonRegex.Url);

            Assert.IsTrue(verbEx.IsMatch("http://www.google.com"), "Should match url address");
            Assert.IsTrue(verbEx.IsMatch("https://www.google.com"), "Should match url address");
            Assert.IsTrue(verbEx.IsMatch("http://google.com"), "Should match url address");
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Then_VerbalExpressionsUrl_DoesNotMatchEmail()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.StartOfLine().Then(CommonRegex.Url);

            Assert.IsFalse(verbEx.IsMatch("test@github.com"), "Should not match email address");
        }
    }
}
