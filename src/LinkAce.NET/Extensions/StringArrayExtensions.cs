using LinkAce.NET.Entites;

namespace LinkAce.NET.Extensions;

public static class StringArrayExtensions
{
    public static Tag[] ToTagArray(this string[] tags)
        => tags.Select(t => new Tag { Name = t }).ToArray();
}
