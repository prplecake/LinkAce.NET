using LinkAce.NET.Entites;

namespace LinkAce.NET.Extensions;

public static class StringArrayExtensions
{
    /// <summary>
    ///     Converts an array of strings to an array of Tag objects.
    /// </summary>
    /// <param name="tags">The array of strings to convert.</param>
    /// <returns>An array of Tag objects with the Name property set to the input strings.</returns>
    public static Tag[] ToTagArray(this string[] tags)
        => tags.Select(t => new Tag { Name = t }).ToArray();
}
