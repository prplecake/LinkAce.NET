using System.Net.Http.Headers;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkAce.NET.Tests
{
    [TestClass]
    public class MetaTests
    {
        [TestMethod]
        public void UserAgent_ShouldContainCorrectNameAndVersion()
        {
            // Arrange
            var expectedName = "LinkAce.NET";
            var expectedVersion = Assembly.GetEntryAssembly()!.GetName().Version!.ToString();
            var expectedUserAgent = new ProductInfoHeaderValue(expectedName, expectedVersion);

            // Act
            var actualUserAgent = Meta.UserAgent;

            // Assert
            Assert.AreEqual(expectedUserAgent.Product.Name, actualUserAgent.Product.Name);
            Assert.AreEqual(expectedUserAgent.Product.Version, actualUserAgent.Product.Version);
        }

        [TestMethod]
        public void AssemblyVersion_ShouldNotBeNullOrEmpty()
        {
            // Act
            var assemblyVersion = Meta.AssemblyVersion;

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(assemblyVersion));
        }
    }
}
