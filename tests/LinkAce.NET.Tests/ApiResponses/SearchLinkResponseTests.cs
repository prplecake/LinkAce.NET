using LinkAce.NET.ApiResponses;
using LinkAce.NET.Tests.Helpers;

namespace LinkAce.NET.Tests.ApiResponses;

[TestClass]
public class SearchLinkResponseTests
{
    [TestMethod]
    public void SearchLinkResponse_HasProperties()
    {
        // Arrange
        SearchLinkResponse obj = new();
        const int expectedCount = 12;

        // Assert
        Assert.AreEqual(expectedCount, obj.PropertyCount());
        Assert.IsTrue(obj.HasProperty("CurrentPage"));
        Assert.IsTrue(obj.HasProperty("Data"));
        Assert.IsTrue(obj.HasProperty("FirstPageUrl"));
        Assert.IsTrue(obj.HasProperty("From"));
        Assert.IsTrue(obj.HasProperty("LastPage"));
        Assert.IsTrue(obj.HasProperty("LastPageUrl"));
        Assert.IsTrue(obj.HasProperty("NextPageUrl"));
        Assert.IsTrue(obj.HasProperty("Path"));
        Assert.IsTrue(obj.HasProperty("PerPage"));
        Assert.IsTrue(obj.HasProperty("PreviousPageUrl"));
        Assert.IsTrue(obj.HasProperty("To"));
        Assert.IsTrue(obj.HasProperty("Total"));
    }
}
