using System.Net;
using LinkAce.NET;
using Microsoft.Extensions.Configuration;
Console.WriteLine("Hello, World!");

var configuration = new ConfigurationBuilder()
    .AddYamlFile("settings.yml", false, true)
    .Build();

var handler = new HttpClientHandler()
{
    Proxy = new WebProxy("localhost:8080", false)
};
var httpClient = new HttpClient(handler);

var linkAceConfig = configuration.GetSection("LinkAce");
var linkAceClient = new LinkAceClient(linkAceConfig["Url"] ?? throw new InvalidOperationException(),
    linkAceConfig["ApiToken"] ?? throw new InvalidOperationException(),
    httpClient);
var results = linkAceClient.SearchLinksByUrl("jrgnsn.net").Result;

var _ = () => { };
