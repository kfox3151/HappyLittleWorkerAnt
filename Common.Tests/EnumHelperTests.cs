using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Tests
{
    [TestClass]
    public class EnumHelperTests
    {
        [TestMethod]
        public void GetRandomEnumDescription_ReturnsStringValue()
        {
            var result = EnumHelper.GetRandomEnumDescription<TestEnum>();
            var expected = "TestOne";

            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void GetRandomEnumDescriptionAndParse_DescriptionCantBeParsed()
        {
            var result = EnumHelper.GetRandomEnumDescriptionAndParse<TestEnum>();
            var expected = -1;

            Assert.AreEqual(expected,result);
        }
    }
}
