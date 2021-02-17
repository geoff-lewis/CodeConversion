using System;
using NUnit.Framework;
using System.Globalization;
using CodeConversion.TypeConversion;

namespace CodeConversionTestNUnit
{
    public class Tests
    {
        [TestCase(null, "LeakIndicationIcon")]
        [TestCase(0, "LeakIndicationIcon")]
        [TestCase(1, "TheftIndicationIcon")]
        [TestCase(2, null)]
        [TestCase(LossIncidentType.Leak, "LeakIndicationIcon")]
        [TestCase(LossIncidentType.Theft, "TheftIndicationIcon")]
        public void Convert_WhenPassedValue_ReturnsExpectedResult(object value, object expectedResult)
        {
            var sut = new LossIncidentTypeToIconConverter();

            object result = sut.Convert(value, null, null, CultureInfo.CurrentCulture);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Convert_WhenPassedString_ThrowsFormatException()
        {
            var sut = new LossIncidentTypeToIconConverter();
            
            Assert.Throws<InvalidCastException>(() =>
            {
                sut.Convert("Test", null, null, CultureInfo.CurrentCulture);
            });
        }
    }
}