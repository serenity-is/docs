# Configuration

Serenity integrates with built-in Configuration system of ASP.NET Core.

We also prefer *Options* pattern where possible, which provides an abstraction of 
configuration retrieval and from its storage location. This is achieved using the dependency injection pattern.

The configuration for a typical Serene / StartSharp application resides in *appsettings.json* file
by default but it is possible to move some parts or all of it to a database, cloud or any other location.

Here is a sample of configuration classes that are using options pattern:

| assembly              | class |
| --------------------- | ----- |
| Serenity.Net.Entity   | [ConnectionStringOptions](../api/dotnet/Serenity.Net.Data/Serenity.Data/ConnectionStringOptions.md) |
| Serenity.Net.Services | [UploadSettings](../api/dotnet/Serenity.Net.Services/Serenity.Web/UploadSettings.md) |
| Serenity.Net.Web      | [CssBundlingOptions](../api/dotnet/Serenity.Net.Web/Serenity.Web/CssBundlingOptions.md) |
| Serenity.Net.Web      | [ScriptBundlingOptions](../api/dotnet/Serenity.Net.Web/Serenity.Web/ScriptBundlingOptions.md) |


See documents below on more information about ASP.NET Core configuration and options pattern:

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-5.0

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-5.0