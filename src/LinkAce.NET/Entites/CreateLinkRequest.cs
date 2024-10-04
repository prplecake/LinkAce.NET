using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

/// <summary>
///     Represents a link entity with various properties such as URL, title, description, and status.
/// </summary>
[PublicAPI]
public class CreateLinkRequest
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
    public string[]? Tags { get; set; }
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

    public static implicit operator CreateLinkRequest(Link link)
    {
        return new CreateLinkRequest
        {
            CheckDisabled = link.CheckDisabled,
            CreatedAt = link.CreatedAt,
            DeletedAt = link.DeletedAt,
            Description = link.Description,
            Icon = link.Icon,
            Id = link.Id,
            IsPrivate = link.IsPrivate,
            Status = link.Status,
            Tags = link.Tags?.Select(tag => tag.Name).ToArray(),
            Title = link.Title,
            UpdatedAt = link.UpdatedAt,
            Url = link.Url,
            UserId = link.UserId
        };
    }
}
