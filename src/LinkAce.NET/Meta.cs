using System.Net.Http.Headers;
using System.Reflection;

namespace LinkAce.NET;

/// <summary>
///     Provides metadata information about the LinkAce.NET package.
/// </summary>
public static class Meta
{
    private const string Name = "LinkAce.NET";
    private static readonly string AssemblyVersion = Assembly.GetEntryAssembly()!.GetName().Version!.ToString();
    /// <summary>
    ///     The user agent information for HTTP requests.
    /// </summary>
    public static readonly ProductInfoHeaderValue UserAgent = new(Name, AssemblyVersion);
}
