using System;
using Xunit;

namespace FizzBuzzBaz
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3,"fizz")]
        [InlineData(5, "buzz")]
        [InlineData(15, "fizzbuzz")]
        [InlineData(35, "fizzbuzzbaz")]
        [InlineData(2, "")]

        public void Fizz(int a, string b)
        {
            Assert.Equal(b,FBB.Fizz2(a));
        }
    }
}
