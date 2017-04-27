using System;
using CSharpVerbalExpressions;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace CSharpTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class OwnUnitTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void RegexCacheGetMethodException()
        {
            RegexCache rc = new RegexCache();
            Assert.Throws<ArgumentNullException>(() => rc.Get(null, RegexOptions.Multiline));
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void RegexCacheGetMethodOption()
        {
            RegexCache rc = new RegexCache();
            var r = rc.Get("pista", RegexOptions.Multiline);
            Assert.IsTrue(r.Options == RegexOptions.Multiline);
        }
    }
}
