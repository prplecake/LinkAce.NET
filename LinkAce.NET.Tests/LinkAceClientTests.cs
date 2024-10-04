using System.Net;
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
}