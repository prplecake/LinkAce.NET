using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

[PublicAPI]
public class EntityBase
{
    /// <summary>
    ///     Gets or sets the date and time when the object was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    ///     Gets or sets the date and time when the object was deleted, if applicable.
    /// </summary>
    public DateTime? DeletedAt { get; set; }
    /// <summary>
    ///     Gets or sets the description of the object.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    ///     Gets or sets the unique identifier for the object.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    ///     Gets or sets a value indicating whether the object is private.
    /// </summary>
    public bool IsPrivate { get; set; }
    /// <summary>
    ///     Gets or sets the date and time when the object was last updated.
    /// </summary>
    public DateTime UpdatedAt { get; set; }
    /// <summary>
    ///     Gets or sets the user identifier associated with the link.
    /// </summary>
    public int UserId { get; set; }
}
