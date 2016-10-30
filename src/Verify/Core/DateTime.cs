using System;

namespace VerifyContainer
{
    public static partial class Verify
    {
        public static bool ThatStringRepresentsValidDateTime(string dateTimeString, out DateTime parseDateTime)
        {
            try
            {
                var dateTime = DateTime.Parse(dateTimeString);
                parseDateTime = dateTime;
                return true;
            }
            catch (ArgumentNullException)
            {
                throw new InvalidCastException($"{dateTimeString} <- cannot be parsed to valid datetime because dateTimeString is null. Haunting null is here :)");
            }
            catch (FormatException)
            {
                throw new InvalidCastException($"{dateTimeString} <- cannot be parsed to valid date-time.");
            }
            catch (Exception)
            {
                throw new InvalidCastException($"{dateTimeString} <- cannot be parsed to valid date-time.");
            }
        }
    }
}