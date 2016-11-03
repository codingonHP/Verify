using System;
using System.Collections.Generic;
using VerifyContainer;
using Xunit;

namespace VerifyThatUnitTest.UnitTests
{
    public class CollectionsUnitTest
    {
        class MyClass
        {
            public int A { get; set; }
            public string B { get; set; }
            public float C { get; set; }
            public DateTime D { get; set; }
            public MyClass M { get; set; }
        }

        [Fact]
        public void VerifyIntCollectionAreEqual()
        {
            List<int> gotList = new List<int> { 1, 2, 4, 5, 6, 7 };
            List<int> expectedList = new List<int> { 1, 2, 4, 5, 6, 7 };
            Verify.ThatBothCollectionAreEqual(expectedList, gotList);
        }

        [Fact]
        public void VerifyFloatCollectionAreEqual()
        {
            List<float> gotList = new List<float> { 1.0f, 2f, 4f, 5f, 6f, 7f };
            List<float> expectedList = new List<float> { 1.0f, 2f, 4f, 5f, 6f, 7f };
            Verify.ThatBothCollectionAreEqual(expectedList, gotList);
        }

        [Fact]
        public void VerifyObjectCollectionAreEqual()
        {
            //Case 1 : empty objects
            List<MyClass> gotList = new List<MyClass> { new MyClass() };
            List<MyClass> expectedList = new List<MyClass> { new MyClass() };
            Verify.ThatBothCollectionAreEqual(expectedList, gotList);

            //Case 2: Populated objects
            gotList = new List<MyClass> { new MyClass
            {
                A = 10,
                B = "Hello World",
                C = 10f,
                D = DateTime.MaxValue
            } };
            expectedList = new List<MyClass> { new MyClass
            {
                A = 10,
                B = "Hello World",
                C = 10f,
                D = DateTime.MaxValue
            } };
            Verify.ThatBothCollectionAreEqual(expectedList, gotList);

            //Case 3: Deep nested objects
            gotList = new List<MyClass> { new MyClass
            {
                A = 10,
                B = "Hello World",
                C = 10f,
                D = DateTime.MaxValue,
                M = new MyClass{
                                    A = 10,
                                    B = "Hello World",
                                    C = 10f,
                                    D = DateTime.MaxValue
                                }
            } };
            expectedList = new List<MyClass> { new MyClass
            {
                A = 10,
                B = "Hello World",
                C = 10f,
                D = DateTime.MaxValue,
                M = new MyClass{
                                    A = 10,
                                    B = "Hello World",
                                    C = 10f,
                                    D = DateTime.MaxValue
                                }
            } };

            Verify.ThatBothCollectionAreEqual(expectedList, gotList);
        }
    }
}