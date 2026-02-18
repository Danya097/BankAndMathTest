using Xunit;
using SimpleMathApp;

namespace SimpleMathApp.Tests
{
    public class SimpleMathTests
    {
        private readonly SimpleMath _math = new SimpleMath();

        [Fact]
        public void Add_TwoNumbers_ShouldReturnSum()
        {
            Assert.Equal(5, _math.Add(2, 3));
        }

        [Fact]
        public void Subtract_TwoNumbers_ShouldReturnDifference()
        {
            Assert.Equal(2, _math.Subtract(5, 3));
        }

        [Fact]
        public void Multiply_TwoNumbers_ShouldReturnProduct()
        {
            Assert.Equal(15, _math.Multiply(5, 3));
        }

        [Fact]
        public void Divide_ValidNumbers_ShouldReturnQuotient()
        {
            Assert.Equal(2, _math.Divide(6, 3));
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _math.Divide(6, 0));
        }
    }
}