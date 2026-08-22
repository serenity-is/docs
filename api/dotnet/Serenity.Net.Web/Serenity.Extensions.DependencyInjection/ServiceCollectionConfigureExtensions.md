# ServiceCollectionConfigureExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

DI extension methods related to configuration and options

```csharp
public static class ServiceCollectionConfigureExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ConfigureSection&lt;TOptions&gt;](ServiceCollectionConfigureExtensions/ConfigureSection.md)(…) | Calls `Configure<TOptions>` with the section key determined from DefaultSectionKeyAttribute on *TOptions*. |
| static [ConfigureSections](ServiceCollectionConfigureExtensions/ConfigureSections.md)(…) | Calls `Configure<TOptionsType>` for all setting classes that have a DefaultSectionKeyAttribute. |

## See Also

* **Source:** *[ServiceCollectionConfigureExtensions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Common/ServiceCollectionConfigureExtensions.cs)*