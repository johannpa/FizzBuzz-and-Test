using FizzBuzz.Services;

namespace FizzBuzz.UnitTests.Services
{
    public class FizzBuzzServiceTests
    {
        [Fact]
        public void GetFizzBuzz_Should_Return_1_If_1_IsPassed()
        {
            // 1. Arrange
            var service = new FizzBuzzService();

            // 2. Act
            var result = service.GetFizzBuzz(1);

            // 3. Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void GetFizzBuzz_Should_Return_2_If_2_IsPassed()
        {
            // 1. Arrange
            var service = new FizzBuzzService();

            // 2. Act
            var result = service.GetFizzBuzz(2);

            // 3. Assert
            Assert.Equal("2", result);
        }
    }
}