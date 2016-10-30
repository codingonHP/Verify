using System.Collections.Generic;
using VerifyContainer;
using Xunit;

namespace VerifyThatUnitTest.UnitTests
{
    public class TypesUnitTest
    {
        [Fact]
        public void VerifyIfCollectionContainsGivenType()
        {
           List<object> collection = new List<object>
           {
              new TestType()
           };

            Verify.ThatCollectionIsOfType(collection, typeof(TestType));
        }

        [Fact]
        public void VerifyIfCollectionContainsExactGivenType()
        {
            List<TestType> collection = new List<TestType>
           {
              new TestType()
           };

            Verify.ThatCollectionIsOfExactType(collection, typeof(TestType));
        }
    }

    public class TestType
    {

    }
}