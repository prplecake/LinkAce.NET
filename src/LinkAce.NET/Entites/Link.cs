namespace LinkAce.NET.Entites;

public class Link
{
    public bool CheckDisabled { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public int Id { get; set; }
    public bool IsPrivate { get; set; }
    public int Status { get; set; }
    public string? Title { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Url { get; set; }
    public int UserId { get; set; }
    public string[]? Tags { get; set; }
}
