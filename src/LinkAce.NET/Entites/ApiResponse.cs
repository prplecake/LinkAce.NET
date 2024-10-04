using JetBrains.Annotations;
using LinkAce.NET.Entites;

namespace LinkAce.NET.ApiResponses;

/// <summary>
///     Represents the response from a search query for links.
/// </summary>
[PublicAPI]
public class ApiResponse<T>
{
    /// <summary>
    ///     Gets or sets the current page number.
    /// </summary>
    public int CurrentPage { get; set; }
    /// <summary>
    ///     Gets or sets the list of links returned by the search.
    /// </summary>
    public T? Data { get; set; }
    /// <summary>
    ///     Gets or sets the URL of the first page.
    /// </summary>
    public string? FirstPageUrl { get; set; }
    /// <summary>
    ///     Gets or sets the starting record number on the current page.
    /// </summary>
    public int? From { get; set; }
    /// <summary>
    ///     Gets or sets the last page number.
    /// </summary>
    public int LastPage { get; set; }
    /// <summary>
    ///     Gets or sets the URL of the last page.
    /// </summary>
    public string? LastPageUrl { get; set; }
    /// <summary>
    ///     Gets or sets the URL of the next page.
    /// </summary>
    public string? NextPageUrl { get; set; }
    /// <summary>
    ///     Gets or sets the path of the search query.
    /// </summary>
    public string Path { get; set; }
    /// <summary>
    ///     Gets or sets the number of records per page.
    /// </summary>
    public string PerPage { get; set; }
    /// <summary>
    ///     Gets or sets the URL of the previous page.
    /// </summary>
    public string? PreviousPageUrl { get; set; }
    /// <summary>
    ///     Gets or sets the ending record number on the current page.
    /// </summary>
    public int? To { get; set; }
    /// <summary>
    ///     Gets or sets the total number of records found.
    /// </summary>
    public int Total { get; set; }
}
