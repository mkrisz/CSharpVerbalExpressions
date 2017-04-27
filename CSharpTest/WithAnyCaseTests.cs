using System.Text.RegularExpressions;
using CSharpVerbalExpressions;
using NUnit.Framework;

namespace VerbalExpressionsUnitTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class WithAnyCaseTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void WithAnyCase_AddwwwWithAnyCase_DoesMatchwWw()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.Add("www")
                .WithAnyCase();


            var isMatch = verbEx.IsMatch("wWw");
            Assert.IsTrue(isMatch, "Should match any case");
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void WithAnyCase_SetsCorrectIgnoreCaseRegexOptionAndHasMultiLineRegexOptionAsDefault()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.WithAnyCase();

            var regex = verbEx.ToRegex();
            Assert.IsTrue(regex.Options.HasFlag(RegexOptions.IgnoreCase), "RegexOptions should have ignoreCase");
            Assert.IsTrue(regex.Options.HasFlag(RegexOptions.Multiline), "RegexOptions should have MultiLine as default");
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void WithAnyCase_AddwwwWithAnyCaseFalse_DoesNotMatchwWw()
        {
            var verbEx = VerbalExpressions.DefaultExpression;
            verbEx.Add("www")
                .WithAnyCase(false);

            var isMatch = verbEx.IsMatch("wWw");
            Assert.IsFalse(isMatch, "Should not match any case");
        }
    }
}
