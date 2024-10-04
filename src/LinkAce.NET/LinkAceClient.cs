using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Web;
using JetBrains.Annotations;
using LinkAce.NET.ApiResponses;
using LinkAce.NET.Entites;
using Newtonsoft.Json;

namespace LinkAce.NET;

/// <summary>
///     Client for interacting with the LinkAce.NET API.
/// </summary>
[PublicAPI]
public class LinkAceClient
{
    private static string? _apiUrl;
    private static HttpClient _client;
    /// <summary>
    ///     Initializes a new instance of the <see cref="LinkAceClient" /> class with the specified URL and HTTP client.
    /// </summary>
    /// <param name="linkAceUrl">The base URL of the LinkAce.NET instance.</param>
    /// <param name="httpClient">The HTTP client to use for requests.</param>
    public LinkAceClient(string linkAceUrl, HttpClient httpClient)
    {
        _apiUrl = $"{linkAceUrl}/api/v1";
        _client = httpClient;
    }
    /// <summary>
    ///     Initializes a new instance of the <see cref="LinkAceClient" /> class with the specified URL and API token.
    /// </summary>
    /// <param name="linkAceUrl">The base URL of the LinkAce.NET instance.</param>
    /// <param name="apiToken">The API token for authentication.</param>
    /// <param name="client">The HTTP client to use for requests.</param>
    public LinkAceClient(string linkAceUrl, string apiToken, HttpClient? client = null)
    {
        _apiUrl = $"{linkAceUrl}/api/v1";
        // Setup HttpClient
        _client = client ?? new HttpClient();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
        _client.DefaultRequestHeaders.UserAgent.Add(Meta.UserAgent);
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
    }
    /// <summary>
    ///     Creates a new link.
    /// </summary>
    /// <param name="link">The link to create.</param>
    /// <returns>The HTTP response message.</returns>
    public async Task<HttpResponseMessage?> CreateLink(Link link)
    {
        var response = await _client.PostAsync($"{_apiUrl}/links",
            new StringContent(JsonConvert.SerializeObject(link), Encoding.UTF8,
                MediaTypeNames.Application.Json));
        return response;
    }
    /// <summary>
    ///     Searches for links by URL.
    /// </summary>
    /// <param name="url">The URL to search for.</param>
    /// <returns>The search response containing the links.</returns>
    public async Task<SearchLinkResponse?> SearchLinksByUrl(string url)
    {
        var uriBuilder = new UriBuilder($"{_apiUrl}/search/links");
        var query = HttpUtility.ParseQueryString(string.Empty);
        query["query"] = url;
        uriBuilder.Query = query.ToString();
        var response = await _client.GetAsync(uriBuilder.ToString());
        var obj = JsonConvert.DeserializeObject<SearchLinkResponse>(
            await response.Content.ReadAsStringAsync());
        return obj;
    }
    /// <summary>
    ///     Updates a link by its ID.
    /// </summary>
    /// <param name="id">The ID of the link to update.</param>
    /// <param name="link">The updated link data.</param>
    /// <returns>The HTTP response message.</returns>
    public async Task<HttpResponseMessage?> UpdateLinkById(int id, Link link)
    {
        var response = await _client.PatchAsync($"{_apiUrl}/links/{id}",
            new StringContent(JsonConvert.SerializeObject(link), Encoding.UTF8,
                MediaTypeNames.Application.Json));
        return response;
    }
}
