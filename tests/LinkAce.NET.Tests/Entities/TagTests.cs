using LinkAce.NET.Entites;
using LinkAce.NET.Tests.Helpers;

namespace LinkAce.NET.Tests.Entities;

[TestClass]
public class TagTests
{
    [TestMethod]
    public void Tag_HasProperties()
    {
        // Arrange
        Tag obj = new();
        const int expectedCount = 8;

        // Act
        Assert.AreEqual(expectedCount, obj.PropertyCount());
        Assert.IsTrue(obj.HasProperty("CreatedAt"));
        Assert.IsTrue(obj.HasProperty("DeletedAt"));
        Assert.IsTrue(obj.HasProperty("Id"));
        Assert.IsTrue(obj.HasProperty("IsPrivate"));
        Assert.IsTrue(obj.HasProperty("Name"));
        Assert.IsTrue(obj.HasProperty("Pivot"));
        Assert.IsTrue(obj.HasProperty("UpdatedAt"));
        Assert.IsTrue(obj.HasProperty("UserId"));
    }

    [TestMethod]
    public void ImplicitConversion_String_To_Tag()
    {
        // Arrange
        const string expectedName = "TestTag";

        // Act
        Tag tag = expectedName;

        // Assert
        Assert.AreEqual(expectedName, tag.Name);
    }
}
