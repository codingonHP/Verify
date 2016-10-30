using System;
using Verify.Exceptions;
namespace Verify
{
    public static partial class Verify
    {
        public static bool IsTrue(bool condition)
        {
            if (condition)
            {
                return true;
            }

            throw new NotTrueException("Expecting true, got false instead.");
        }

        public static bool IsFalse(bool condition)
        {
            if (!condition)
            {
                return true;
            }

            throw new NotFalseException("Expecting false, got true instead.");
        }

        public static bool IsPositive(int? number)
        {
            if (number != null && number >= 0)
            {
                return true;
            }

            throw new IntNotPositiveException($"{number} is not positive.");
        }

        public static bool IsNegative(int? number)
        {
            if (number != null && number <= 0)
            {
                return true;
            }

            throw new IntNotNegativeException($"{number} is not negative.");
        }

        public static bool IsNull(object toVerify)
        {
            if (toVerify == null)
            {
                return true;
            }

            throw new ArgumentNotNullException($"{toVerify.GetType()} : { nameof(toVerify)} `toVerify` is not null");
        }

        public static bool IsNotNull(object toVerify)
        {
            if (toVerify != null)
            {
                return true;
            }

            throw new ArgumentNullException(nameof(toVerify) + " is null.");
        }
    }

   
}