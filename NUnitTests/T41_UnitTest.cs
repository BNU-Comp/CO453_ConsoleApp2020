using NUnit.Framework;
using CO453_ConsoleApp2020.Unit4;

namespace NUnitTests
{
    /// <summary>
    /// This class tests the Distance Converter whcih can convert miles
    /// to feet, or feet to miles
    ///  
    /// Author:  Dr Derek Peacock
    /// Module:  CO453
    /// Task:    4.1
    /// Updated: 04/Feb/2020
    /// </summary>
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