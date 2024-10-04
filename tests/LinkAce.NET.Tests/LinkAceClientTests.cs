using System.Net;
using LinkAce.NET.Entites;
using LinkAce.NET.Extensions;
using Moq;
using Moq.Protected;

namespace LinkAce.NET.Tests;

[TestClass]
public class LinkAceClientTests
{
    private LinkAceClient _client;
    private Mock<HttpMessageHandler> _mockHttpMessageHandler;
    [TestInitialize]
    public void Init()
    {
        _mockHttpMessageHandler = new Mock<HttpMessageHandler>();
        var httpClient = new HttpClient(_mockHttpMessageHandler.Object);
        _client = new LinkAceClient("https://links.example.com", TestData.TestApiKey, httpClient);
    }
    [TestMethod]
    public async Task SearchLinksByUrl_Success()
    {
        // Arrange
        _mockHttpMessageHandler.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(TestData.SearchLinkResponseJson)
            });

        // Act
        var result = await _client.SearchLinksByUrl("jrgnsn.net");

        // Assert
        Assert.IsNotNull(result);
    }
    [TestMethod]
    public async Task CreateLink_Success()
    {
        // Arrange
        _mockHttpMessageHandler.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(TestData.CreateLinkResponseJson)
            });

        // Act
        var result = await _client.CreateLink(new Link()
        {
            Title = "Test Link",
            Url = "https://jrgnsn.net",
            Description = "A test link",
            Tags = new[]{ "test" }.ToTagArray()
        });

        // Assert
        Assert.IsNotNull(result);

    }
}