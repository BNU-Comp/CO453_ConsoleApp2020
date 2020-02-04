using NUnit.Framework;
using CO453_ConsoleApp2020.Unit4;

namespace NUnitTests
{
    public class TestDistanceConverter
    {
        T41_DistanceConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new T41_DistanceConverter();
        }

        [Test]
        public void TestMilesToFeet()
        {
            double miles = 1;
            double feet = converter.ToFeet(miles);
            Assert.AreEqual(feet, T41_DistanceConverter.FEET_IN_MILES);
        }
    }
}