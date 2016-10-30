using System;
using VerifyContainer.Exceptions;

namespace VerifyContainer
{
    public static partial class Verify
    {
        public static bool ThatTheyAreEqual(string expected, string got)
        {
            if (!expected.Equals(got))
            {
                throw new StringAreNotEqualAsExpectedException($"We were expecting {expected} but instead got {got}");
            }

            return true;
        }

        public static bool ThatTheyAreEqual(string expected, string got, StringComparison comparison)
        {
            bool equals = false;
            switch (comparison)
            {
                case StringComparison.OrdinalIgnoreCase:
                    equals = expected.Equals(got, StringComparison.OrdinalIgnoreCase);
                    break;
                case StringComparison.CurrentCulture:
                    equals = expected.Equals(got, StringComparison.CurrentCulture);
                    break;
                case StringComparison.CurrentCultureIgnoreCase:
                    equals = expected.Equals(got, StringComparison.CurrentCultureIgnoreCase);
                    break;
                case StringComparison.Ordinal:
                    equals = expected.Equals(got, StringComparison.Ordinal);
                    break;
            }
            if (!equals)
            {
                throw new StringAreNotEqualAsExpectedException($"We were expecting -> {expected} but instead got {got}");
            }

            return true;
        }

        public static bool ThatStringIsAllUpperCase(string assertString)
        {
            if (assertString.ToUpperInvariant().Equals(assertString))
            {
                return true;
            }

            throw new NotAllUpperCaseException($"string -> {assertString} is not all uppercase.");
        }

        public static bool ThatStringIsAllLowerCase(string assertString)
        {
            if (assertString.ToLowerInvariant().Equals(assertString))
            {
                return true;
            }

            throw new NotAllLowerCaseException($"string -> {assertString} is not all lowercase.");
        }

        public static bool ThatStringIsNullOrEmpty(string assertString)
        {
            if (string.IsNullOrEmpty(assertString))
            {
                return true;
            }

            throw new StringNotNullOrEmptyException($"string -> {assertString} is not null or empty.");
        }

        public static bool ThatStringIsNotNullButEmpty(string assertString)
        {
            if (assertString != null && assertString == string.Empty)
            {
                return true;
            }

            throw new StringNotNullButEmptyException($"string -> {assertString} is not null but empty.");
        }
    }
}