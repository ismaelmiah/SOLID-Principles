using NUnit.Framework;
using OCP;

namespace NUnitTest
{
    public class OcpTests
    {
        private DiscountCalculate _discountCalculate;

        [SetUp]
        public void Setup()
        {
            _discountCalculate = new DiscountCalculate();
        }

        [Test]
        public void ReturnTenPercentage()
        {
            var result = _discountCalculate.CalculateDiscount(100, "Summer");
            Assert.AreEqual(10.0, result);
        }
        [Test]
        public void ReturnTwentyPercentage()
        {
            var result = _discountCalculate.CalculateDiscount(100, "Spring");
            Assert.AreEqual(20.0, result);
        }
        [Test]
        public void ReturnThirtyPercentage()
        {
            var result = _discountCalculate.CalculateDiscount(100, "Eid");
            Assert.AreEqual(30.0, result);
        }
        [Test]
        public void ReturnTwentyFivePercentage()
        {
            var result = _discountCalculate.CalculateDiscount(100, "Winter");
            Assert.AreEqual(25.0, result);
        }
    }
}