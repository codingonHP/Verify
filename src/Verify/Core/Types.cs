using System;
using System.Collections.Generic;
using VerifyContainer.Exceptions;

namespace VerifyContainer
{
    public static partial class Verify
    {
        public static bool ThatCollectionIsOfType<T>(IEnumerable<T> collection, Type got)
        {
            Type collectionContainsTypeT = typeof(T);
            if (collectionContainsTypeT == got || got.IsSubclassOf(collectionContainsTypeT))
            {
                return true;
            }

            throw new CollectionContainsInvalidType($"collection contains type of {collection.GetType()} but were expecting type of {got}");
        }

        public static bool ThatCollectionIsOfExactType<T>(IEnumerable<T> collection, Type got)
        {
            Type collectionContainsTypeT = typeof(T);
            if (collectionContainsTypeT == got)
            {
                return true;
            }

            throw new CollectionContainsInvalidType($"collection contains type of {collection.GetType()} but were expecting exact type of {got}");
        }

    }
}