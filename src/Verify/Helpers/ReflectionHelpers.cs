using System;

namespace VerifyContainer.Helpers
{
    public static class ReflectionHelpers
    {
        public static bool CompareObjectValues(object expectedObj, object gotObj)
        {
            Type expectedType = expectedObj.GetType();

            var propertyInfos = expectedType.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                var expectedvalueA = propertyInfo.GetValue(expectedObj);
                var gotvalueB = propertyInfo.GetValue(gotObj);

                if (expectedvalueA != null && gotvalueB != null)
                {
                    if (propertyInfo.PropertyType.IsPrimitive || propertyInfo.PropertyType == typeof(string))
                    {
                        if (!expectedvalueA.Equals(gotvalueB))
                        {
                            return false;
                        }
                    }
                    else if (propertyInfo.PropertyType == typeof(DateTime))
                    {
                        var compare = DateTime.Compare((DateTime)expectedvalueA, (DateTime)gotvalueB);
                        if (compare != 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return CompareObjectValues(expectedvalueA, gotvalueB);
                    }
                }
                else if (!(expectedvalueA == null && gotvalueB == null))
                {
                    return false;
                }

            }

            return true;
        }
    }
}
