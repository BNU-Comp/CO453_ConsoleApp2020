using CO453_ConsoleApp2020.Unit4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MS_UnitTests
{
    [TestClass]
    public class T41_UnitTest
    {
        T41_DistanceConverter converter;

        [TestInitialize]
        public void Setup()
        {
            converter = new T41_DistanceConverter();
        }

        [TestMethod]
        public void TestDistanceConverter()
        {
            double miles = 1;
            double feet = converter.ToFeet(miles);
            Assert.AreEqual(feet, T41_DistanceConverter.FEET_IN_MILES);
        }
    }
}
