using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

[PublicAPI]
public class Tag : EntityBase
{
    /// <summary>
    ///     Gets or sets the name of the tag.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    ///     Gets or sets the pivot associated with the tag.
    /// </summary>
    public Pivot Pivot { get; set; }
    /// <summary>
    ///     Implicitly converts a string to a Tag object.
    /// </summary>
    /// <param name="v">The string to convert.</param>
    /// <returns>A Tag object with the Name property set to the input string.</returns>
    public static implicit operator Tag(string v) => new() { Name = v };
}
