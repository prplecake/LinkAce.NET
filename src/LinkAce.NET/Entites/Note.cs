using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

/// <summary>
///     Represents a note associated with a link.
/// </summary>
[PublicAPI]
public class Note : EntityBase
{
    /// <summary>
    ///     Gets or sets the content of the note.
    /// </summary>
    [JsonPropertyName("note")]
    public string Content { get; set; }
    /// <summary>
    ///     Gets or sets the ID of the link associated with the note.
    /// </summary>
    public int LinkId { get; set; }
}
