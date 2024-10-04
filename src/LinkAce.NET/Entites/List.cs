using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

/// <summary>
///     Represents a list of links.
/// </summary>
[PublicAPI]
public class List : EntityBase
{
    /// <summary>
    ///     Gets or sets the collection of links in the list.
    /// </summary>
    public List<Link> Links { get; set; }
    /// <summary>
    ///     Gets or sets the name of the list.
    /// </summary>
    public string Name { get; set; }
}
