using System.Net;
using System.Text;
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

string RandomString(int size)
{
    Random random = new((int)DateTime.Now.Ticks);
    StringBuilder builder = new();
    char ch;
    for (int i = 0; i < size; i++)
    {
        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26*random.NextDouble() + 65)));
        builder.Append(ch);
    }
    return builder.ToString();
}