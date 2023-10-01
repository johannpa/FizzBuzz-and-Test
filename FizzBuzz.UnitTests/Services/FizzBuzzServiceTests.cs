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

        [Fact]
        public void GetFizzBuzz_Should_Return_Fizz_If_3_IsPassed()
        {
            // 1. Arrange
            var service = new FizzBuzzService();

            // 2. Act
            var result = service.GetFizzBuzz(3);

            // 3. Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GetFizzBuzz_Should_Return_Buzz_If_5_IsPassed()
        {
            // 1. Arrange
            var service = new FizzBuzzService();

            // 2. Act
            var result = service.GetFizzBuzz(5);

            // 3. Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void GetFizzBuzz_Should_Return_FizzBuzz_If_15_IsPassed()
        {
            // 1. Arrange
            var service = new FizzBuzzService();

            // 2. Act
            var result = service.GetFizzBuzz(15);

            // 3. Assert
            Assert.Equal("FizzBuzz", result);
        }
    }
}