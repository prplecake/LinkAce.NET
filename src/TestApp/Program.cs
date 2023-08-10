using LinkAce.Api;
using Microsoft.Extensions.Configuration;
Console.WriteLine("Hello, World!");

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();

var linkAceConfig = configuration.GetSection("LinkAce");
var linkAceClient = new LinkAceClient(linkAceConfig["Url"] ?? throw new InvalidOperationException(),
    linkAceConfig["ApiToken"] ?? throw new InvalidOperationException());
var results = linkAceClient.SearchLinksByUrl("jrgnsn.net").Result;

var _ = () => { };
