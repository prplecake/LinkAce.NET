using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

/// <summary>
///     Represents a link entity with various properties such as URL, title, description, and status.
/// </summary>
[PublicAPI]
public class Link
{
    /// <summary>
    ///     Gets or sets a value indicating whether the link check is disabled.
    /// </summary>
    public bool CheckDisabled { get; set; }
    /// <summary>
    ///     Gets or sets the date and time when the link was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    ///     Gets or sets the date and time when the link was deleted, if applicable.
    /// </summary>
    public DateTime? DeletedAt { get; set; }
    /// <summary>
    ///     Gets or sets the description of the link.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    ///     Gets or sets the icon associated with the link.
    /// </summary>
    public string? Icon { get; set; }
    /// <summary>
    ///     Gets or sets the unique identifier for the link.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    ///     Gets or sets a value indicating whether the link is private.
    /// </summary>
    public bool IsPrivate { get; set; }
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
    ///     Gets or sets the date and time when the link was last updated.
    /// </summary>
    public DateTime UpdatedAt { get; set; }
    /// <summary>
    ///     Gets or sets the URL of the link.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    ///     Gets or sets the user identifier associated with the link.
    /// </summary>
    public int UserId { get; set; }
}
