using System;
using VerifyContainer.Exceptions;

namespace VerifyContainer
{
    public static partial class Verify
    {
        public static bool ThatTheyAreEqual(int expected, int got)
        {
            if (expected != got)
            {
                throw new IntAreNotEqualAsExpectedException($"We were expecting {expected} but instead got {got}");
            }

            return true;
        }

        public static bool ThatTheyAreEqual(float expected, float got, float tolerance)
        {
            if (Math.Abs(expected - got) > tolerance)
            {
                return true;
            }

            throw new FloatsNotEqualAsExpected($"We were expecting {expected} but instead got {got}");
        }

        public static bool ThatTheyAreEqual(double expected, double got, float tolerance)
        {
            if (Math.Abs(expected - got) > tolerance)
            {
                return true;
            }

            throw new FloatsNotEqualAsExpected($"We were expecting {expected} but instead got {got}");
        }

    }
}