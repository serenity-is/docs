# ServiceCollectionConfigureExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

DI extension methods related to configuration and options

```csharp
public static class ServiceCollectionConfigureExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ConfigureSection&lt;TOptions&gt;](ServiceCollectionConfigureExtensions/ConfigureSection.md)(…) | Calls `Configure&lt;TOptions&gt;` with the section key determined from DefaultSectionKeyAttribute on TOptions. |
| static [ConfigureSections](ServiceCollectionConfigureExtensions/ConfigureSections.md)(…) | Calls `Configure&lt;TOptionsType&gt;` for all setting classes with DefaultSectionKeyAttribute. |

## See Also

* **Source:** *[ServiceCollectionConfigureExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Common/ServiceCollectionConfigureExtensions.cs)*