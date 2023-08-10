using LinkAce.Entites;

namespace LinkAce.Api.Responses;

public class SearchLinkResponse
{
    public int CurrentPage { get; set; }
    public List<Link>? Data { get; set; }
    public string? FirstPageUrl { get; set; }
    public int? From { get; set; }
    public int LastPage { get; set; }
    public string? LastPageUrl { get; set; }
    public string? NextPageUrl { get; set; }
    public string Path { get; set; }
    public string PerPage { get; set; }
    public string? PreviousPageUrl { get; set; }
    public int? To { get; set; }
    public int Total { get; set; }
}
