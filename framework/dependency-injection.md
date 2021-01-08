# Dependency Injection

Serenity uses the dependency injection pattern to abstract its dependencies and 
make it possible to work with your chosen libraries and service providers.

Serenity is deeply integrated with built-in Dependency Injection feature of ASP.NET Core.

We provide some extension methods to easily configure the default Serenity services 
in *Serenity.Extensions.DependencyInjection* namespace of some Serenity assemblies:

| assembly          | class |
| ----------------- | ----- |
| Serenity.Core     | [CoreServiceCollectionExtensions](../api/dotnet/Serenity.Net.Core/Serenity.Extensions.DependencyInjection/CoreServiceCollectionExtensions.md) |
| Serenity.Entity   | [EntityServiceCollectionExtensions](../api/dotnet/Serenity.Net.Entity/Serenity.Extensions.DependencyInjection/EntityServiceCollectionExtensions.md) |
| Serenity.Services | [ServiceCollectionExtensions](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions.md) |
| Serenity.Web      | [DynamicScriptServiceCollectionExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Extensions.DependencyInjection/DynamicScriptServiceCollectionExtensions.md) |

See document below for more info about DI in ASP.NET Core framework:

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0

> Before v5, Serenity used to have a service location container, but since then we completely migrated to ASP.NET Core DI.