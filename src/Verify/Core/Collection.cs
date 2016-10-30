using System;
using System.Collections.Generic;
using VerifyContainer.Exceptions;

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

    }
}