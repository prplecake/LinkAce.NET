using System.Reflection;

namespace LinkAce.NET.Tests.Helpers;

public static class EntityTests
{
    public static bool HasMethod(this object obj, string methodName)
    {
        var type = obj.GetType();
        try
        {
            return type.GetMethod(methodName) is not null;
        }
        catch (AmbiguousMatchException)
        {
            return true;
        }
    }
    public static bool HasProperty(this object obj, string propertyName)
        => obj.GetType().GetProperty(propertyName) is not null;
    public static int PropertyCount(this object obj)
        => obj.GetType().GetProperties().Length;
}
