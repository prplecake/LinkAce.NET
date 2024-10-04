using LinkAce.NET.Entites;
using LinkAce.NET.Extensions;

namespace LinkAce.NET.Tests.Extensions;

[TestClass]
public class StringArrayExtensionsTests
{

    [TestMethod]
    public void ToTagArray_Success()
    {
        // Arrange
        string[] expectedNames = { "TestTag1", "TestTag2", "TestTag3" };

        // Act
        Tag[] tags = expectedNames.ToTagArray();

        // Assert
        Assert.AreEqual(expectedNames.Length, tags.Length);
        for (int i = 0; i < expectedNames.Length; i++)
        {
            Assert.AreEqual(expectedNames[i], tags[i].Name);
        }
    }
}
