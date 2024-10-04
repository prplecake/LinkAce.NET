using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

[PublicAPI]
public class Pivot
{
    /// <summary>
    ///     Gets or sets the ID of the link associated with the pivot.
    /// </summary>
    public int LinkId { get; set; }
    /// <summary>
    ///     Gets or sets the ID of the tag associated with the pivot.
    /// </summary>
    public int TagId { get; set; }
}
