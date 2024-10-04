using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

/// <summary>
///     Represents a link entity with various properties such as URL, title, description, and status.
/// </summary>
[PublicAPI]
public class Link : EntityBase
{
    /// <summary>
    ///     Gets or sets a value indicating whether the link check is disabled.
    /// </summary>
    public bool CheckDisabled { get; set; }
    /// <summary>
    ///     Gets or sets the icon associated with the link.
    /// </summary>
    public string? Icon { get; set; }
    /// <summary>
    ///     Gets or sets the status of the link.
    /// </summary>
    public int Status { get; set; }
    /// <summary>
    ///     Gets or sets the tags associated with the link.
    /// </summary>
    public Tag[]? Tags { get; set; }
    /// <summary>
    ///     Gets or sets the title of the link.
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    ///     Gets or sets the URL of the link.
    /// </summary>
    public string Url { get; set; }
}
