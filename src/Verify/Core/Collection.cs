using System;
using System.Collections.Generic;
using VerifyContainer.Exceptions;
using VerifyContainer.Helpers;

namespace VerifyContainer
{
    public static partial class Verify
    {
        public static bool ThatArrayIsEmpty<TArray>(TArray[] sourceArray)
        {
            if (sourceArray.Length == 0)
            {
                return true;
            }

            throw new CollectionNotEmpty($"Source array is not empty. Has { sourceArray.Length } elements");
        }

        public static bool ThatCollectionIsEmpty<T>(ICollection<T> collectionToVerify )
        {
            if (collectionToVerify.Count == 0)
            {
                return true;
            }

            throw new CollectionNotEmpty($"Source array is not empty. Has { collectionToVerify.Count } elements");
        }

        public static bool ThatCollectionContainsExactlyXElements<T>(ICollection<T> collectionToVerify, int memberCount)
        {
            if (collectionToVerify.Count == memberCount)
            {
                return true;
            }

            throw new CollectionNotOfValidSize($"Source collection actually has { collectionToVerify.Count } elements but we were expecting {memberCount} elements.");
        }

        public static bool ThatCollectionContainsAtLeastXElements<T>(ICollection<T> collectionToVerify, int memberCount)
        {
            if (collectionToVerify.Count >= memberCount)
            {
                return true;
            }

            throw new CollectionNotOfValidSize($"Source collection actually has { collectionToVerify.Count } elements but we were expecting at least{memberCount} elements.");
        }

        public static bool ThatCollectionContainsAtMostXElements<T>(ICollection<T> collectionToVerify, int memberCount)
        {
            if (collectionToVerify.Count <= memberCount)
            {
                return true;
            }

            throw new CollectionNotOfValidSize($"Source collection actually has { collectionToVerify.Count } elements but we were expecting at most {memberCount} elements.");
        }

        public static bool ThatCollectionContainsMoreThanXElements<T>(ICollection<T> collectionToVerify, int memberCount)
        {
            if (collectionToVerify.Count > memberCount)
            {
                return true;
            }

            throw new CollectionNotOfValidSize($"Source collection actually has { collectionToVerify.Count } elements but we were expecting  more than {memberCount} elements.");
        }

        public static bool ThatCollectionContainsLessThanXElements<T>(ICollection<T> collectionToVerify, int memberCount)
        {
            if (collectionToVerify.Count < memberCount)
            {
                return true;
            }

            throw new CollectionNotOfValidSize($"Source collection actually has { collectionToVerify.Count } elements but we were expecting less than {memberCount} elements.");
        }

        public static bool ThatCollectionSizeIsInRangeOfXExclusive<T>(ICollection<T> collectionToVerify, int minSizeExclusive, int maxSizeExclusive)
        {
            if (collectionToVerify.Count > minSizeExclusive && collectionToVerify.Count < maxSizeExclusive)
            {
                return true;
            }

            throw new CollectionNotOfValidSize($"Source collection actually has { collectionToVerify.Count } elements but we were expecting in range of [ {minSizeExclusive}, {maxSizeExclusive}] elements.");
        }

        public static bool ThatCollectionSizeIsInRangeOfXInclusive<T>(ICollection<T> collectionToVerify, int minSizeInclusive, int maxSizeInclusive)
        {
            if (collectionToVerify.Count >= minSizeInclusive && collectionToVerify.Count <= maxSizeInclusive)
            {
                return true;
            }

            throw new CollectionNotOfValidSize($"Source collection actually has { collectionToVerify.Count } elements but we were expecting in range of [ {minSizeInclusive}, {maxSizeInclusive}] elements.");
        }

        public static bool ThatBothCollectionAreEqual<TExpected, TGot>(ICollection<TExpected> expectedCollection, ICollection<TGot> gotCollection )
        {
            if (expectedCollection.Count != gotCollection.Count)
            {
                throw new CollectionMismatchException("expected and got collections are not same.");
            }

            if (typeof(TExpected) != typeof(TGot))
            {
                throw new InvalidCastException($"expected collection -> {typeof(TExpected)} and gotCollection -> {typeof(TGot)} are not of same type.");
            }

            if (typeof(TExpected).IsPrimitive)
            {
                int index = 0;
                foreach (var expected in expectedCollection)
                {
                    if (!((IList<TExpected>)gotCollection)[index++].Equals(expected))
                    {
                        throw  new CollectionMismatchException("expected and got collections are not same.");
                    }
                }
            }
            else
            {
                int index = 0;
                foreach (var expected in expectedCollection)
                {
                    if ( !Equals( expected, ((IList<TExpected>)gotCollection)[index++] ) )
                    {
                        throw new CollectionMismatchException("expected and got collections are not same.");
                    }
                }
            }

            return true;
        }

        public new static bool Equals(object x, object y)
        {
           return ReflectionHelpers.CompareObjectValues(x, y);
        }

    }
}