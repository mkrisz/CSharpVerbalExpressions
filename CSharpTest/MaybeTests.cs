using CSharpVerbalExpressions;
using NUnit.Framework;

namespace VerbalExpressionsUnitTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MaybeTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Maybe_WhenCalled_UsesCommonRegexUrl()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.Maybe(CommonRegex.Url);

            Assert.IsTrue(verbEx.IsMatch("http://www.google.com"), "Should match url address");
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Maybe_WhenCalled_UsesCommonRegexEmail()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.Maybe(CommonRegex.Email);

            Assert.IsTrue(verbEx.IsMatch("test@github.com"), "Should match email address");
        }
    }
}
