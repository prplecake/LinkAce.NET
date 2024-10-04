using System.Net.Http.Headers;
using System.Reflection;

namespace LinkAce.NET;

public class Meta
{
    private const string
        Name = "LinkAce.NET";
    public static readonly string AssemblyVersion = Assembly.GetEntryAssembly()!.GetName().Version!.ToString();
    public static readonly ProductInfoHeaderValue UserAgent = new(Name, AssemblyVersion);
}
