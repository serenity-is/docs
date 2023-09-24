# ServiceCollectionExtensions.AddBaseTexts method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds nested texts, enum texts, permission texts, row texts and json local text assets

```csharp
public static ILocalTextRegistry AddBaseTexts(this IServiceProvider provider, 
    IFileProvider webFileProvider = null)
```

| parameter | description |
| --- | --- |
| provider | The service provider that will be used to locate text registry and other types |
| webFileProvider | If passed, json texts from static web assets will be added from any assembly with a JsonLocalTextAssetsAttribute attribute |

## Return Value

Local text registry

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Provider is null |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)

---

# ServiceCollectionExtensions.AddBaseTexts method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds nested texts, enum texts, permission texts, row texts and json local text assets

```csharp
public static ILocalTextRegistry AddBaseTexts(this ILocalTextRegistry textRegistry, 
    ITypeSource typeSource, IRowTypeRegistry rowTypeRegistry = null, bool includeResources = true)
```

| parameter | description |
| --- | --- |
| textRegistry | Target text registry |
| typeSource | Type source from which to discover text sources |
| rowTypeRegistry | Row type registry |
| includeResources | True to include resource texts |

## Return Value

Local text registry

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | textRegistry or typeSource is null |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* interface [IRowTypeRegistry](../Serenity.Net.Entity/../../Serenity.Data/IRowTypeRegistry.md)
* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)