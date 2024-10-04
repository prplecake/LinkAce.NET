using JetBrains.Annotations;

namespace LinkAce.NET.Entites;

[PublicAPI]
public class Tag
{
    public DateTime CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public int Id { get; set; }
    public bool IsPrivate { get; set; }
    public string Name { get; set; }
    public Pivot Pivot { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int UserId { get; set; }

    public static implicit operator Tag(string v)
    {
        return new Tag { Name = v };
    }
}
