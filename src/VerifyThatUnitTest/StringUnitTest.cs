namespace VerifyThatUnitTest
{
    using Xunit;
    using Verify;

    public class StringUnitTest
    {
        [Theory]
        [InlineData("hello","hello")]
        [InlineData("Hello", "Hello")]
        [InlineData("Vishal Anand", "Vishal Anand")]
        public void VerifyIfStringsAreEqual(string expected, string got)
        {
            Verify.ThatTheyAreEqual(expected, got);
        }
    }
}
