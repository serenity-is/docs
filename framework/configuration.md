# Configuration

Serenity integrates with the built-in Configuration system of ASP.NET Core.

We also prefer the `Options` pattern where possible, which provides an abstraction of 
configuration retrieval, and from its storage location. This is achieved using the dependency injection pattern.

The configuration for a typical Serene / StartSharp application resides in the `appsettings.json` file
by default but it is possible to move some parts or all of it to a database, cloud, or any other location.

## appsettings.machine.json

In addition to the standard `appsettings.json` and `appsettings.{Environment}.json` files, the template also loads an optional `appsettings.machine.json` file. It is added in `Program.cs`:

```cs
return Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStaticWebAssets();
        webBuilder.UseStartup<Startup>();
    })
    .ConfigureAppConfiguration((builderContext, config) =>
    {
        config.AddJsonFile("appsettings.bundles.json");
        config.AddJsonFile("appsettings.machine.json", optional: true);
    });
```

Because it is loaded after the other `appsettings` files, any value it contains **overrides** the corresponding ones. It is intended for machine-specific local settings that differ from developer to developer, such as connection strings, SMTP settings, or toggling features locally.

`appsettings.machine.json` is local only:

- It is **ignored by source control** — the template's `.gitignore` contains `appsettings*.machine.json`, so it is never committed.
- It should **not be deployed** — it only exists on the machine it was created on.

If a value should take effect for everyone, put it in `appsettings.json` (or `appsettings.{Environment}.json`) instead.

## Options Pattern

Here is a sample of configuration classes that are using the options pattern:

| assembly              | class |
| --------------------- | ----- |
| Serenity.Net.Services | [ConnectionStringOptions](../api/dotnet/Serenity.Net.Services/Serenity.Data/ConnectionStringOptions.md) |
| Serenity.Net.Services | [UploadSettings](../api/dotnet/Serenity.Net.Services/Serenity.Web/UploadSettings.md) |
| Serenity.Net.Web      | [CssBundlingOptions](../api/dotnet/Serenity.Net.Web/Serenity.Web/CssBundlingOptions.md) |
| Serenity.Net.Web      | [ScriptBundlingOptions](../api/dotnet/Serenity.Net.Web/Serenity.Web/ScriptBundlingOptions.md) |

### Automatic Configuration with ConfigureSections

Each option class declares the name of the configuration section it binds to through the `[DefaultSectionKey]` attribute:

```cs
[DefaultSectionKey(SectionKey)]
public class ConnectionStringOptions : Dictionary<string, ConnectionStringEntry>,
    IOptions<ConnectionStringOptions>
{
    /// <summary>
    /// Default section key for ConnectionStringOptions
    /// </summary>
    public const string SectionKey = "Data";

    //...

}
```

The `ConfigureSections` extension method, called once in `Startup.cs`, scans the type source for every option class marked with `[DefaultSectionKey]` and automatically calls `services.Configure<TOptions>(Configuration.GetSection(...))` for it:

```cs
services.ConfigureSections(Configuration);
```

With that single call, Serenity's built-in settings — connection strings, upload, script/CSS bundling, SMTP, ClamAV, membership, environment, and more — are all bound to their configuration sections. You no longer need to write the manual `services.Configure<...>` calls yourself.

You only have to configure an option class manually if it doesn't carry a `[DefaultSectionKey]` attribute, e.g. one of your own custom options classes:

```cs
services.Configure<MyCustomOptions>(Configuration.GetSection("MyCustom"));
```

See the documents below for more information about ASP.NET Core configuration and options pattern:

[Configuration in ASP.NET Core - Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-10.0)

[Options Pattern in ASP.NET Core - Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-10.0)