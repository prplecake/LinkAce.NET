using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Web;
using LinkAce.Api.Responses;
using LinkAce.Entites;
using Newtonsoft.Json;

namespace LinkAce.Api;

public class LinkAceClient
{
    private static string? _apiUrl;
    private static readonly HttpClient Client = new();
    public LinkAceClient(string linkAceUrl, string apiToken)
    {
        _apiUrl = $"{linkAceUrl}/api/v1";
        // Setup HttpClient
        Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
        Client.DefaultRequestHeaders.UserAgent.Add(Meta.UserAgent);
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
    }
    public async Task<HttpResponseMessage?> CreateLink(Link link)
    {
        var response = await Client.PostAsync($"{_apiUrl}/links",
            new StringContent(JsonConvert.SerializeObject(link), Encoding.UTF8,
                MediaTypeNames.Application.Json));
        return response;
    }
    public async Task<SearchLinkResponse?> SearchLinksByUrl(string url)
    {
        var uriBuilder = new UriBuilder($"{_apiUrl}/search/links");
        var query = HttpUtility.ParseQueryString(string.Empty);
        query["query"] = url;
        uriBuilder.Query = query.ToString();
        var response = await Client.GetAsync(uriBuilder.ToString());
        var obj = JsonConvert.DeserializeObject<SearchLinkResponse>(
            await response.Content.ReadAsStringAsync());
        return obj;
    }
    public async Task<HttpResponseMessage?> UpdateLinkById(int id, Link link)
    {
        var response = await Client.PatchAsync($"{_apiUrl}/links/{id}",
            new StringContent(JsonConvert.SerializeObject(link), Encoding.UTF8,
                MediaTypeNames.Application.Json));
        return response;
    }
}
