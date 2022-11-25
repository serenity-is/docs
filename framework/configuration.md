# Configuration

Serenity integrates with the built-in Configuration system of ASP.NET Core.

We also prefer the `Options` pattern where possible, which provides an abstraction of 
configuration retrieval, and from its storage location. This is achieved using the dependency injection pattern.

The configuration for a typical Serene / StartSharp application resides in the `appsettings.json` file
by default but it is possible to move some parts or all of it to a database, cloud, or any other location.

Here is a sample of configuration classes that are using options pattern:

| assembly              | class |
| --------------------- | ----- |
| Serenity.Net.Entity   | [ConnectionStringOptions](../api/dotnet/Serenity.Net.Data/Serenity.Data/ConnectionStringOptions.md) |
| Serenity.Net.Services | [UploadSettings](../api/dotnet/Serenity.Net.Services/Serenity.Web/UploadSettings.md) |
| Serenity.Net.Web      | [CssBundlingOptions](../api/dotnet/Serenity.Net.Web/Serenity.Web/CssBundlingOptions.md) |
| Serenity.Net.Web      | [ScriptBundlingOptions](../api/dotnet/Serenity.Net.Web/Serenity.Web/ScriptBundlingOptions.md) |

As we are using the `Options` pattern, all these configuration options should be bound to their relevant sections via `Configure` calls in `Startup.cs`:

```cs
services.Configure<ConnectionStringOptions>(
    Configuration.GetSection(ConnectionStringOptions.SectionKey));
services.Configure<CssBundlingOptions>(
    Configuration.GetSection(CssBundlingOptions.SectionKey));
services.Configure<LocalTextPackages>(
    Configuration.GetSection(LocalTextPackages.SectionKey));
services.Configure<ScriptBundlingOptions>(
    Configuration.GetSection(ScriptBundlingOptions.SectionKey));
services.Configure<UploadSettings>(
    Configuration.GetSection(UploadSettings.SectionKey));
services.Configure<Serenity.Extensions.EnvironmentSettings>(
    Configuration.GetSection(Serenity.Extensions.EnvironmentSettings.SectionKey));
```

We provide the default `SectionKey` for each configuration option as a constant in the class declaration:

```cs
    public class ConnectionStringOptions : Dictionary<string, ConnectionStringEntry>, 
        IOptions<ConnectionStringOptions>
    {
        /// <summary>
        /// Default sectionkey for ConnectionStringOptions
        /// </summary>
        public const string SectionKey = "Data";

        //...

    }
```

See the documents below for more information about ASP.NET Core configuration and options pattern:

[Configuration in ASP.NET Core - Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0)

[Options Pattern in ASP.NET Core - Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-7.0)