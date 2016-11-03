using VerifyContainer;
using Xunit;

namespace VerifyThatUnitTest.UnitTests
{
    public class StringUnitTest
    {
        [Theory]
        [InlineData("hello","hello")]
        [InlineData("Hello", "Hello")]
        [InlineData("Vishal Anand", "Vishal Anand")]
        public void VerifyIfStringsAreEqual(string expected, string got)
        {
            Verify.ThatStringsAreEqual(expected, got);
        }
    }
}
